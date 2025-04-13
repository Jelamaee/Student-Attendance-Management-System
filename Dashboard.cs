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

        private void dashboardButton_Click(object sender, EventArgs e)
        {

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

        }

        private void professorButton_Click(object sender, EventArgs e)
        {

        }

        private void departmentButton_Click(object sender, EventArgs e)
        {

        }

        private void archiveButton_Click(object sender, EventArgs e)
        {

        }
    }
}
