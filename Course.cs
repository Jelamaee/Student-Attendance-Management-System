using MySql.Data.MySqlClient;
using System;
using System.Buffers;
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
    public partial class Course : Form
    {
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection; // Declare the connection
        private DataTable originalCourseData;

        public Course()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            this.Load += Course_Load;

            // Manually attach TextChanged event
            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }

        private void Course_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
        private void LoadCourses()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();

                string query = "SELECT * FROM courses";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                originalCourseData = new DataTable();
                adapter.Fill(originalCourseData);

                SearchdataGridView.DataSource = originalCourseData;
                UpdateTotalCourseOutputLabel();
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
        private void UpdateTotalCourseOutputLabel()
        {
            if (SearchdataGridView.DataSource is DataView dv)
            {
                TotalCourseOutputLabel.Text = " " + dv.Count.ToString();
            }
            else if (SearchdataGridView.DataSource is DataTable dt)
            {
                TotalCourseOutputLabel.Text = " " + dt.Rows.Count.ToString();
            }
        }

        private void dashboardButton_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide(); // Hide current form
        }

        private void studentButton_Click_1(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
            this.Hide(); // Hide current form
        }

        private void attendanceButton_Click_1(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
            this.Hide(); // Hide current form
        }

        private void courseButton_Click_1(object sender, EventArgs e)
        {
            // Since we're already on the Course form, just refresh the data
            LoadCourses();
            // Don't create a new instance of Course form
        }

        private void classButton_Click_1(object sender, EventArgs e)
        {
            Cclasses classClasses = new Cclasses();
            classClasses.Show();
            this.Hide(); // Hide current form
        }

        private void professorButton_Click_1(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
            this.Hide(); // Hide current form
        }

        private void departmentButton_Click_1(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide(); // Hide current form
        }

        private void ReportsButton_Click_1(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide(); // Hide current form
        }

        // Update the search text box method to filter data in real-time
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchdataGridView.DataSource != null && SearchdataGridView.DataSource is DataTable dataTable)
            {
                try
                {
                    string searchValue = searchTextBox.Text.Trim();
                    if (string.IsNullOrEmpty(searchValue))
                    {
                        // If search box is empty, show all records
                        LoadCourses();
                    }
                    else
                    {
                        // Filter using DataView
                        DataView dv = dataTable.DefaultView;
                        dv.RowFilter = $"course_id LIKE '%{searchValue}%' OR courseCode LIKE '%{searchValue}%' OR CourseName LIKE '%{searchValue}%'";
                        SearchdataGridView.DataSource = dv.ToTable();
                    }
                }
                catch (Exception ex)
                {
                    // Silently handle any filtering errors
                    // You could add logging here
                }
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(courseCodeTextBox.Text) ||
                    string.IsNullOrWhiteSpace(courseNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(creditHoursTextBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                connection.Open();
                string query = "INSERT INTO courses (CourseCode, CourseName, CreditHours) VALUES (@CourseCode, @CourseName, @CreditHours)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@CourseCode", courseCodeTextBox.Text.Trim());
                command.Parameters.AddWithValue("@CourseName", courseNameTextBox.Text.Trim());
                command.Parameters.AddWithValue("@CreditHours", creditHoursTextBox.Text.Trim());

                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Course added successfully!");
                    ClearAddCoursesFields();
                    LoadCourses();
                }
                else
                {
                    MessageBox.Show("Failed to add course.");
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("A course with this email already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving course: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void ClearAddCoursesFields()
        {
            courseCodeTextBox.Clear();
            courseNameTextBox.Clear();
            creditHoursTextBox.Clear();
        }
        // Method to clear update form fields
        private void ClearUpdateFields()
        {
            // Clear all the fields in the Update/Delete tab
            foreach (Control c in Controls.Find("updateDeleteTabPage", true)[0].Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Additional functionality if needed
        }

        private void studentIDTextBox_TextChanged(object sender, EventArgs e)
        {
            // Additional functionality if needed
        }

        private void UpdateCourseButton_Click(object sender, EventArgs e)
        {
          
        }

        private void DeleteCourseButton_Click_1(object sender, EventArgs e)
        {
            
        }


        private void searchPictureBox_Click_1(object sender, EventArgs e)
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
                string query = "SELECT * FROM courses WHERE CourseCode LIKE @SearchTerm OR CourseName LIKE @SearchTerm";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    DataTable tempTable = new DataTable();
                    tempTable.Load(reader);
                    SearchdataGridView.DataSource = tempTable;
                    UpdateTotalCourseOutputLabel();
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

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (originalCourseData == null)
                return;

            try
            {
                string searchValue = searchTextBox.Text.Trim();

                DataView dv = new DataView(originalCourseData);

                if (!string.IsNullOrEmpty(searchValue))
                {
                    // Convert searchValue to uppercase for case-insensitive comparison
                    searchValue = searchValue.ToUpper();

                    // Filter conditions
                    List<string> filters = new List<string>();

                    // Check if ProfessorID is numeric
                    if (int.TryParse(searchValue, out int courseId))
                    {
                        // Add ProfessorID filter if searchValue is numeric
                        filters.Add($"course_id = {courseId}");
                    }

                    // Add FirstName and LastName filters
                    filters.Add($"CourseCode LIKE '%{searchValue}%'");
                    filters.Add($"CourseName LIKE '%{searchValue}%'");

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
                SearchdataGridView.DataSource = dv;
                UpdateTotalCourseOutputLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message);
            }
        }
    }
}