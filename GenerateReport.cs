using System;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel; 

namespace Student_Attendance_Management_System
{
    public partial class GenerateReport : Form
    {
        private string _professorId; // Holds the logged-in professor's ID
        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";

        // Default constructor - used by designer or Admin
        public GenerateReport() : this(null)
        {
        }

        // Constructor for professors, receives ProfessorID
        public GenerateReport(string professorId)
        {
            InitializeComponent();
            _professorId = professorId;
            LoadCourses();  // Load courses taught by the professor
            LoadStudents(); // Load students under professor
        }

        #region Load Courses into ComboBox
        private void LoadCourses()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Fetch courses taught by the current professor
                        query = @"
                            SELECT c.course_id, c.CourseName, c.CourseCode 
                            FROM classes cl
                            JOIN courses c ON cl.course_id = c.course_id
                            WHERE cl.ProfessorID = @professorId";
                    }
                    else
                    {
                        // Admin view: show all courses
                        query = "SELECT course_id, CourseName, CourseCode FROM courses";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            CourseComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                int courseId = Convert.ToInt32(reader["course_id"]);
                                string courseName = reader["CourseName"].ToString();
                                string courseCode = reader["CourseCode"].ToString();

                                CourseComboBox.Items.Add(new CourseItem
                                {
                                    CourseId = courseId,
                                    CourseName = courseName,
                                    CourseCode = courseCode
                                });
                            }

                            if (CourseComboBox.Items.Count > 0)
                            {
                                CourseComboBox.SelectedIndex = 0;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load Students into StudentIDComboBox
        private void LoadStudents()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Only get students enrolled in courses taught by this professor
                        query = @"
                            SELECT DISTINCT s.student_id, s.FirstName, s.LastName
                            FROM students s
                            JOIN classes cl ON s.student_id = cl.student_id
                            WHERE cl.ProfessorID = @professorId
                            ORDER BY s.LastName";
                    }
                    else
                    {
                        // Admin: get all students
                        query = "SELECT student_id, FirstName, LastName FROM students ORDER BY LastName";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            StudentIDComboBox.Items.Clear();
                            while (reader.Read())
                            {
                                string studentId = reader["student_id"].ToString();
                                string fullName = $"{reader["FirstName"]} {reader["LastName"]}";

                                StudentIDComboBox.Items.Add(new StudentItem
                                {
                                    StudentID = studentId,
                                    FullName = fullName
                                });
                            }

                            // Start with no selection
                            StudentIDComboBox.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading students: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Load Attendance for Selected Student
        private void LoadAttendanceForStudent(string studentId)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query;
                    if (!string.IsNullOrEmpty(_professorId))
                    {
                        // Get attendance only for students under this professor
                        query = @"
                            SELECT a.attendance_id, a.student_id, c.CourseCode, a.attendance_date, a.status
                            FROM attendances a
                            JOIN students s ON a.student_id = s.student_id
                            JOIN courses c ON a.course_id = c.course_id
                            JOIN classes cl ON s.student_id = cl.student_id AND c.course_id = cl.course_id
                            WHERE cl.ProfessorID = @professorId AND a.student_id = @studentId
                            ORDER BY a.attendance_date DESC";
                    }
                    else
                    {
                        // Admin view: show all attendance for this student
                        query = @"
                            SELECT a.attendance_id, a.student_id, c.CourseCode, a.attendance_date, a.status
                            FROM attendances a
                            JOIN courses c ON a.course_id = c.course_id
                            WHERE a.student_id = @studentId
                            ORDER BY a.attendance_date DESC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@studentId", studentId);

                        if (!string.IsNullOrEmpty(_professorId))
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;
                            RenameDataGridViewColumns();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data for student: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Rename Columns in DataGridView
        private void RenameDataGridViewColumns()
        {
            if (dataGridView1.Columns.Contains("attendance_id"))
                dataGridView1.Columns["attendance_id"].HeaderText = "Attendance ID";
            if (dataGridView1.Columns.Contains("student_id"))
                dataGridView1.Columns["student_id"].HeaderText = "Student ID";
            if (dataGridView1.Columns.Contains("CourseCode"))
                dataGridView1.Columns["CourseCode"].HeaderText = "Course Code";
            if (dataGridView1.Columns.Contains("attendance_date"))
                dataGridView1.Columns["attendance_date"].HeaderText = "Date";
            if (dataGridView1.Columns.Contains("status"))
                dataGridView1.Columns["status"].HeaderText = "Status";
        }
        #endregion

        #region Event Handlers
        private void CourseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CourseComboBox.SelectedItem is CourseItem selectedItem)
            {
                LoadAttendanceData(selectedItem.CourseId);
            }
        }

