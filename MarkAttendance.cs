using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class MarkAttendance : Form
    {
        private Login loginForm;
        private string _professorId;

        // Default constructor - used by designer and Admin
        public MarkAttendance() : this(null)
        {
        }

        // Constructor for professors, receives ProfessorID
        public MarkAttendance(string professorId)
        {
            InitializeComponent();
            loginForm = new Login(); // Initialize once
            logoutButton.Visible = false; // Hide logout button initially
            _professorId = professorId;
            LoadCourses(); // Load filtered courses if professor is logged in
        }

        #region Database Connection

        private MySqlConnection GetConnection()
        {
            string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
            return new MySqlConnection(connectionString);
        }

        #endregion

        #region Course ComboBox - Load Courses

        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    string query;

                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Only get courses taught by this professor
                        query = @"
                            SELECT c.course_id, c.CourseName, c.CourseCode 
                            FROM classes cl
                            JOIN courses c ON cl.course_id = c.course_id
                            WHERE cl.ProfessorID = @professorId";
                    }
                    else
                    {
                        // Admin or no professor ID: show all courses
                        query = "SELECT course_id, CourseName, CourseCode FROM courses";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CourseComboBox.Items.Clear();

                            while (reader.Read())
                            {
                                int courseId = Convert.ToInt32(reader["course_id"]);
                                string courseName = reader["CourseName"].ToString();
                                string courseCode = reader["CourseCode"].ToString();

                                CourseComboBox.Items.Add(new CourseItem
                                {
                                    CourseId = courseId,
                                    CourseName = courseName,
                                    CourseCode = courseCode
                                });
                            }

                            if (CourseComboBox.Items.Count > 0)
                            {
                                CourseComboBox.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Load Students for Selected Course

        private void LoadStudents(int courseId)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    // Use the selected date from AttendanceDatePicker
                    DateTime selectedDate = AttendanceDateTimePicker.Value.Date;

                    // Query to get students enrolled in the selected course for the chosen date
                    string query = @"
                        SELECT DISTINCT s.student_id, s.FirstName, s.LastName,
                               (SELECT status FROM attendances 
                                WHERE student_id = s.student_id 
                                  AND course_id = @courseId 
                                  AND attendance_date = @attendanceDate
                                LIMIT 1) AS TodayStatus
                        FROM students s
                        JOIN classes c ON s.student_id = c.student_id
                        WHERE c.course_id = @courseId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@courseId", courseId);
                        cmd.Parameters.AddWithValue("@attendanceDate", selectedDate);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            StudentListDataGridView.Rows.Clear();

                            foreach (DataRow row in table.Rows)
                            {
                                string studentId = row["student_id"].ToString();
                                string fullName = row["FirstName"].ToString() + " " + row["LastName"].ToString();
                                string todayStatus = row["TodayStatus"]?.ToString();

                                bool isPresent = todayStatus == "Present";

                                StudentListDataGridView.Rows.Add(studentId, fullName, isPresent);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Event Handlers

        private void MarkAttendance_Load(object sender, EventArgs e)
        {
            // Optional initialization logic
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseComboBox.SelectedItem is CourseItem selectedItem)
            {
                CourseOutputLabel.Text = $"{selectedItem.CourseCode} - {selectedItem.CourseName}";

                // Validate date selection
                if (AttendanceDateTimePicker.Value.Date <= DateTime.MinValue)
                {
                    MessageBox.Show("Please select a valid date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                LoadStudents(selectedItem.CourseId);
            }
        }

        private void StudentListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                var cell = StudentListDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell is DataGridViewCheckBoxCell checkBoxCell)
                {
                    bool currentValue = Convert.ToBoolean(checkBoxCell.Value);
                    checkBoxCell.Value = !currentValue;
                }
            }
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (!(CourseComboBox.SelectedItem is CourseItem selectedItem))
            {
                MessageBox.Show("Please select a course.", "No Course Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int courseId = selectedItem.CourseId;
            DateTime attendanceDate = AttendanceDateTimePicker.Value.Date; // Use the selected date

            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open();

                    foreach (DataGridViewRow row in StudentListDataGridView.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string studentId = row.Cells[0].Value?.ToString();
                        bool present = Convert.ToBoolean(row.Cells[2].Value);
                        string status = present ? "Present" : "Absent";

                        string query = "INSERT INTO attendances (student_id, course_id, attendance_date, status) " +
                                       "VALUES (@studentId, @courseId, @attendanceDate, @status) " +
                                       "ON DUPLICATE KEY UPDATE status = @status";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.Add("@studentId", MySqlDbType.VarChar, 50).Value = studentId;
                            cmd.Parameters.Add("@courseId", MySqlDbType.Int32).Value = courseId;
                            cmd.Parameters.Add("@attendanceDate", MySqlDbType.Date).Value = attendanceDate;
                            cmd.Parameters.Add("@status", MySqlDbType.VarChar, 7).Value = status;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Attendance successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving attendance: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Helper Class for ComboBox Items

        public class CourseItem
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseCode { get; set; }

            public override string ToString()
            {
                return CourseName;
            }
        }

        #endregion

        #region Navigation Buttons

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (_professorId != null)
            {
                GenerateReport generateReport = new GenerateReport(_professorId);
                generateReport.Show();
            }
            else
            {
                MessageBox.Show("Professor ID is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            MarkAttendance attendance = new MarkAttendance();
            attendance.Show();
        }

        #endregion

        private void AttendanceDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Reload students when the date changes
            if (CourseComboBox.SelectedItem is CourseItem selectedItem)
            {
                LoadStudents(selectedItem.CourseId);
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Show confirmation message
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Hide(); // Hide dashboard
                loginForm.Show(); // Show login form
            }
        }

        private void expandPictureBox_Click(object sender, EventArgs e)
        {
            // Toggle visibility of the logout button
            logoutButton.Visible = !logoutButton.Visible;
        }
    }
}