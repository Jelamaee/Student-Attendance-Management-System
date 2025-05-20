using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Attendance : Form
    {
        // Database connection string
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection;

        public Attendance()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);

            // Load data into ComboBoxes
            LoadStudentIDs();
            LoadCourseCodes();
            LoadStatuses();

            // Load attendance records into DataGridView
            LoadAttendanceRecords();
        }

        private void LoadAttendanceRecords()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM attendances";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                AttendanceDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance records: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadStudentIDs()
        {
            try
            {
                connection.Open();
                string query = "SELECT student_id, CONCAT(student_id, ' - ', firstname, ' ', lastname) AS student_display FROM students";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                StudentIDComboBox.DataSource = dt;
                StudentIDComboBox.DisplayMember = "student_display";
                StudentIDComboBox.ValueMember = "student_id";

                StudentIDComboBox.SelectedIndex = -1; // Show blank initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading student IDs: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadCourseCodes()
        {
            try
            {
                connection.Open();
                string query = "SELECT course_id, CONCAT(course_id, ' - ', CourseCode) AS course_display FROM courses";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                CourseComboBox.DataSource = dt;
                CourseComboBox.DisplayMember = "course_display"; // Shows ID + Code
                CourseComboBox.ValueMember = "course_id";         // Uses course_id for saving

                CourseComboBox.SelectedIndex = -1; // Show blank initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course codes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadStatuses()
        {
            StudentStatusComboBox.Items.Clear();
            StudentStatusComboBox.Items.Add("Present");
            StudentStatusComboBox.Items.Add("Absent");

            StudentStatusComboBox.SelectedIndex = -1; // Show blank initially
        }

        private void SaveAttendanceButton_Click(object sender, EventArgs e)
        {
            if (StudentIDComboBox.SelectedIndex == -1 ||
                CourseComboBox.SelectedIndex == -1 ||
                StudentStatusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student, course, and status.");
                return;
            }

            // Get values from UI
            var selectedRow = StudentIDComboBox.SelectedItem as DataRowView;
            string studentId = selectedRow?["student_id"]?.ToString(); // Safe access
            string courseCode = CourseComboBox.SelectedValue?.ToString();
            DateTime attendanceDate = StudentDateTimePicker.Value.Date;
            string status = StudentStatusComboBox.SelectedItem.ToString();

            // Validate student ID
            if (string.IsNullOrWhiteSpace(studentId))
            {
                MessageBox.Show("Invalid student ID selected.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO attendances (student_id, course_id, attendance_date, status) VALUES (@student_id, @course_id, @attendance_date, @status)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@student_id", studentId);
                    cmd.Parameters.AddWithValue("@course_id", courseCode);
                    cmd.Parameters.AddWithValue("@attendance_date", attendanceDate);
                    cmd.Parameters.AddWithValue("@status", status);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Attendance marked successfully!");

                    LoadAttendanceRecords(); // Refresh grid
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving attendance: " + ex.Message);
                }
            }
        }

        #region Navigation Buttons

        private void dashboardButton_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void studentButton_Click_1(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void attendanceButton_Click_1(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
        }

        private void courseButton_Click_1(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
            this.Hide();
        }

        private void classButton_Click_1(object sender, EventArgs e)
        {
            Cclasses cclasses = new Cclasses();
            cclasses.Show();
            this.Hide();
        }

        private void professorButton_Click_1(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
            this.Hide();
        }

        private void departmentButton_Click_1(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void ReportsButton_Click_1(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        #endregion

        #region Unused Event Handlers (Optional)

        private void button1_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void markAttendanceTabPage_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void studentIDLabel_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder
        }

        private void panelBack_Paint(object sender, PaintEventArgs e)
        {
            // Placeholder
        }

        private void StudentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        private void StudentStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        #endregion
    }
}