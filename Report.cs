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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Show();
        }
    }
}
