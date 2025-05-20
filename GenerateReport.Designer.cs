namespace Student_Attendance_Management_System
{
    partial class GenerateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReport));
            TabControl = new TabControl();
            ClassReportTabPage = new TabPage();
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            CourseOutputLabel = new Label();
            userControlDashboard2 = new UserControlDashboard();
            CourseComboBox = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            userControlDashboard1 = new UserControlDashboard();
            ReportLabel = new Label();
            studentIDLabel = new Label();
            panel1 = new Panel();
            StudentDateTimePicker = new DateTimePicker();
            StudentReportTabPage = new TabPage();
            pictureBox2 = new PictureBox();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            StudentIDComboBox = new ComboBox();
            labelStudentID = new Label();
            panel3 = new Panel();
            panel8 = new Panel();
            panel9 = new Panel();
            panel10 = new Panel();
            label4 = new Label();
            label5 = new Label();
            panel11 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            panelBack = new Panel();
            panel2 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            archivedButton = new Button();
            dashboardTitle = new Label();
            dashboardPictureBox = new PictureBox();
            ButtonReport = new Button();
            ReportsButton = new Button();
            ReportButton = new Button();
            attendanceButton = new Button();
            dashboardSmallpanel = new Panel();
            dashboardPanel = new Panel();
            TabControl.SuspendLayout();
            ClassReportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            StudentReportTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            dashboardSmallpanel.SuspendLayout();
            dashboardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(ClassReportTabPage);
            TabControl.Controls.Add(StudentReportTabPage);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(270, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 29;
            // 
            // ClassReportTabPage
            // 
            ClassReportTabPage.BackColor = SystemColors.Window;
            ClassReportTabPage.Controls.Add(pictureBox1);
            ClassReportTabPage.Controls.Add(dataGridView1);
            ClassReportTabPage.Controls.Add(CourseOutputLabel);
            ClassReportTabPage.Controls.Add(userControlDashboard2);
            ClassReportTabPage.Controls.Add(CourseComboBox);
            ClassReportTabPage.Controls.Add(label2);
            ClassReportTabPage.Controls.Add(panel7);
            ClassReportTabPage.Controls.Add(panel6);
            ClassReportTabPage.Controls.Add(panel5);
            ClassReportTabPage.Controls.Add(panel4);
            ClassReportTabPage.Controls.Add(userControlDashboard1);
            ClassReportTabPage.Controls.Add(ReportLabel);
            ClassReportTabPage.Controls.Add(studentIDLabel);
            ClassReportTabPage.Controls.Add(panel1);
            ClassReportTabPage.Controls.Add(StudentDateTimePicker);
            ClassReportTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClassReportTabPage.Location = new Point(4, 4);
            ClassReportTabPage.Name = "ClassReportTabPage";
            ClassReportTabPage.Padding = new Padding(3);
            ClassReportTabPage.Size = new Size(1624, 726);
            ClassReportTabPage.TabIndex = 0;
            ClassReportTabPage.Text = "Class Report";
            ClassReportTabPage.Click += ClassReportTabPage_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1438, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
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
            dataGridView1.Location = new Point(81, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(1421, 456);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CourseOutputLabel
            // 
            CourseOutputLabel.Location = new Point(83, 208);
            CourseOutputLabel.Name = "CourseOutputLabel";
            CourseOutputLabel.Size = new Size(496, 23);
            CourseOutputLabel.TabIndex = 37;
            // 
            // userControlDashboard2
            // 
            userControlDashboard2.AutoSize = true;
            userControlDashboard2.Location = new Point(1751, 327);
            userControlDashboard2.Margin = new Padding(6, 3, 6, 3);
            userControlDashboard2.Name = "userControlDashboard2";
            userControlDashboard2.Size = new Size(0, 615);
            userControlDashboard2.TabIndex = 34;
            // 
            // CourseComboBox
            // 
            CourseComboBox.BackColor = SystemColors.Window;
            CourseComboBox.FlatStyle = FlatStyle.Flat;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(898, 128);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(240, 29);
            CourseComboBox.TabIndex = 33;
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(904, 102);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 31;
            label2.Text = "Course:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(898, 159);
            panel7.Name = "panel7";
            panel7.Size = new Size(240, 2);
            panel7.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.Location = new Point(577, 134);
            panel6.Name = "panel6";
            panel6.Size = new Size(10, 27);
            panel6.TabIndex = 30;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(330, 134);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 30);
            panel5.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(339, 159);
            panel4.Name = "panel4";
            panel4.Size = new Size(240, 2);
            panel4.TabIndex = 9;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.AutoSize = true;
            userControlDashboard1.Location = new Point(1751, 107);
            userControlDashboard1.Margin = new Padding(6, 3, 6, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(0, 615);
            userControlDashboard1.TabIndex = 29;
            // 
            // ReportLabel
            // 
            ReportLabel.AutoSize = true;
            ReportLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReportLabel.ForeColor = Color.FromArgb(142, 195, 176);
            ReportLabel.Location = new Point(12, 12);
            ReportLabel.Name = "ReportLabel";
            ReportLabel.Size = new Size(79, 23);
            ReportLabel.TabIndex = 22;
            ReportLabel.Text = "Report:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(341, 102);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(57, 22);
            studentIDLabel.TabIndex = 5;
            studentIDLabel.Text = "Date:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(335, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 10);
            panel1.TabIndex = 8;
            // 
            // StudentDateTimePicker
            // 
            StudentDateTimePicker.CalendarTitleForeColor = SystemColors.Window;
            StudentDateTimePicker.CalendarTrailingForeColor = SystemColors.Control;
            StudentDateTimePicker.CustomFormat = "MM/dd/yyyy";
            StudentDateTimePicker.Format = DateTimePickerFormat.Custom;
            StudentDateTimePicker.Location = new Point(339, 131);
            StudentDateTimePicker.Name = "StudentDateTimePicker";
            StudentDateTimePicker.Size = new Size(242, 30);
            StudentDateTimePicker.TabIndex = 23;
            // 
            // StudentReportTabPage
            // 
            StudentReportTabPage.BackColor = SystemColors.Window;
            StudentReportTabPage.Controls.Add(pictureBox2);
            StudentReportTabPage.Controls.Add(dataGridView2);
            StudentReportTabPage.Controls.Add(label1);
            StudentReportTabPage.Controls.Add(StudentIDComboBox);
            StudentReportTabPage.Controls.Add(labelStudentID);
            StudentReportTabPage.Controls.Add(panel3);
            StudentReportTabPage.Controls.Add(panel8);
            StudentReportTabPage.Controls.Add(panel9);
            StudentReportTabPage.Controls.Add(panel10);
            StudentReportTabPage.Controls.Add(label4);
            StudentReportTabPage.Controls.Add(label5);
            StudentReportTabPage.Controls.Add(panel11);
            StudentReportTabPage.Controls.Add(dateTimePicker1);
            StudentReportTabPage.Location = new Point(4, 4);
            StudentReportTabPage.Name = "StudentReportTabPage";
            StudentReportTabPage.Padding = new Padding(3);
            StudentReportTabPage.Size = new Size(1624, 726);
            StudentReportTabPage.TabIndex = 1;
            StudentReportTabPage.Text = "Student Report";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1447, 44);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.BorderStyle = BorderStyle.None;
            dataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridView2.Location = new Point(92, 217);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView2.ScrollBars = ScrollBars.Vertical;
            dataGridView2.Size = new Size(1421, 456);
            dataGridView2.TabIndex = 53;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Attendance ID";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Student ID";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Course ID";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Attendance Date";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Status";
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // label1
            // 
            label1.Location = new Point(92, 217);
            label1.Name = "label1";
            label1.Size = new Size(496, 23);
            label1.TabIndex = 52;
            // 
            // StudentIDComboBox
            // 
            StudentIDComboBox.BackColor = SystemColors.Window;
            StudentIDComboBox.FlatStyle = FlatStyle.Flat;
            StudentIDComboBox.FormattingEnabled = true;
            StudentIDComboBox.Location = new Point(907, 137);
            StudentIDComboBox.Name = "StudentIDComboBox";
            StudentIDComboBox.Size = new Size(240, 29);
            StudentIDComboBox.TabIndex = 51;
            StudentIDComboBox.SelectedIndexChanged += StudentIDComboBox_SelectedIndexChanged;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelStudentID.Location = new Point(913, 111);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(103, 22);
            labelStudentID.TabIndex = 49;
            labelStudentID.Text = "Student ID:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(907, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(240, 2);
            panel3.TabIndex = 50;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Transparent;
            panel8.Location = new Point(586, 143);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 27);
            panel8.TabIndex = 48;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Transparent;
            panel9.Location = new Point(339, 143);
            panel9.Name = "panel9";
            panel9.Size = new Size(10, 30);
            panel9.TabIndex = 45;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(348, 168);
            panel10.Name = "panel10";
            panel10.Size = new Size(240, 2);
            panel10.TabIndex = 44;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(142, 195, 176);
            label4.Location = new Point(21, 21);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 46;
            label4.Text = "Report:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 111);
            label5.Name = "label5";
            label5.Size = new Size(57, 22);
            label5.TabIndex = 42;
            label5.Text = "Date:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Location = new Point(344, 134);
            panel11.Name = "panel11";
            panel11.Size = new Size(250, 10);
            panel11.TabIndex = 43;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarTitleForeColor = SystemColors.Window;
            dateTimePicker1.CalendarTrailingForeColor = SystemColors.Control;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(348, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 30);
            dateTimePicker1.TabIndex = 47;
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Window;
            panelBack.Controls.Add(panel2);
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Location = new Point(272, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1628, 224);
            panelBack.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(188, 234, 213);
            panel2.Location = new Point(-9, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(1637, 126);
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
            // archivedButton
            // 
            archivedButton.Anchor = AnchorStyles.None;
            archivedButton.FlatAppearance.BorderSize = 0;
            archivedButton.FlatStyle = FlatStyle.Flat;
            archivedButton.Font = new Font("Century Gothic", 11F);
            archivedButton.Image = (Image)resources.GetObject("archivedButton.Image");
            archivedButton.ImageAlign = ContentAlignment.MiddleLeft;
            archivedButton.Location = new Point(148, 2454);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // dashboardTitle
            // 
            dashboardTitle.Anchor = AnchorStyles.None;
            dashboardTitle.BackColor = Color.Transparent;
            dashboardTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.Location = new Point(31, 109);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(261, 67);
            dashboardTitle.TabIndex = 3;
            dashboardTitle.Text = "Student Attendance Management System";
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.None;
            dashboardPictureBox.Image = (Image)resources.GetObject("dashboardPictureBox.Image");
            dashboardPictureBox.Location = new Point(118, 27);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new Size(64, 64);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboardPictureBox.TabIndex = 2;
            dashboardPictureBox.TabStop = false;
            // 
            // ButtonReport
            // 
            ButtonReport.Anchor = AnchorStyles.None;
            ButtonReport.FlatAppearance.BorderSize = 0;
            ButtonReport.FlatStyle = FlatStyle.Flat;
            ButtonReport.Font = new Font("Century Gothic", 11F);
            ButtonReport.Image = (Image)resources.GetObject("ButtonReport.Image");
            ButtonReport.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonReport.Location = new Point(13, 295);
            ButtonReport.Name = "ButtonReport";
            ButtonReport.Size = new Size(220, 40);
            ButtonReport.TabIndex = 20;
            ButtonReport.Text = "                Report";
            ButtonReport.TextAlign = ContentAlignment.MiddleLeft;
            ButtonReport.UseVisualStyleBackColor = true;
            ButtonReport.Click += ButtonReport_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Anchor = AnchorStyles.None;
            ReportsButton.FlatAppearance.BorderSize = 0;
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.Font = new Font("Century Gothic", 11F);
            ReportsButton.Image = (Image)resources.GetObject("ReportsButton.Image");
            ReportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsButton.Location = new Point(87, 1524);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(220, 40);
            ReportsButton.TabIndex = 19;
            ReportsButton.Text = "                Report";
            ReportsButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportsButton.UseVisualStyleBackColor = true;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.None;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 11F);
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(123, 1975);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(220, 40);
            ReportButton.TabIndex = 17;
            ReportButton.Text = "                Reports";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            // 
            // attendanceButton
            // 
            attendanceButton.Anchor = AnchorStyles.None;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.Font = new Font("Century Gothic", 11F);
            attendanceButton.Image = (Image)resources.GetObject("attendanceButton.Image");
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceButton.Location = new Point(13, 245);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(220, 40);
            attendanceButton.TabIndex = 12;
            attendanceButton.Text = "                Attendance";
            attendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            attendanceButton.UseVisualStyleBackColor = true;
            attendanceButton.Click += attendanceButton_Click;
            // 
            // dashboardSmallpanel
            // 
            dashboardSmallpanel.Anchor = AnchorStyles.None;
            dashboardSmallpanel.Controls.Add(dashboardTitle);
            dashboardSmallpanel.Controls.Add(dashboardPictureBox);
            dashboardSmallpanel.Location = new Point(0, 3);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(274, 224);
            dashboardSmallpanel.TabIndex = 9;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(ButtonReport);
            dashboardPanel.Controls.Add(ReportsButton);
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(attendanceButton);
            dashboardPanel.Controls.Add(dashboardSmallpanel);
            dashboardPanel.Controls.Add(archivedButton);
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(274, 1033);
            dashboardPanel.TabIndex = 31;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(TabControl);
            Controls.Add(panelBack);
            Controls.Add(dashboardPanel);
            Name = "GenerateReport";
            Text = "GenerateReport";
            TabControl.ResumeLayout(false);
            ClassReportTabPage.ResumeLayout(false);
            ClassReportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            StudentReportTabPage.ResumeLayout(false);
            StudentReportTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ClassReportTabPage;
        private Label CourseOutputLabel;
        private UserControlDashboard userControlDashboard2;
        private ComboBox CourseComboBox;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private UserControlDashboard userControlDashboard1;
        private Label ReportLabel;
        private Label studentIDLabel;
        private Panel panel1;
        private DateTimePicker StudentDateTimePicker;
        private Panel panelBack;
        private Panel panel2;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Button archivedButton;
        private Label dashboardTitle;
        private PictureBox dashboardPictureBox;
        private Button ButtonReport;
        private Button ReportsButton;
        private Button ReportButton;
        private Button attendanceButton;
        private Panel dashboardSmallpanel;
        private Panel dashboardPanel;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private TabPage StudentReportTabPage;
        private PictureBox pictureBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private Label label1;
        private ComboBox StudentIDComboBox;
        private Label labelStudentID;
        private Panel panel3;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private Label label4;
        private Label label5;
        private Panel panel11;
        private DateTimePicker dateTimePicker1;
    }
}