using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Professor : Form
    {
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection;
        private DataTable originalProfessorData;

        public Professor()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            this.Load += Professor_Load;

            // Manually attach TextChanged event
            searchTextBox.TextChanged += searchTextBox_TextChanged;
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
        // ✅ This method is defined here, as its own separate method
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

        // Navigation buttons
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

        // Add Professor
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

                connection.Open();
                string query = "INSERT INTO professors (LastName, FirstName, Email) VALUES (@LastName, @FirstName, @Email)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@LastName", ProfessorLNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@FirstName", ProfessorFNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@Email", EmailTextBox.Text.Trim());

                int rowsAffected = command.ExecuteNonQuery();
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
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("A professor with this email already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving professor: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
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
                    // Convert searchValue to uppercase for case-insensitive comparison
                    searchValue = searchValue.ToUpper();

                    // Filter conditions
                    List<string> filters = new List<string>();

                    // Check if ProfessorID is numeric
                    if (int.TryParse(searchValue, out int professorId))
                    {
                        // Add ProfessorID filter if searchValue is numeric
                        filters.Add($"ProfessorID = {professorId}");
                    }

                    // Add FirstName and LastName filters
                    filters.Add($"FirstName LIKE '%{searchValue}%'");
                    filters.Add($"LastName LIKE '%{searchValue}%'");

                    // Combine all filters with OR
                    string combinedFilter = string.Join(" OR ", filters);
                    dv.RowFilter = combinedFilter;
                }
                else
                {
                    // Show all records if search box is empty
                    dv.RowFilter = "";
                }

                // Bind filtered data to DataGridView
                SearchProfessorDataGridView.DataSource = dv;
                UpdateTotalProfOutputCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }

        // Manual Search Button (optional)
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

        // Update Professor
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

        // Delete Professor
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

                // Build DELETE query based on First Name and/or Last Name
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

        // Optional placeholder event handlers
        private void button3_Click(object sender, EventArgs e) { }
        private void addStudentTabPage_Click(object sender, EventArgs e) { }
    }
}