using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Student_Attendance_Management_System
{
    public partial class ForgotPassword : Form
    {
        // Database connection string (same as in Login.cs)
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void ConfirmPassTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add live validation if needed
        }

        private void NewPassTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add live validation if needed
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add live validation if needed
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string newPassword = NewPassTextBox.Text.Trim();
            string confirmPassword = ConfirmPassTextBox.Text.Trim();

            // Check for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if passwords match
            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if the username exists
                    string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE username = @username";
                    using (MySqlCommand checkUserCmd = new MySqlCommand(checkUserQuery, conn))
                    {
                        checkUserCmd.Parameters.AddWithValue("@username", username);

                        int userExists = Convert.ToInt32(checkUserCmd.ExecuteScalar());

                        if (userExists == 0)
                        {
                            MessageBox.Show("Username does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Update the password
                    string updatePasswordQuery = "UPDATE Users SET password = @newPassword WHERE username = @username";
                    using (MySqlCommand updatePasswordCmd = new MySqlCommand(updatePasswordQuery, conn))
                    {
                        updatePasswordCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updatePasswordCmd.Parameters.AddWithValue("@username", username);

                        int rowsAffected = updatePasswordCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Password has been successfully reset.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close(); // Close the form after successful reset
                        }
                        else
                        {
                            MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without doing anything
        }

        private void ResetPassGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}