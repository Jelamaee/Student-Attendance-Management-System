using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Register : Form
    {
        private Login loginForm;
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        private int selectedUserId = -1;
        private string selectedUsername = "";
        private string selectedRole = "";

        public Register()
        {
            InitializeComponent();
            loginForm = new Login(); // Initialize once
            logoutButton.Visible = false; // Hide logout button initially
            Load += Register_Load;
            SearchUserDataGridView.CellClick += SearchUserDataGridView_CellClick;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            LoadUsers(); // Load users when the form loads
        }

        private void LoadUsers()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Users";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            SearchUserDataGridView.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTotalUsersCount(); // Update label with total user count
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
                            // Get the last inserted user ID
                            string getLastIdQuery = "SELECT LAST_INSERT_ID()";
                            MySqlCommand idCmd = new MySqlCommand(getLastIdQuery, conn);
                            int userId = Convert.ToInt32(idCmd.ExecuteScalar());
                            MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Navigate to Professor form and pass the user ID
                            Professor professorForm = new Professor(userId);
                            professorForm.Show();
                            this.Hide(); // Hide the current form
                        }
                        else
                        {
                            MessageBox.Show("Failed to add user.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }

            LoadUsers(); // Refresh grid
            UpdateTotalUsersCount(); // Update total users count
        }

        private void ClearForm()
        {
            UsernameTextBox.Clear();
            PasswordTextBox.Clear();
            AdminCheckBox.Checked = false;
        }

        private void AdminCheckBox_CheckedChanged(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
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

        private void SearchUserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            Cclasses cclasses = new Cclasses();
            cclasses.Show();
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void professorButton_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void UpdateDeleteTabPage_Click(object sender, EventArgs e)
        {
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user from the list to update.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string newUsername = UDUserTextBox.Text.Trim();
            string newPassword = UDPassTextBox.Text.Trim();
            string newRole = AdminCheckBox.Checked ? "admin" : "professor";
            if (string.IsNullOrEmpty(newUsername))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Users SET username = @username, password = @password, role = @role WHERE id = @userId";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", newUsername);
                        if (!string.IsNullOrEmpty(newPassword)) // Only update password if changed
                            cmd.Parameters.AddWithValue("@password", newPassword);
                        else
                            cmd.Parameters.AddWithValue("@password", null); // Keep old password
                        cmd.Parameters.AddWithValue("@role", newRole);
                        cmd.Parameters.AddWithValue("@userId", selectedUserId);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers(); // Refresh grid
                            ClearUpdateFields();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateTotalUsersCount(); // Update total users count
        }

        private void deleteUserbutton_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user from the list to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this user?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "DELETE FROM Users WHERE id = @userId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", selectedUserId);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearUpdateFields();
                                LoadUsers(); // Refresh grid
                            }
                            else
                            {
                                MessageBox.Show("User could not be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateTotalUsersCount(); // Update total users count
            }
        }

        private void ClearUpdateFields()
        {
            UDUserTextBox.Clear();
            UDPassTextBox.Clear();
            AdminCheckBox.Checked = false;
            ProfessorCheckBox.Checked = false;
            selectedUserId = -1;
            selectedUsername = "";
            selectedRole = "";
        }

        private void SearchUserDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var row = SearchUserDataGridView.Rows[e.RowIndex];
                    selectedUserId = Convert.ToInt32(row.Cells["id"].Value);
                    selectedUsername = row.Cells["username"].Value?.ToString() ?? "";
                    selectedRole = row.Cells["role"].Value?.ToString() ?? "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTabControl.SelectedTab == UpdateDeleteTabPage && selectedUserId != -1)
            {
                UDUserTextBox.Text = selectedUsername;
                UDPassTextBox.Text = ""; // Don't show password for security
                AdminCheckBox.Checked = selectedRole == "admin";
                ProfessorCheckBox.Checked = selectedRole == "professor";
            }
        }

        private void UDUserTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void UDPassTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void TotalUsersOutputLabel_Click(object sender, EventArgs e)
        {
        }

        // Method to update total users label
        private void UpdateTotalUsersCount()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM Users";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int totalCount = Convert.ToInt32(cmd.ExecuteScalar());
                        TotalUsersOutputLabel.Text = totalCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching total user count: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}