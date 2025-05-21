using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;

namespace Student_Attendance_Management_System
{
    public partial class GenerateReport : Form
    {
        private Login loginForm;
        private string _professorId; // Holds the logged-in professor's ID
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        // Default constructor - used by designer or Admin
        public GenerateReport() : this(null)
        {
        }

        // Constructor for professors, receives ProfessorID
        public GenerateReport(string professorId)
        {
            InitializeComponent();
            loginForm = new Login(); // Initialize once
            logoutButton.Visible = false; // Hide logout button initially
            _professorId = professorId;
            LoadCourses();  // Load courses taught by the professor
            LoadStudents(); // Load students under professor
        }

        #region Load Courses into ComboBox
        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Fetch courses taught by the current professor
                        query = @"
                            SELECT c.course_id, c.CourseName, c.CourseCode 
                            FROM classes cl
                            JOIN courses c ON cl.course_id = c.course_id
                            WHERE cl.ProfessorID = @professorId";
                    }
                    else
                    {
                        // Admin view: show all courses
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

        #region Load Students into StudentIDComboBox
        private void LoadStudents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Only get students enrolled in courses taught by this professor
                        query = @"
                            SELECT DISTINCT s.student_id, s.FirstName, s.LastName
                            FROM students s
                            JOIN classes cl ON s.student_id = cl.student_id
                            WHERE cl.ProfessorID = @professorId
                            ORDER BY s.LastName";
                    }
                    else
                    {
                        // Admin: get all students
                        query = "SELECT student_id, FirstName, LastName FROM students ORDER BY LastName";
                    }
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            StudentIDComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                string studentId = reader["student_id"].ToString();
                                string firstName = reader["FirstName"].ToString();
                                string lastName = reader["LastName"].ToString();