        private void StudentIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentIDComboBox.SelectedItem is StudentItem selectedItem)
            {
                LoadAttendanceForStudent(selectedItem.StudentID);
            }
            else
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
            }
        }

        private void ClassReportTabPage_Click(object sender, EventArgs e)
        {
            LoadStudents(); // Ensure students are loaded when switching to this tab
        }

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (_professorId != null)
            {
                GenerateReport generateReport = new GenerateReport(_professorId);
                generateReport.Show();
            }
            else
            {
                GenerateReport generateReport = new GenerateReport();
                generateReport.Show();
            }
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            MarkAttendance markAttendance = new MarkAttendance(_professorId);
            markAttendance.Show();
        }
        #endregion

        #region Helper Classes for ComboBox Items
        public class CourseItem
        {
            public int CourseId { get; set; }
            public string CourseName { get; set; }
            public string CourseCode { get; set; }

            public override string ToString()
            {
                return $"{CourseCode} - {CourseName}";
            }
        }

        public class StudentItem
        {
            public string StudentID { get; set; }
            public string FullName { get; set; }

            public override string ToString()
            {
                return $"{StudentID} - {FullName}";
            }
        }
        #endregion

        #region Optional: Add This Method If Needed

        private void LoadAttendanceData(int selectedCourseId = -1)
        {
            try
            {
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (!string.IsNullOrEmpty(_professorId) && selectedCourseId != -1)
                    {
                        // Filter by professor and selected course
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    JOIN classes cl ON s.student_id = cl.student_id AND c.course_id = cl.course_id
                    WHERE cl.ProfessorID = @professorId AND a.course_id = @courseId
                    ORDER BY a.attendance_date DESC";
                    }
                    else if (selectedCourseId != -1)
                    {
                        // Admin view: filter by selected course
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    WHERE a.course_id = @courseId
                    ORDER BY a.attendance_date DESC";
                    }
                    else
                    {
                        // Admin view: show all attendance
                        query = @"
                    SELECT a.attendance_id, s.student_id, s.FirstName, s.LastName, c.CourseCode, a.attendance_date, a.status
                    FROM attendances a
                    JOIN students s ON a.student_id = s.student_id
                    JOIN courses c ON a.course_id = c.course_id
                    ORDER BY a.attendance_date DESC";
                    }

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(_professorId) && selectedCourseId != -1)
                        {
                            cmd.Parameters.AddWithValue("@professorId", _professorId);
                            cmd.Parameters.AddWithValue("@courseId", selectedCourseId);
                        }
                        else if (selectedCourseId != -1)
                        {
                            cmd.Parameters.AddWithValue("@courseId", selectedCourseId);
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            dataGridView1.DataSource = table;

                            // Rename headers
                            if (dataGridView1.Columns.Contains("attendance_id"))
                                dataGridView1.Columns["attendance_id"].HeaderText = "Attendance ID";
                            if (dataGridView1.Columns.Contains("student_id"))
                                dataGridView1.Columns["student_id"].HeaderText = "Student ID";
                            if (dataGridView1.Columns.Contains("FirstName"))
                                dataGridView1.Columns["FirstName"].HeaderText = "First Name";
                            if (dataGridView1.Columns.Contains("LastName"))
                                dataGridView1.Columns["LastName"].HeaderText = "Last Name";
                            if (dataGridView1.Columns.Contains("CourseCode"))
                                dataGridView1.Columns["CourseCode"].HeaderText = "Course Code";
                            if (dataGridView1.Columns.Contains("attendance_date"))
                                dataGridView1.Columns["attendance_date"].HeaderText = "Date";
                            if (dataGridView1.Columns.Contains("status"))
                                dataGridView1.Columns["status"].HeaderText = "Status";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No data to export.", "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save Attendance Report";
                saveFileDialog.FileName = "AttendanceReport.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Attendance Report");

                    // Export column headers
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                    }

                    // Export row data
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            var cellValue = dataGridView1.Rows[i].Cells[j].Value;
                            worksheet.Cell(i + 2, j + 1).Value = cellValue?.ToString() ?? "";
                        }
                    }

                    // Auto-fit columns
                    worksheet.Columns().AdjustToContents();

                    // Save the workbook
                    string filePath = saveFileDialog.FileName;
                    workbook.SaveAs(filePath);

                    MessageBox.Show("Attendance report successfully exported to Excel!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open the file using the default application
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = filePath,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening the Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClassReportTabPage_Click_1(object sender, EventArgs e)
        {
            // Handle tab page click here
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events here if needed
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell click events here if needed
        }
    }
}