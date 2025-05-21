using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Cclasses : Form
    {
        private Login loginForm; // Reference to the Login form
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection;

        public Cclasses()
        {
            InitializeComponent();
            loginForm = new Login(); // Initialize once
            logoutButton.Visible = false; // Hide logout button initially
            connection = new MySqlConnection(connectionString);

            // Wire up dropdown refresh event
            StudentIDComboBox.DropDown += StudentIDComboBox_DropDown;
            CourseIDComboBox.DropDown += (s, e) => LoadCourseIDs(); // Refresh course list on dropdown

            // Load data into ComboBoxes
            LoadCourseIDs();
            LoadProfessorIDs();
            LoadClassDays();
            LoadStudentIDs();

            // Load existing classes into DataGridView
            LoadCclasses();
        }

        private void LoadCclasses()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM classes";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                ViewClassDataGridView.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading classes: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadCourseIDs()
        {
            try
            {
                connection.Open();
                string query = "SELECT course_id, CourseCode FROM courses"; // Note: Column name is CourseCode
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Add display column: course_id + " - " + CourseCode
                dt.Columns.Add("display", typeof(string), "course_id + ' - ' + CourseCode");

                CourseIDComboBox.DataSource = dt;
                CourseIDComboBox.DisplayMember = "display";
                CourseIDComboBox.ValueMember = "course_id";

                CourseIDComboBox.SelectedIndex = -1; // Show blank initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading course IDs: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadProfessorIDs()
        {
            try
            {
                connection.Open();
                string query = "SELECT ProfessorID, LastName, FirstName FROM professors";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Add display column: ProfessorID - LastName FirstName
                dt.Columns.Add("display", typeof(string), "ProfessorID + ' - ' + LastName + ' ' + FirstName");

                ProfessorIDComboBox.DataSource = dt;
                ProfessorIDComboBox.DisplayMember = "display";
                ProfessorIDComboBox.ValueMember = "ProfessorID";

                ProfessorIDComboBox.SelectedIndex = -1; // Show blank initially
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading professor IDs: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadClassDays()
        {
            ClassDaysComboBox.Items.Clear();
            ClassDaysComboBox.Items.AddRange(new object[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            });
            ClassDaysComboBox.SelectedIndex = -1; // Show blank initially
        }

        private void LoadStudentIDs()
        {
            try
            {
                connection.Open();
                string query = "SELECT student_id, LastName, FirstName FROM Students";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Add display column: student_id - LastName FirstName
                dt.Columns.Add("display", typeof(string), "student_id + ' - ' + LastName + ' ' + FirstName");

                StudentIDComboBox.DataSource = dt;
                StudentIDComboBox.DisplayMember = "display";
                StudentIDComboBox.ValueMember = "student_id";

                StudentIDComboBox.SelectedIndex = -1; // Blank by default
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

        private void StudentIDComboBox_DropDown(object sender, EventArgs e)
        {
            LoadStudentIDs(); // Refresh student list every time the dropdown is opened
        }

        private void AddClassButton_Click(object sender, EventArgs e)
        {
            if (CourseIDComboBox.SelectedIndex == -1 ||
                ProfessorIDComboBox.SelectedIndex == -1 ||
                ClassDaysComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select course ID, professor ID, and class day.");
                return;
            }

            var selectedCourseRow = CourseIDComboBox.SelectedItem as DataRowView;
            var selectedProfessorRow = ProfessorIDComboBox.SelectedItem as DataRowView;

            string courseID = selectedCourseRow?["course_id"]?.ToString();
            string professorID = selectedProfessorRow?["ProfessorID"]?.ToString();
            string studentID = StudentIDComboBox.SelectedValue?.ToString();

            DateTime startTime = StartTimeDateTimePicker.Value;
            DateTime endTime = EndTimeDateTimePicker.Value;
            string classDay = ClassDaysComboBox.SelectedItem.ToString();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO classes 
                            (student_id, course_id, ProfessorID, StartTime, EndTime, ClassDays) 
                        VALUES 
                            (@student_id, @course_id, @ProfessorID, @StartTime, @EndTime, @ClassDays)";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@student_id", studentID);
                    command.Parameters.AddWithValue("@course_id", courseID);
                    command.Parameters.AddWithValue("@ProfessorID", professorID);
                    command.Parameters.AddWithValue("@StartTime", startTime.TimeOfDay); // Store only Time part
                    command.Parameters.AddWithValue("@EndTime", endTime.TimeOfDay);     // Store only Time part
                    command.Parameters.AddWithValue("@ClassDays", classDay);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Class added successfully!");
                        LoadCclasses(); // Refresh grid
                    }
                    else
                    {
                        MessageBox.Show("Failed to add class.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving class: " + ex.Message);
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
            Cclasses cclasses = new Cclasses();
            cclasses.Show();
            this.Hide();
        }

        private void professorButton_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
            this.Hide();
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
            this.Hide();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
            this.Hide();
        }

        #endregion

        #region Unused Event Handlers (Optional)

        private void AddClassTabPage_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void CourseIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        private void ProfessorIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        private void ClassDaysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        private void StudentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Optional logic here later
        }

        #endregion

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            registerForm.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Show confirmation message
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
            // Toggle visibility of the logout button
            logoutButton.Visible = !logoutButton.Visible;
        }
    }
}