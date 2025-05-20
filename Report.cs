using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;

namespace Student_Attendance_Management_System
{
    public partial class Report : Form
    {

        private string connectionString = "server=localhost;database=student_attendance_system;user=root;password=jelamae;";
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ExportToExcel()
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    Excel.Application excelApp = new Excel.Application();
                    excelApp.Workbooks.Add(Type.Missing);

                    // ... rest of your code ...

                }
                else
                {
                    MessageBox.Show("No data available to export.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

    }
}
