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
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void markAttendanceTabPage_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void studentIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