                                StudentIDComboBox.Items.Add(new StudentItem
                                {
                                    StudentID = studentId,
                                    FirstName = firstName,
                                    LastName = lastName
                                });
                            }

                            // Auto-select first item if available
                            if (StudentIDComboBox.Items.Count > 0)
                            {
                                StudentIDComboBox.SelectedIndex = 0;
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

        #region Load Attendance for Selected Student (Uses dataGridView2)
        private void LoadAttendanceForStudent(string studentId)
        {
            try
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Get attendance only for this student under the logged-in professor
                        query = @"
                            SELECT a.attendance_id, c.CourseCode, s.student_id, s.FirstName, s.LastName, a.attendance_date, a.status
                            FROM attendances a
                            JOIN students s ON a.student_id = s.student_id
                            JOIN courses c ON a.course_id = c.course_id
                            JOIN classes cl ON a.student_id = cl.student_id AND a.course_id = cl.course_id
                            WHERE cl.ProfessorID = @professorId AND a.student_id = @studentId
                            ORDER BY a.attendance_date DESC";
                    }
                    else
                    {
                        // Admin view: show all attendance for this student
                        query = @"
                            SELECT a.attendance_id, c.CourseCode, s.student_id, s.FirstName, s.LastName, a.attendance_date, a.status
                            FROM attendances a
                            JOIN students s ON a.student_id = s.student_id
                            JOIN courses c ON a.course_id = c.course_id
                            WHERE a.student_id = @studentId
                            ORDER BY a.attendance_date DESC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            dataGridView2.DataSource = table;
                            RenameStudentReportColumns();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data for student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Rename Columns in Student Report DataGridView
        private void RenameStudentReportColumns()
        {
            SetColumnOrder(dataGridView2, new[]
            {
                ("attendance_id", "Attendance ID"),
                ("CourseCode", "Course Code"),
                ("student_id", "Student ID"),
                ("LastName", "Last Name"),
                ("FirstName", "First Name"),
                ("attendance_date", "Date"),
                ("status", "Status")
            });
        }
        #endregion

        #region Load Attendance Data for Class Report (Uses dataGridView1)
        private void LoadAttendanceData(int selectedCourseId = -1)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query;
                    if (!string.IsNullOrEmpty(_professorId) && selectedCourseId != -1)
                    {
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    JOIN classes cl ON s.student_id = cl.student_id AND c.course_id = cl.course_id
                    WHERE cl.ProfessorID = @professorId AND a.course_id = @courseId
                    ORDER BY a.attendance_date DESC";
                    }
                    else if (selectedCourseId != -1)
                    {
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    WHERE a.course_id = @courseId
                    ORDER BY a.attendance_date DESC";
                    }
                    else
                    {
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    ORDER BY a.attendance_date DESC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId) && selectedCourseId != -1)
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                            cmd.Parameters.AddWithValue("@courseId", selectedCourseId);
                        }
                        else if (selectedCourseId != -1)
                        {
                            cmd.Parameters.AddWithValue("@courseId", selectedCourseId);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;

                            RenameClassReportColumns(); // This will reorder & rename columns
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Rename Columns in Class Report DataGridView
        private void RenameClassReportColumns()
        {
            SetColumnOrder(dataGridView1, new[]
            {
                ("attendance_id", "Attendance ID"),
                ("student_id", "Student ID"),
                ("LastName", "Last Name"),
                ("FirstName", "First Name"),
                ("CourseCode", "Course Code"),
                ("attendance_date", "Date"),
                ("status", "Status")
            });
        }
        #endregion

        #region Helper Method: Reorder Columns
        private void SetColumnOrder(DataGridView dgv, (string colName, string headerText)[] orderedColumns)
        {
            foreach (var (colName, headerText) in orderedColumns)
            {
                if (dgv.Columns.Contains(colName))
                {
                    dgv.Columns[colName].HeaderText = headerText;
                    dgv.Columns[colName].DisplayIndex = Array.FindIndex(orderedColumns, x => x.colName == colName);
                }
            }
        }
        #endregion

        #region Event Handlers
        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseComboBox.SelectedItem is CourseItem selectedItem)
            {
                LoadAttendanceData(selectedItem.CourseId);
            }
        }

        private void StudentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentIDComboBox.SelectedItem is StudentItem selectedItem)
            {
                LoadAttendanceForStudent(selectedItem.StudentID);
            }
            else
            {
                dataGridView2.DataSource = null;
                dataGridView2.Rows.Clear();
            }
        }

        private void ClassReportTabPage_Click(object sender, EventArgs e)
        {
            LoadStudents(); // Ensure students are loaded when switching to this tab
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (_professorId != null)
            {
                GenerateReport generateReport = new GenerateReport(_professorId);
                generateReport.Show();
            }
            else
            {
                GenerateReport generateReport = new GenerateReport();
                generateReport.Show();
            }
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            MarkAttendance markAttendance = new MarkAttendance(_professorId);
            markAttendance.Show();
        }
        #endregion

        #region Helper Classes for ComboBox Items
        public class CourseItem
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseCode { get; set; }

            public override string ToString()
            {
                return $"{CourseCode} - {CourseName}";
            }
        }

        public class StudentItem
        {
            public string StudentID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public override string ToString()
            {
                return $"{StudentID} - {FirstName} {LastName}";
            }
        }
        #endregion

        #region Export Buttons
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Class Attendance Report";
                saveFileDialog.FileName = "ClassAttendanceReport.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Class Attendance");

                    // Export column headers
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                    }

                    // Export row data
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = cellValue?.ToString() ?? "";
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    string filePath = saveFileDialog.FileName;
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Class attendance report successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Student Attendance Report";
                saveFileDialog.FileName = "StudentAttendanceReport.xlsx";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Student Attendance");

                    // Export column headers
                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView2.Columns[i].HeaderText;
                    }

                    // Export row data
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView2.Columns.Count; j++)
                        {
                            var cellValue = dataGridView2.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = cellValue?.ToString() ?? "";
                        }
                    }

                    worksheet.Columns().AdjustToContents();
                    string filePath = saveFileDialog.FileName;
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Student attendance report successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = filePath,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Misc UI Events
        private void ClassReportTabPage_Click_1(object sender, EventArgs e)
        {
            // Handle tab page click here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events here if needed
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events here if needed
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
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
            logoutButton.Visible = !logoutButton.Visible;
        }
        #endregion
    }
}