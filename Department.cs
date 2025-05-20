using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Department : Form
    {
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection; // Declare the connection  
        private DataTable originalDepartmentData;
        public Department()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            this.Load += Department_Load;

            // Manually attach TextChanged event
            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }
        private void Department_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }
        private void LoadDepartments()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT * FROM departments";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                originalDepartmentData = new DataTable();
                adapter.Fill(originalDepartmentData);

                    SearchDataGridView.DataSource = originalDepartmentData;
                    UpdateTotalDeptNameOutputLabel();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading departments: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        // ✅ This method is defined here, as its own separate method
        private void  UpdateTotalDeptNameOutputLabel()
        {
            if (SearchDataGridView.DataSource is DataView dv)
            {
                TotalDeptNameOutputLabel.Text = " " + dv.Count.ToString();
            }
            else if (SearchDataGridView.DataSource is DataTable dt)
            {
                TotalDeptNameOutputLabel.Text = " " + dt.Rows.Count.ToString();
            }
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
            Cclasses classClasses = new Cclasses();
            classClasses.Show();
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addStudentTabPage_Click(object sender, EventArgs e)
        {
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(DeptNameTextBox.Text) ||
                   string.IsNullOrWhiteSpace(DeptHeadTextBox.Text))
                {

                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                connection.Open();
                string query = "INSERT INTO departments (DepartmentName, DepartmentHead ) VALUES (@DepartmentName, @DepartmentHead)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@DepartmentName", DeptNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@DepartmentHead", DeptHeadTextBox.Text.Trim());

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Professor added successfully!");
                    ClearAddDepartmentsFields();
                    LoadDepartments();
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

        private void ClearAddDepartmentsFields()
        {
            DeptNameTextBox.Clear();
            DeptHeadTextBox.Clear();
        }

        private void Departmentlabel_Click(object sender, EventArgs e)
        {

        }

        private void studentIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void UDdeptNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeptNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (originalDepartmentData == null)
                return;

            try
            {
                string searchValue = searchTextBox.Text.Trim();

                DataView dv = new DataView(originalDepartmentData);

                if (!string.IsNullOrEmpty(searchValue))
                {
                    // Convert searchValue to uppercase for case-insensitive comparison
                    searchValue = searchValue.ToUpper();

                    // Filter conditions
                    List<string> filters = new List<string>();

                    // Check if ProfessorID is numeric
                    if (int.TryParse(searchValue, out int departmentId))
                    {
                        // Add ProfessorID filter if searchValue is numeric
                        filters.Add($"department_id = {departmentId}");
                    }

                    // Add FirstName and LastName filters
                    filters.Add($"DepartmentName LIKE '%{searchValue}%'");
                    filters.Add($"DepartmentHead LIKE '%{searchValue}%'");

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
                SearchDataGridView.DataSource = dv;
                UpdateTotalDeptNameOutputLabel();
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
                string query = "SELECT * FROM departments WHERE DepartmentName LIKE @SearchTerm OR DepartmentHead LIKE @SearchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable tempTable = new DataTable();
                    tempTable.Load(reader);
                    SearchDataGridView.DataSource = tempTable;
                    UpdateTotalDeptNameOutputLabel();
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

        private void UpdateDepartmentButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteDepartmentButton_Click(object sender, EventArgs e)
        {

        }

        private void DeptHeadTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}