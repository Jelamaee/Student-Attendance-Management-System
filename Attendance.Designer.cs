namespace Student_Attendance_Management_System
{
    partial class Attendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance));
            dashboardPanel = new Panel();
            ReportButton = new Button();
            archivedButton = new Button();
            departmentButton = new Button();
            professorButton = new Button();
            CclassButton = new Button();
            courseButton = new Button();
            attendanceButton = new Button();
            studentButton = new Button();
            dashboardButton = new Button();
            dashboardSmallpanel = new Panel();
            dashboardTitle = new Label();
            dashboardPictureBox = new PictureBox();
            panelBack = new Panel();
            panel2 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            markAttendanceTabPage = new TabPage();
            SaveAttendanceButton = new Button();
            comboBox3 = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            userControlDashboard2 = new UserControlDashboard();
            comboBox2 = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            userControlDashboard1 = new UserControlDashboard();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            addStudentLabel = new Label();
            studentIDLabel = new Label();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            TabControl = new TabControl();
            viewAttendancetabPage = new TabPage();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            markAttendanceTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            viewAttendancetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(archivedButton);
            dashboardPanel.Controls.Add(departmentButton);
            dashboardPanel.Controls.Add(professorButton);
            dashboardPanel.Controls.Add(CclassButton);
            dashboardPanel.Controls.Add(courseButton);
            dashboardPanel.Controls.Add(attendanceButton);
            dashboardPanel.Controls.Add(studentButton);
            dashboardPanel.Controls.Add(dashboardButton);
            dashboardPanel.Controls.Add(dashboardSmallpanel);
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(330, 1033);
            dashboardPanel.TabIndex = 1;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.None;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 11F);
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(3, 582);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(220, 40);
            ReportButton.TabIndex = 9;
            ReportButton.Text = "                Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += button1_Click;
            // 
            // archivedButton
            // 
            archivedButton.Anchor = AnchorStyles.None;
            archivedButton.FlatAppearance.BorderSize = 0;
            archivedButton.FlatStyle = FlatStyle.Flat;
            archivedButton.Font = new Font("Century Gothic", 11F);
            archivedButton.Image = (Image)resources.GetObject("archivedButton.Image");
            archivedButton.ImageAlign = ContentAlignment.MiddleLeft;
            archivedButton.Location = new Point(65, 1058);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // departmentButton
            // 
            departmentButton.Anchor = AnchorStyles.None;
            departmentButton.FlatAppearance.BorderSize = 0;
            departmentButton.FlatStyle = FlatStyle.Flat;
            departmentButton.Font = new Font("Century Gothic", 11F);
            departmentButton.Image = (Image)resources.GetObject("departmentButton.Image");
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            departmentButton.Location = new Point(3, 524);
            departmentButton.Name = "departmentButton";
            departmentButton.Size = new Size(220, 40);
            departmentButton.TabIndex = 7;
            departmentButton.Text = "                Department";
            departmentButton.TextAlign = ContentAlignment.MiddleLeft;
            departmentButton.UseVisualStyleBackColor = true;
            departmentButton.Click += departmentButton_Click;
            // 
            // professorButton
            // 
            professorButton.Anchor = AnchorStyles.None;
            professorButton.FlatAppearance.BorderSize = 0;
            professorButton.FlatStyle = FlatStyle.Flat;
            professorButton.Font = new Font("Century Gothic", 11F);
            professorButton.Image = (Image)resources.GetObject("professorButton.Image");
            professorButton.ImageAlign = ContentAlignment.MiddleLeft;
            professorButton.Location = new Point(3, 474);
            professorButton.Name = "professorButton";
            professorButton.Size = new Size(220, 40);
            professorButton.TabIndex = 6;
            professorButton.Text = "                Professor";
            professorButton.TextAlign = ContentAlignment.MiddleLeft;
            professorButton.UseVisualStyleBackColor = true;
            professorButton.Click += professorButton_Click;
            // 
            // CclassButton
            // 
            CclassButton.Anchor = AnchorStyles.None;
            CclassButton.FlatAppearance.BorderSize = 0;
            CclassButton.FlatStyle = FlatStyle.Flat;
            CclassButton.Font = new Font("Century Gothic", 11F);
            CclassButton.Image = (Image)resources.GetObject("CclassButton.Image");
            CclassButton.ImageAlign = ContentAlignment.MiddleLeft;
            CclassButton.Location = new Point(3, 424);
            CclassButton.Name = "CclassButton";
            CclassButton.Size = new Size(220, 40);
            CclassButton.TabIndex = 5;
            CclassButton.Text = "                Class";
            CclassButton.TextAlign = ContentAlignment.MiddleLeft;
            CclassButton.UseVisualStyleBackColor = true;
            CclassButton.Click += classButton_Click;
            // 
            // courseButton
            // 
            courseButton.Anchor = AnchorStyles.None;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Century Gothic", 11F);
            courseButton.Image = (Image)resources.GetObject("courseButton.Image");
            courseButton.ImageAlign = ContentAlignment.MiddleLeft;
            courseButton.Location = new Point(3, 374);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(220, 40);
            courseButton.TabIndex = 4;
            courseButton.Text = "                Course";
            courseButton.TextAlign = ContentAlignment.MiddleLeft;
            courseButton.UseVisualStyleBackColor = true;
            courseButton.Click += courseButton_Click;
            // 
            // attendanceButton
            // 
            attendanceButton.Anchor = AnchorStyles.None;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.Font = new Font("Century Gothic", 11F);
            attendanceButton.Image = (Image)resources.GetObject("attendanceButton.Image");
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceButton.Location = new Point(3, 324);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(220, 40);
            attendanceButton.TabIndex = 3;
            attendanceButton.Text = "                Attendance";
            attendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            attendanceButton.UseVisualStyleBackColor = true;
            attendanceButton.Click += attendanceButton_Click;
            // 
            // studentButton
            // 
            studentButton.Anchor = AnchorStyles.None;
            studentButton.BackgroundImageLayout = ImageLayout.Zoom;
            studentButton.FlatAppearance.BorderSize = 0;
            studentButton.FlatStyle = FlatStyle.Flat;
            studentButton.Font = new Font("Century Gothic", 11F);
            studentButton.Image = (Image)resources.GetObject("studentButton.Image");
            studentButton.ImageAlign = ContentAlignment.MiddleLeft;
            studentButton.Location = new Point(3, 274);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(220, 40);
            studentButton.TabIndex = 2;
            studentButton.Text = "                Student";
            studentButton.TextAlign = ContentAlignment.MiddleLeft;
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += studentButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.Anchor = AnchorStyles.None;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Century Gothic", 11F);
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(3, 224);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(220, 40);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "                Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // dashboardSmallpanel
            // 
            dashboardSmallpanel.Anchor = AnchorStyles.None;
            dashboardSmallpanel.Controls.Add(dashboardTitle);
            dashboardSmallpanel.Controls.Add(dashboardPictureBox);
            dashboardSmallpanel.Location = new Point(0, 3);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(327, 215);
            dashboardSmallpanel.TabIndex = 0;
            // 
            // dashboardTitle
            // 
            dashboardTitle.Anchor = AnchorStyles.None;
            dashboardTitle.BackColor = Color.Transparent;
            dashboardTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.Location = new Point(22, 108);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(286, 67);
            dashboardTitle.TabIndex = 1;
            dashboardTitle.Text = "Student Attendance Management System";
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.None;
            dashboardPictureBox.Image = (Image)resources.GetObject("dashboardPictureBox.Image");
            dashboardPictureBox.Location = new Point(111, 27);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new Size(64, 64);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboardPictureBox.TabIndex = 0;
            dashboardPictureBox.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Control;
            panelBack.Controls.Add(panel2);
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Location = new Point(331, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1574, 218);
            panelBack.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(188, 234, 213);
            panel2.Location = new Point(0, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(1574, 126);
            panel2.TabIndex = 3;
            // 
            // expandPictureBox
            // 
            expandPictureBox.Cursor = Cursors.Hand;
            expandPictureBox.Image = (Image)resources.GetObject("expandPictureBox.Image");
            expandPictureBox.Location = new Point(1319, 70);
            expandPictureBox.Name = "expandPictureBox";
            expandPictureBox.Size = new Size(24, 24);
            expandPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            expandPictureBox.TabIndex = 2;
            expandPictureBox.TabStop = false;
            // 
            // logoutPictureBox
            // 
            logoutPictureBox.Image = (Image)resources.GetObject("logoutPictureBox.Image");
            logoutPictureBox.Location = new Point(1241, 0);
            logoutPictureBox.Name = "logoutPictureBox";
            logoutPictureBox.Size = new Size(81, 94);
            logoutPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            logoutPictureBox.TabIndex = 1;
            logoutPictureBox.TabStop = false;
            // 
            // markAttendanceTabPage
            // 
            markAttendanceTabPage.BackColor = SystemColors.Window;
            markAttendanceTabPage.Controls.Add(SaveAttendanceButton);
            markAttendanceTabPage.Controls.Add(comboBox3);
            markAttendanceTabPage.Controls.Add(label3);
            markAttendanceTabPage.Controls.Add(panel8);
            markAttendanceTabPage.Controls.Add(userControlDashboard2);
            markAttendanceTabPage.Controls.Add(comboBox2);
            markAttendanceTabPage.Controls.Add(label2);
            markAttendanceTabPage.Controls.Add(panel7);
            markAttendanceTabPage.Controls.Add(panel6);
            markAttendanceTabPage.Controls.Add(panel5);
            markAttendanceTabPage.Controls.Add(panel4);
            markAttendanceTabPage.Controls.Add(userControlDashboard1);
            markAttendanceTabPage.Controls.Add(comboBox1);
            markAttendanceTabPage.Controls.Add(label1);
            markAttendanceTabPage.Controls.Add(panel3);
            markAttendanceTabPage.Controls.Add(addStudentLabel);
            markAttendanceTabPage.Controls.Add(studentIDLabel);
            markAttendanceTabPage.Controls.Add(panel1);
            markAttendanceTabPage.Controls.Add(dateTimePicker1);
            markAttendanceTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markAttendanceTabPage.Location = new Point(4, 4);
            markAttendanceTabPage.Name = "markAttendanceTabPage";
            markAttendanceTabPage.Padding = new Padding(3);
            markAttendanceTabPage.Size = new Size(1568, 726);
            markAttendanceTabPage.TabIndex = 0;
            markAttendanceTabPage.Text = "Mark Attendance";
            markAttendanceTabPage.Click += markAttendanceTabPage_Click;
            // 
            // SaveAttendanceButton
            // 
            SaveAttendanceButton.BackColor = Color.FromArgb(142, 195, 176);
            SaveAttendanceButton.FlatAppearance.BorderSize = 0;
            SaveAttendanceButton.FlatStyle = FlatStyle.Flat;
            SaveAttendanceButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveAttendanceButton.Location = new Point(321, 472);
            SaveAttendanceButton.Name = "SaveAttendanceButton";
            SaveAttendanceButton.Size = new Size(150, 40);
            SaveAttendanceButton.TabIndex = 38;
            SaveAttendanceButton.Text = "Save";
            SaveAttendanceButton.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = SystemColors.Window;
            comboBox3.FlatStyle = FlatStyle.Flat;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(1004, 338);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(240, 29);
            comboBox3.TabIndex = 37;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1004, 306);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 35;
            label3.Text = "Status:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(1004, 369);
            panel8.Name = "panel8";
            panel8.Size = new Size(240, 2);
            panel8.TabIndex = 36;
            // 
            // userControlDashboard2
            // 
            userControlDashboard2.AutoSize = true;
            userControlDashboard2.Location = new Point(1268, 306);
            userControlDashboard2.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard2.Name = "userControlDashboard2";
            userControlDashboard2.Size = new Size(0, 586);
            userControlDashboard2.TabIndex = 34;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Window;
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1004, 128);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(240, 29);
            comboBox2.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1004, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 31;
            label2.Text = "Course:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(1004, 159);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 2);
            panel7.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(559, 344);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 27);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(312, 344);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 30);
            panel5.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(321, 369);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 2);
            panel4.TabIndex = 9;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.AutoSize = true;
            userControlDashboard1.Location = new Point(1268, 96);
            userControlDashboard1.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(0, 586);
            userControlDashboard1.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(317, 128);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(240, 29);
            comboBox1.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(317, 96);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 25;
            label1.Text = "Student ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(317, 159);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 2);
            panel3.TabIndex = 27;
            // 
            // addStudentLabel
            // 
            addStudentLabel.AutoSize = true;
            addStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            addStudentLabel.Location = new Point(6, 6);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(187, 23);
            addStudentLabel.TabIndex = 22;
            addStudentLabel.Text = "Mark Attendance:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(317, 306);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(57, 22);
            studentIDLabel.TabIndex = 5;
            studentIDLabel.Text = "Date:";
            studentIDLabel.Click += studentIDLabel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(317, 335);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 10);
            panel1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = SystemColors.Window;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Control;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(321, 341);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 30);
            dateTimePicker1.TabIndex = 23;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(markAttendanceTabPage);
            TabControl.Controls.Add(viewAttendancetabPage);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(329, 214);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1576, 760);
            TabControl.TabIndex = 23;
            // 
            // viewAttendancetabPage
            // 
            viewAttendancetabPage.BackColor = SystemColors.Window;
            viewAttendancetabPage.Controls.Add(label4);
            viewAttendancetabPage.Controls.Add(dataGridView1);
            viewAttendancetabPage.Location = new Point(4, 4);
            viewAttendancetabPage.Name = "viewAttendancetabPage";
            viewAttendancetabPage.Padding = new Padding(3);
            viewAttendancetabPage.Size = new Size(1568, 726);
            viewAttendancetabPage.TabIndex = 1;
            viewAttendancetabPage.Text = "View Attendance";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(142, 195, 176);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(186, 23);
            label4.TabIndex = 26;
            label4.Text = "View Attendance:";
            label4.Click += label4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10 });
            dataGridView1.Location = new Point(74, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1421, 456);
            dataGridView1.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Attendance ID";
            dataGridViewTextBoxColumn6.MinimumWidth = 6;
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Student ID";
            dataGridViewTextBoxColumn7.MinimumWidth = 6;
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Course ID";
            dataGridViewTextBoxColumn8.MinimumWidth = 6;
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.HeaderText = "Attendance Date";
            dataGridViewTextBoxColumn9.MinimumWidth = 6;
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.HeaderText = "Status";
            dataGridViewTextBoxColumn10.MinimumWidth = 6;
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelBack);
            Controls.Add(TabControl);
            Controls.Add(dashboardPanel);
            Name = "Attendance";
            Text = "Attendance";
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            markAttendanceTabPage.ResumeLayout(false);
            markAttendanceTabPage.PerformLayout();
            TabControl.ResumeLayout(false);
            viewAttendancetabPage.ResumeLayout(false);
            viewAttendancetabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPanel;
        private Button archivedButton;
        private Button departmentButton;
        private Button professorButton;
        private Button CclassButton;
        private Button courseButton;
        private Button attendanceButton;
        private Button studentButton;
        private Button dashboardButton;
        private Panel dashboardSmallpanel;
        private Label dashboardTitle;
        private PictureBox dashboardPictureBox;
        private Button ReportButton;
        private Panel panelBack;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Panel panel2;
        private TabPage markAttendanceTabPage;
        private Label addStudentLabel;
        private Label studentIDLabel;
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private TabControl TabControl;
        private Label label1;
        private Panel panel3;
        private UserControlDashboard userControlDashboard1;
        private ComboBox comboBox1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private ComboBox comboBox2;
        private Label label2;
        private Panel panel7;
        private TabPage viewAttendancetabPage;
        private ComboBox comboBox3;
        private Label label3;
        private Panel panel8;
        private UserControlDashboard userControlDashboard2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private Button SaveAttendanceButton;
        private Label label4;
    }
}