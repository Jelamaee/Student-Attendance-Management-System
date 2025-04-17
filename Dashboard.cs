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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void dashboardTitle_Click(object sender, EventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {

        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            Attendance attendance = new Attendance();
            attendance.Show();
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Show();
        }

        private void ClassButton_Click(object sender, EventArgs e)
        {
            Cclasses cclasses = new Cclasses();
            cclasses.Show();
        }

        private void ProfessorButton_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Show();
        }

        private void DepartmentButton_Click(object sender, EventArgs e)
        {
            Department department = new Department();
            department.Show();
        }

        private void ReportButton_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.Show();
        }

        private void userControlDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void expandPictureBox_Click(object sender, EventArgs e)
        {
            
        }
    }
}
