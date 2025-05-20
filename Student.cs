using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Student_Attendance_Management_System
{
    public partial class Student : Form
    {
        string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
        MySqlConnection connection;

        public Student()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            this.Load += (s, e) => LoadStudents();

            // Event subscriptions
            SearchdataGridView.CellClick += SearchdataGridView_CellClick;

            // Gender RadioButton events
            maleRadioButton.CheckedChanged += GenderRadioButton_CheckedChanged;
            femaleRadioButton.CheckedChanged += GenderRadioButton_CheckedChanged;
        }

        private void GenderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // No need for logic here unless you want to react to changes immediately
        }

        private void LoadStudents()
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                    connection.Open();
                string query = "SELECT * FROM students";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                SearchdataGridView.DataSource = table;
                UpdateStudentCountLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void UpdateStudentCountLabel()
        {
            if (SearchdataGridView.DataSource is DataTable dt)
                totalStudOutputLabel.Text = dt.Rows.Count.ToString();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            new Dashboard().Show();
            this.Hide();
        }

        private void studentButton_Click(object sender, EventArgs e) => LoadStudents();

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            new Attendance().Show();
            this.Hide();
        }

        private void courseButton_Click(object sender, EventArgs e)
        {
            new Course().Show();
            this.Hide();
        }

        private void classButton_Click(object sender, EventArgs e)
        {
            new Cclasses().Show();
            this.Hide();
        }

        private void professorButton_Click(object sender, EventArgs e)
        {
            new Professor().Show();
            this.Hide();
        }

        private void departmentButton_Click(object sender, EventArgs e)
        {
            new Department().Show();
            this.Hide();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchdataGridView.DataSource != null && SearchdataGridView.DataSource is DataTable dataTable)
            {
                try
                {
                    string searchValue = searchTextBox.Text.Trim();
                    if (string.IsNullOrEmpty(searchValue))
                    {
                        LoadStudents();
                    }
                    else
                    {
                        DataView dv = dataTable.DefaultView;
                        dv.RowFilter = $"student_id LIKE '%{searchValue}%' OR FirstName LIKE '%{searchValue}%' OR LastName LIKE '%{searchValue}%'";
                        SearchdataGridView.DataSource = dv.ToTable();
                    }
                }
                catch (Exception ex)
                {
                    // Handle filtering errors silently
                }
            }
        }

        private void searchPictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = searchTextBox.Text.Trim();
                if (string.IsNullOrWhiteSpace(searchValue))
                {
                    MessageBox.Show("Please enter a student ID to search.");
                    return;
                }
                connection.Open();
                string query = "SELECT * FROM students WHERE student_id = @student_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@student_id", searchValue);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UDStudentIDtextBox.Text = reader["student_id"].ToString();
                        UDStudentFNametextBox.Text = reader["FirstName"].ToString();
                        UDStudentLNametextBox.Text = reader["LastName"].ToString();
                        UDProgramYeartextBox.Text = reader["ProgramAndYear"].ToString();
                        UDdobdateTimePicker.Value = Convert.ToDateTime(reader["DateOfBirth"]);
                        UDStudentEmailtextBox.Text = reader["Email"].ToString();
                        string gender = reader["Gender"].ToString();
                        maleRadioButton.Checked = gender == "Male";
                        femaleRadioButton.Checked = gender == "Female";
                        MessageBox.Show("Student found!");
                    }
                    else
                    {
                        MessageBox.Show("No student found with the given ID.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching student: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(studentIDTextBox.Text) ||
                    string.IsNullOrWhiteSpace(studentFNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(studentLNameTextBox.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }
                string gender = maleRadioButton.Checked ? "Male" : (femaleRadioButton.Checked ? "Female" : "");
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }
                connection.Open();
                string query = @"INSERT INTO students 
                                (student_id, FirstName, LastName, ProgramAndYear, DateOfBirth, Gender, Email) 
                                VALUES (@id, @fname, @lname, @prog, @dob, @gender, @email)";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", studentIDTextBox.Text);
                cmd.Parameters.AddWithValue("@fname", studentFNameTextBox.Text);
                cmd.Parameters.AddWithValue("@lname", studentLNameTextBox.Text);
                cmd.Parameters.AddWithValue("@prog", programAndYearTextBox.Text);
                cmd.Parameters.AddWithValue("@dob", StudentdobdateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@email", studentEmailTextBox.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student added successfully.");
                    ClearAddStudentFields();
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Failed to add student.");
                }
            }
            catch (MySqlException ex) when (ex.Number == 1062)
            {
                MessageBox.Show("A student with this ID already exists.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding student: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UDStudentIDtextBox.Text))
                {
                    MessageBox.Show("Please select a student to update.");
                    return;
                }

                // Evaluate gender just before executing the query
                string gender = maleRadioButton.Checked ? "Male" : (femaleRadioButton.Checked ? "Female" : "");
                if (string.IsNullOrEmpty(gender))
                {
                    MessageBox.Show("Please select a gender.");
                    return;
                }

                connection.Open();
                string query = @"UPDATE students SET 
                                 FirstName=@fname, LastName=@lname, ProgramAndYear=@prog, 
                                 DateOfBirth=@dob, Email=@email, Gender=@gender 
                                 WHERE student_id=@id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@fname", UDStudentFNametextBox.Text);
                cmd.Parameters.AddWithValue("@lname", UDStudentLNametextBox.Text);
                cmd.Parameters.AddWithValue("@prog", UDProgramYeartextBox.Text);
                cmd.Parameters.AddWithValue("@dob", UDdobdateTimePicker.Value.Date);
                cmd.Parameters.AddWithValue("@email", UDStudentEmailtextBox.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@id", UDStudentIDtextBox.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student updated successfully.");
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Failed to update student.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating student: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void deleteStudentbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UDStudentIDtextBox.Text))
                {
                    MessageBox.Show("Please select a student to delete.");
                    return;
                }
                var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Delete",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No) return;
                connection.Open();
                string query = "DELETE FROM students WHERE student_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", UDStudentIDtextBox.Text);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student deleted successfully.");
                    ClearUpdateFields();
                    LoadStudents();
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting student: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }

        private void ClearAddStudentFields()
        {
            studentIDTextBox.Clear();
            studentFNameTextBox.Clear();
            studentLNameTextBox.Clear();
            programAndYearTextBox.Clear();
            StudentdobdateTimePicker.Value = DateTime.Now;
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
            studentEmailTextBox.Clear();
        }

        private void ClearUpdateFields()
        {
            UDStudentIDtextBox.Clear();
            UDStudentFNametextBox.Clear();
            UDStudentLNametextBox.Clear();
            UDProgramYeartextBox.Clear();
            UDdobdateTimePicker.Value = DateTime.Now;
            UDStudentEmailtextBox.Clear();
            maleRadioButton.Checked = false;
            femaleRadioButton.Checked = false;
        }

        private void SearchdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    var row = SearchdataGridView.Rows[e.RowIndex];
                    UDStudentIDtextBox.Text = row.Cells["student_id"].Value.ToString();
                    UDStudentFNametextBox.Text = row.Cells["FirstName"].Value.ToString();
                    UDStudentLNametextBox.Text = row.Cells["LastName"].Value.ToString();
                    UDProgramYeartextBox.Text = row.Cells["ProgramAndYear"].Value.ToString();
                    UDStudentEmailtextBox.Text = row.Cells["Email"].Value.ToString();
                    if (DateTime.TryParse(row.Cells["DateOfBirth"].Value?.ToString(), out DateTime dob))
                        UDdobdateTimePicker.Value = dob;
                    string gender = row.Cells["Gender"].Value?.ToString() ?? "";
                    maleRadioButton.Checked = gender == "Male";
                    femaleRadioButton.Checked = gender == "Female";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading student data: " + ex.Message);
                }
            }
        }

        // ————————
        // DESIGNER STUBS (do not remove)
        // These are empty but must be present for designer compatibility
        // ————————

        private void button1_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void studentIDLabel_Click(object sender, EventArgs e) { }
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void maleRadioButton_CheckedChanged(object sender, EventArgs e) { }
        private void studentEmailTextBox_TextChanged(object sender, EventArgs e) { }
        private void totalStudentsLabel_Click(object sender, EventArgs e) { }
        private void toolTip1_Popup(object sender, PopupEventArgs e) { }
        private void studentIDTextBox_TextChanged(object sender, EventArgs e) { }
        private void programAndYearTextBox_TextChanged(object sender, EventArgs e) { }
        private void studentLNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void studentFNameTextBox_TextChanged(object sender, EventArgs e) { }
        private void dobTextBox_TextChanged(object sender, EventArgs e) { }
        private void femaleRadioButton_CheckedChanged(object sender, EventArgs e) { }
        private void genderLabel_Click(object sender, EventArgs e) { }
        private void Student_Load(object sender, EventArgs e) { }
        private void dashboardSmallpanel_Paint(object sender, PaintEventArgs e) { }
        private void totalStudOutputLabel_Click(object sender, EventArgs e) { }
    }
}