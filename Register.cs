using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Register : Form
    {
        // Database connection string
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        public Register()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Determine role based on checkbox
            string role = AdminCheckBox.Checked ? "admin" : "professor";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO Users (username, password, role) VALUES (@username, @password, @role)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password); // Consider hashing later
                        cmd.Parameters.AddWithValue("@role", role);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearForm();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            AdminCheckBox.Checked = false;
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Optional: You can show a message or do something when checkbox changes
            if (AdminCheckBox.Checked)
            {
                MessageBox.Show("This user will have admin privileges.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddUserTabPage_Click(object sender, EventArgs e)
        {

        }

        private void ProfessorCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}