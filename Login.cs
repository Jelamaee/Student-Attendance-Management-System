using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Login : Form
    {
        // Hardcoded admin credentials
        private const string ADMIN_USERNAME = "admin";
        private const string ADMIN_PASSWORD = "admin123";

        // Database connection string
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string inputUsername = UsernameTextBox.Text.Trim();
            string inputPassword = passwordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if it's the admin
            if (inputUsername.Equals(ADMIN_USERNAME, StringComparison.OrdinalIgnoreCase) &&
                inputPassword == ADMIN_PASSWORD)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
                return;
            }

            int? userId = null;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    // Step 1: Verify professor credentials from the Users table
                    string queryVerifyUser = "SELECT id, role FROM Users WHERE username = @username AND password = @password";
                    using (MySqlCommand commandVerifyUser = new MySqlCommand(queryVerifyUser, connection))
                    {
                        commandVerifyUser.Parameters.AddWithValue("@username", inputUsername);
                        commandVerifyUser.Parameters.AddWithValue("@password", inputPassword);

                        using (MySqlDataReader reader = commandVerifyUser.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Ensure the user is a professor
                            string role = reader["role"].ToString();
                            if (role != "professor")
                            {
                                MessageBox.Show("You are not authorized to access this system.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            // Assign userId here where it's still in scope
                            userId = Convert.ToInt32(reader["id"]);
                        }
                    }

                    // Check if userId was assigned
                    if (!userId.HasValue)
                    {
                        MessageBox.Show("Failed to retrieve user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Step 2: Fetch ProfessorID from the Professors table using user_id
                    string queryGetProfessorId = "SELECT ProfessorID FROM Professors WHERE user_id = @userId";
                    using (MySqlCommand commandGetProfessorId = new MySqlCommand(queryGetProfessorId, connection))
                    {
                        commandGetProfessorId.Parameters.AddWithValue("@userId", userId.Value);

                        using (MySqlDataReader reader = commandGetProfessorId.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Professor ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }

                            string professorId = reader["ProfessorID"].ToString();

                            // Step 3: Redirect to MarkAttendance form with the professor's courses
                            MarkAttendance markAttendance = new MarkAttendance(professorId);
                            markAttendance.Show();
                            this.Hide();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forgotPassLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotForm = new ForgotPassword();
            forgotForm.ShowDialog();
        }

        // Empty event handlers below are kept as-is
        private void title_Click(object sender, EventArgs e) { }
        private void email_Click(object sender, EventArgs e) { }
        private void UsernameTextBox_TextChanged(object sender, EventArgs e) { }
        private void password_Click(object sender, EventArgs e) { }
        private void passwordTextBox_TextChanged(object sender, EventArgs e) { }
        private void loginGroupBox_Enter(object sender, EventArgs e) { }
        private void title2_Click(object sender, EventArgs e) { }
    }
}