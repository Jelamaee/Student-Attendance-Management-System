using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Professor : Form
    {
        private Login loginForm;
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection;
        private DataTable originalProfessorData;
        private int userId; // To store the passed user ID

        public Professor(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            loginForm = new Login(); // Initialize once
            logoutButton.Visible = false; // Hide logout button initially
            connection = new MySqlConnection(connectionString);
            this.Load += Professor_Load;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        public Professor()
            : this(-1) // Default constructor for designer
        {
        }

        private void Professor_Load(object sender, EventArgs e)
        {
            LoadProfessors();
        }

        private void LoadProfessors()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT * FROM professors";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                originalProfessorData = new DataTable();
                adapter.Fill(originalProfessorData);
                SearchProfessorDataGridView.DataSource = originalProfessorData;
                UpdateTotalProfOutputCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading professors: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void UpdateTotalProfOutputCountLabel()
        {
            if (SearchProfessorDataGridView.DataSource is DataView dv)
            {
                TotalProfOutputLabel.Text = " " + dv.Count.ToString();
            }
            else if (SearchProfessorDataGridView.DataSource is DataTable dt)
            {
                TotalProfOutputLabel.Text = " " + dt.Rows.Count.ToString();
            }
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide();
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
            this.Hide();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            Cclasses classForm = new Cclasses();
            classForm.Show();
            this.Hide();
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void professorButton_Click(object sender, EventArgs e)
        {
            LoadProfessors();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ProfessorLNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(ProfessorFNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(EmailTextBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    // Insert professor with the same ID as the user
                    string query = "INSERT INTO professors (LastName, FirstName, Email, user_id) VALUES (@LastName, @FirstName, @Email, @user_id)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LastName", ProfessorLNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@FirstName", ProfessorFNameTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@user_id", userId); // Use the passed user ID

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Professor added successfully!");
                        ClearAddProfessorsFields();
                        LoadProfessors();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add professor.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving professor: " + ex.Message);
            }
        }

        private void ClearAddProfessorsFields()
        {
            ProfessorLNameTextBox.Clear();
            ProfessorFNameTextBox.Clear();
            EmailTextBox.Clear();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (originalProfessorData == null)
                return;

            try
            {
                string searchValue = searchTextBox.Text.Trim();
                DataView dv = new DataView(originalProfessorData);

                if (!string.IsNullOrEmpty(searchValue))
                {
                    searchValue = searchValue.ToUpper();
                    List<string> filters = new List<string>();

                    if (int.TryParse(searchValue, out int professorId))
                    {
                        filters.Add($"ProfessorID = {professorId}");
                    }

                    filters.Add($"FirstName LIKE '%{searchValue}%'");
                    filters.Add($"LastName LIKE '%{searchValue}%'");

                    string combinedFilter = string.Join(" OR ", filters);
                    dv.RowFilter = combinedFilter;
                }
                else
                {
                    dv.RowFilter = "";
                }

                SearchProfessorDataGridView.DataSource = dv;
                UpdateTotalProfOutputCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                {
                    MessageBox.Show("Please enter a search term.");
                    return;
                }

                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string searchTerm = "%" + searchTextBox.Text.Trim() + "%";
                string query = "SELECT * FROM professors WHERE LastName LIKE @SearchTerm OR FirstName LIKE @SearchTerm OR Email LIKE @SearchTerm";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable tempTable = new DataTable();
                    tempTable.Load(reader);
                    SearchProfessorDataGridView.DataSource = tempTable;
                    UpdateTotalProfOutputCountLabel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during manual search: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void UpdateProfessorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UDProfessorLNameTextBox.Text))
                {
                    MessageBox.Show("Please search for a professor first.");
                    return;
                }

                int professorID = GetProfessorIDFromTagOrHiddenLabel();

                connection.Open();
                string query = "UPDATE professors SET FirstName=@FirstName, LastName=@LastName, Email=@Email WHERE ProfessorID=@ProfessorID";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", UDProfessorFNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@LastName", UDProfessorLNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Email", UDEmailTextBox.Text.Trim());
                command.Parameters.AddWithValue("@ProfessorID", professorID);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Professor updated successfully!");
                    LoadProfessors();
                    ClearUpdateFields();
                }
                else
                {
                    MessageBox.Show("Failed to update professor.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating professor: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private int GetProfessorIDFromTagOrHiddenLabel()
        {
            if (this.Controls.Find("UDProfessorIDHiddenLabel", true).Length > 0)
            {
                Label idLabel = (Label)this.Controls.Find("UDProfessorIDHiddenLabel", true)[0];
                return Convert.ToInt32(idLabel.Text);
            }
            else if (this.Tag != null)
            {
                return Convert.ToInt32(this.Tag);
            }
            throw new Exception("Could not find professor ID.");
        }

        private void DeleteProfessorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UDProfessorLNameTextBox.Text) && string.IsNullOrWhiteSpace(UDProfessorFNameTextBox.Text))
                {
                    MessageBox.Show("Please search for a professor by first or last name before deleting.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete professor(s) matching this name?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No) return;

                connection.Open();
                string query = "DELETE FROM professors WHERE ";
                List<string> conditions = new List<string>();
                List<MySqlParameter> parameters = new List<MySqlParameter>();

                if (!string.IsNullOrWhiteSpace(UDProfessorFNameTextBox.Text))
                {
                    conditions.Add("FirstName LIKE @FirstName");
                    parameters.Add(new MySqlParameter("@FirstName", "%" + UDProfessorFNameTextBox.Text.Trim() + "%"));
                }

                if (!string.IsNullOrWhiteSpace(UDProfessorLNameTextBox.Text))
                {
                    conditions.Add("LastName LIKE @LastName");
                    parameters.Add(new MySqlParameter("@LastName", "%" + UDProfessorLNameTextBox.Text.Trim() + "%"));
                }

                if (conditions.Count == 0)
                {
                    MessageBox.Show("No valid name input provided for deletion.");
                    return;
                }

                query += string.Join(" AND ", conditions);
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddRange(parameters.ToArray());

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"{rowsAffected} professor(s) deleted successfully!");
                    LoadProfessors(); // Refresh list
                    ClearUpdateFields();
                }
                else
                {
                    MessageBox.Show("No professor found matching the given name.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting professor: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void ClearUpdateFields()
        {
            UDProfessorFNameTextBox.Clear();
            UDProfessorLNameTextBox.Clear();
            UDEmailTextBox.Clear();
            if (this.Controls.Find("UDProfessorIDHiddenLabel", true).Length > 0)
            {
                Label idLabel = (Label)this.Controls.Find("UDProfessorIDHiddenLabel", true)[0];
                idLabel.Text = "";
            }
            this.Tag = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void addStudentTabPage_Click(object sender, EventArgs e) { }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void expandPictureBox_Click(object sender, EventArgs e)
        {
            logoutButton.Visible = !logoutButton.Visible;
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
    }
}