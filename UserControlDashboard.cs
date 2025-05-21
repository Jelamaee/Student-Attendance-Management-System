using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class UserControlDashboard : UserControl
    {
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        public UserControlDashboard()
        {
            InitializeComponent();
            this.Load += UserControlDashboard_Load;
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            UpdateCounts();
        }

        private void UpdateCounts()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Get total students
                    var studentCmd = new MySqlCommand("SELECT COUNT(*) FROM students", conn);
                    int studentCount = Convert.ToInt32(studentCmd.ExecuteScalar());
                    TotalStudentOutputLabel.Text = studentCount.ToString();

                    // Get total attendances
                    var attendanceCmd = new MySqlCommand("SELECT COUNT(*) FROM attendances", conn);
                    int attendanceCount = Convert.ToInt32(attendanceCmd.ExecuteScalar());
                    TotalAttendanceOutputLabel.Text = attendanceCount.ToString();

                    // Get total roles
                    var roleCmd = new MySqlCommand("SELECT COUNT(*) FROM users", conn);
                    int roleCount = Convert.ToInt32(roleCmd.ExecuteScalar());
                    TotalRoleOutputLabel.Text = roleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void rolePanel_Paint(object sender, PaintEventArgs e)
        {
            // Optional: Add custom drawing logic here
        }

        private void TotalStudentOutputLabel_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void TotalAttendanceOutputLabel_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }

        private void TotalRoleOutputLabel_Click(object sender, EventArgs e)
        {
            // Optional: Handle label click
        }
    }
}