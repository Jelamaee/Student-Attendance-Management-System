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
            panelBack = new Panel();
            panel2 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            markAttendanceTabPage = new TabPage();
            SaveAttendanceButton = new Button();
            StudentStatusComboBox = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            userControlDashboard2 = new UserControlDashboard();
            CourseComboBox = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            userControlDashboard1 = new UserControlDashboard();
            StudentIDComboBox = new ComboBox();
            label1 = new Label();
            panel3 = new Panel();
            addStudentLabel = new Label();
            studentIDLabel = new Label();
            panel1 = new Panel();
            StudentDateTimePicker = new DateTimePicker();
            TabControl = new TabControl();
            viewAttendancetabPage = new TabPage();
            label4 = new Label();
            AttendanceDataGridView = new DataGridView();
            dashboardPanel = new Panel();
            RegisterButton = new Button();
            ReportsButton = new Button();
            ReportButton = new Button();
            departmentButton = new Button();
            professorButton = new Button();
            classButton = new Button();
            courseButton = new Button();
            attendanceButton = new Button();
            studentButton = new Button();
            dashboardButton = new Button();
            dashboardSmallpanel = new Panel();
            dashboardTitle = new Label();
            dashboardPictureBox = new PictureBox();
            archivedButton = new Button();
            panel9 = new Panel();
            logoutButton = new Button();
            panelBack.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            markAttendanceTabPage.SuspendLayout();
            TabControl.SuspendLayout();
            viewAttendancetabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGridView).BeginInit();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            panel9.SuspendLayout();
            SuspendLayout();
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Window;
            panelBack.Controls.Add(panel2);
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Location = new Point(274, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1628, 224);
            panelBack.TabIndex = 24;
            panelBack.Paint += panelBack_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(188, 234, 213);
            panel2.Controls.Add(panel9);
            panel2.Location = new Point(-9, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(1637, 126);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
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
            expandPictureBox.Click += expandPictureBox_Click;
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
            markAttendanceTabPage.Controls.Add(StudentStatusComboBox);
            markAttendanceTabPage.Controls.Add(label3);
            markAttendanceTabPage.Controls.Add(panel8);
            markAttendanceTabPage.Controls.Add(userControlDashboard2);
            markAttendanceTabPage.Controls.Add(CourseComboBox);
            markAttendanceTabPage.Controls.Add(label2);
            markAttendanceTabPage.Controls.Add(panel7);
            markAttendanceTabPage.Controls.Add(panel6);
            markAttendanceTabPage.Controls.Add(panel5);
            markAttendanceTabPage.Controls.Add(panel4);
            markAttendanceTabPage.Controls.Add(userControlDashboard1);
            markAttendanceTabPage.Controls.Add(StudentIDComboBox);
            markAttendanceTabPage.Controls.Add(label1);
            markAttendanceTabPage.Controls.Add(panel3);
            markAttendanceTabPage.Controls.Add(addStudentLabel);
            markAttendanceTabPage.Controls.Add(studentIDLabel);
            markAttendanceTabPage.Controls.Add(panel1);
            markAttendanceTabPage.Controls.Add(StudentDateTimePicker);
            markAttendanceTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markAttendanceTabPage.Location = new Point(4, 4);
            markAttendanceTabPage.Name = "markAttendanceTabPage";
            markAttendanceTabPage.Padding = new Padding(3);
            markAttendanceTabPage.Size = new Size(1624, 726);
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
            SaveAttendanceButton.Click += SaveAttendanceButton_Click;
            // 
            // StudentStatusComboBox
            // 
            StudentStatusComboBox.AllowDrop = true;
            StudentStatusComboBox.BackColor = SystemColors.Window;
            StudentStatusComboBox.FlatStyle = FlatStyle.Flat;
            StudentStatusComboBox.FormattingEnabled = true;
            StudentStatusComboBox.Location = new Point(806, 338);
            StudentStatusComboBox.Name = "StudentStatusComboBox";
            StudentStatusComboBox.Size = new Size(240, 29);
            StudentStatusComboBox.TabIndex = 37;
            StudentStatusComboBox.SelectedIndexChanged += StudentStatusComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(806, 306);
            label3.Name = "label3";
            label3.Size = new Size(65, 22);
            label3.TabIndex = 35;
            label3.Text = "Status:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(806, 369);
            panel8.Name = "panel8";
            panel8.Size = new Size(240, 2);
            panel8.TabIndex = 36;
            // 
            // userControlDashboard2
            // 
            userControlDashboard2.AutoSize = true;
            userControlDashboard2.Location = new Point(1070, 306);
            userControlDashboard2.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard2.Name = "userControlDashboard2";
            userControlDashboard2.Size = new Size(0, 586);
            userControlDashboard2.TabIndex = 34;
            // 
            // CourseComboBox
            // 
            CourseComboBox.BackColor = SystemColors.Window;
            CourseComboBox.FlatStyle = FlatStyle.Flat;
            CourseComboBox.FormattingEnabled = true;
            CourseComboBox.Location = new Point(806, 128);
            CourseComboBox.Name = "CourseComboBox";
            CourseComboBox.Size = new Size(240, 29);
            CourseComboBox.TabIndex = 33;
            CourseComboBox.SelectedIndexChanged += CourseComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(806, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 31;
            label2.Text = "Course:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(806, 159);
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
            userControlDashboard1.Location = new Point(872, 96);
            userControlDashboard1.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(0, 586);
            userControlDashboard1.TabIndex = 29;
            // 
            // StudentIDComboBox
            // 
            StudentIDComboBox.BackColor = SystemColors.Window;
            StudentIDComboBox.FlatStyle = FlatStyle.Flat;
            StudentIDComboBox.FormattingEnabled = true;
            StudentIDComboBox.Location = new Point(317, 128);
            StudentIDComboBox.Name = "StudentIDComboBox";
            StudentIDComboBox.Size = new Size(240, 29);
            StudentIDComboBox.TabIndex = 28;
            StudentIDComboBox.SelectedIndexChanged += StudentIDComboBox_SelectedIndexChanged;
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
            // StudentDateTimePicker
            // 
            StudentDateTimePicker.CalendarTitleForeColor = SystemColors.Window;
            StudentDateTimePicker.CalendarTrailingForeColor = SystemColors.Control;
            StudentDateTimePicker.CustomFormat = "MM/dd/yyyy";
            StudentDateTimePicker.Format = DateTimePickerFormat.Custom;
            StudentDateTimePicker.Location = new Point(321, 341);
            StudentDateTimePicker.Name = "StudentDateTimePicker";
            StudentDateTimePicker.Size = new Size(242, 30);
            StudentDateTimePicker.TabIndex = 23;
            StudentDateTimePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(markAttendanceTabPage);
            TabControl.Controls.Add(viewAttendancetabPage);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(272, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 23;
            // 
            // viewAttendancetabPage
            // 
            viewAttendancetabPage.BackColor = SystemColors.Window;
            viewAttendancetabPage.Controls.Add(label4);
            viewAttendancetabPage.Controls.Add(AttendanceDataGridView);
            viewAttendancetabPage.Location = new Point(4, 4);
            viewAttendancetabPage.Name = "viewAttendancetabPage";
            viewAttendancetabPage.Padding = new Padding(3);
            viewAttendancetabPage.Size = new Size(1624, 726);
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
            // AttendanceDataGridView
            // 
            AttendanceDataGridView.AllowUserToAddRows = false;
            AttendanceDataGridView.AllowUserToDeleteRows = false;
            AttendanceDataGridView.AllowUserToResizeColumns = false;
            AttendanceDataGridView.AllowUserToResizeRows = false;
            AttendanceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AttendanceDataGridView.BackgroundColor = Color.White;
            AttendanceDataGridView.BorderStyle = BorderStyle.None;
            AttendanceDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            AttendanceDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AttendanceDataGridView.Location = new Point(74, 135);
            AttendanceDataGridView.Name = "AttendanceDataGridView";
            AttendanceDataGridView.ReadOnly = true;
            AttendanceDataGridView.RowHeadersWidth = 51;
            AttendanceDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            AttendanceDataGridView.ScrollBars = ScrollBars.Vertical;
            AttendanceDataGridView.Size = new Size(1421, 456);
            AttendanceDataGridView.TabIndex = 25;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(RegisterButton);
            dashboardPanel.Controls.Add(ReportsButton);
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(departmentButton);
            dashboardPanel.Controls.Add(professorButton);
            dashboardPanel.Controls.Add(classButton);
            dashboardPanel.Controls.Add(courseButton);
            dashboardPanel.Controls.Add(attendanceButton);
            dashboardPanel.Controls.Add(studentButton);
            dashboardPanel.Controls.Add(dashboardButton);
            dashboardPanel.Controls.Add(dashboardSmallpanel);
            dashboardPanel.Controls.Add(archivedButton);
            dashboardPanel.Location = new Point(2, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(274, 1033);
            dashboardPanel.TabIndex = 25;
            // 
            // RegisterButton
            // 
            RegisterButton.Anchor = AnchorStyles.None;
            RegisterButton.FlatAppearance.BorderSize = 0;
            RegisterButton.FlatStyle = FlatStyle.Flat;
            RegisterButton.Font = new Font("Century Gothic", 11F);
            RegisterButton.Image = (Image)resources.GetObject("RegisterButton.Image");
            RegisterButton.ImageAlign = ContentAlignment.MiddleLeft;
            RegisterButton.Location = new Point(13, 642);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(220, 40);
            RegisterButton.TabIndex = 22;
            RegisterButton.Text = "                Register";
            RegisterButton.TextAlign = ContentAlignment.MiddleLeft;
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ReportsButton
            // 
            ReportsButton.Anchor = AnchorStyles.None;
            ReportsButton.FlatAppearance.BorderSize = 0;
            ReportsButton.FlatStyle = FlatStyle.Flat;
            ReportsButton.Font = new Font("Century Gothic", 11F);
            ReportsButton.Image = (Image)resources.GetObject("ReportsButton.Image");
            ReportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportsButton.Location = new Point(13, 592);
            ReportsButton.Name = "ReportsButton";
            ReportsButton.Size = new Size(220, 40);
            ReportsButton.TabIndex = 19;
            ReportsButton.Text = "                Report";
            ReportsButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click_1;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.None;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 11F);
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(49, 1043);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(220, 40);
            ReportButton.TabIndex = 17;
            ReportButton.Text = "                Reports";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            // 
            // departmentButton
            // 
            departmentButton.Anchor = AnchorStyles.None;
            departmentButton.FlatAppearance.BorderSize = 0;
            departmentButton.FlatStyle = FlatStyle.Flat;
            departmentButton.Font = new Font("Century Gothic", 11F);
            departmentButton.Image = (Image)resources.GetObject("departmentButton.Image");
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            departmentButton.Location = new Point(13, 542);
            departmentButton.Name = "departmentButton";
            departmentButton.Size = new Size(220, 40);
            departmentButton.TabIndex = 16;
            departmentButton.Text = "                Department";
            departmentButton.TextAlign = ContentAlignment.MiddleLeft;
            departmentButton.UseVisualStyleBackColor = true;
            departmentButton.Click += departmentButton_Click_1;
            // 
            // professorButton
            // 
            professorButton.Anchor = AnchorStyles.None;
            professorButton.FlatAppearance.BorderSize = 0;
            professorButton.FlatStyle = FlatStyle.Flat;
            professorButton.Font = new Font("Century Gothic", 11F);
            professorButton.Image = (Image)resources.GetObject("professorButton.Image");
            professorButton.ImageAlign = ContentAlignment.MiddleLeft;
            professorButton.Location = new Point(13, 492);
            professorButton.Name = "professorButton";
            professorButton.Size = new Size(220, 40);
            professorButton.TabIndex = 15;
            professorButton.Text = "                Professor";
            professorButton.TextAlign = ContentAlignment.MiddleLeft;
            professorButton.UseVisualStyleBackColor = true;
            professorButton.Click += professorButton_Click_1;
            // 
            // classButton
            // 
            classButton.Anchor = AnchorStyles.None;
            classButton.FlatAppearance.BorderSize = 0;
            classButton.FlatStyle = FlatStyle.Flat;
            classButton.Font = new Font("Century Gothic", 11F);
            classButton.Image = (Image)resources.GetObject("classButton.Image");
            classButton.ImageAlign = ContentAlignment.MiddleLeft;
            classButton.Location = new Point(13, 442);
            classButton.Name = "classButton";
            classButton.Size = new Size(220, 40);
            classButton.TabIndex = 14;
            classButton.Text = "                Class";
            classButton.TextAlign = ContentAlignment.MiddleLeft;
            classButton.UseVisualStyleBackColor = true;
            classButton.Click += classButton_Click_1;
            // 
            // courseButton
            // 
            courseButton.Anchor = AnchorStyles.None;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Century Gothic", 11F);
            courseButton.Image = (Image)resources.GetObject("courseButton.Image");
            courseButton.ImageAlign = ContentAlignment.MiddleLeft;
            courseButton.Location = new Point(13, 392);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(220, 40);
            courseButton.TabIndex = 13;
            courseButton.Text = "                Course";
            courseButton.TextAlign = ContentAlignment.MiddleLeft;
            courseButton.UseVisualStyleBackColor = true;
            courseButton.Click += courseButton_Click_1;
            // 
            // attendanceButton
            // 
            attendanceButton.Anchor = AnchorStyles.None;
            attendanceButton.FlatAppearance.BorderSize = 0;
            attendanceButton.FlatStyle = FlatStyle.Flat;
            attendanceButton.Font = new Font("Century Gothic", 11F);
            attendanceButton.Image = (Image)resources.GetObject("attendanceButton.Image");
            attendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            attendanceButton.Location = new Point(13, 342);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(220, 40);
            attendanceButton.TabIndex = 12;
            attendanceButton.Text = "                Attendance";
            attendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            attendanceButton.UseVisualStyleBackColor = true;
            attendanceButton.Click += attendanceButton_Click_1;
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
            studentButton.Location = new Point(13, 292);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(220, 40);
            studentButton.TabIndex = 11;
            studentButton.Text = "                Student";
            studentButton.TextAlign = ContentAlignment.MiddleLeft;
            studentButton.UseVisualStyleBackColor = true;
            studentButton.Click += studentButton_Click_1;
            // 
            // dashboardButton
            // 
            dashboardButton.Anchor = AnchorStyles.None;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Font = new Font("Century Gothic", 11F);
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(13, 242);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(220, 40);
            dashboardButton.TabIndex = 10;
            dashboardButton.Text = "                Dashboard";
            dashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            dashboardButton.UseVisualStyleBackColor = true;
            dashboardButton.Click += dashboardButton_Click_1;
            // 
            // dashboardSmallpanel
            // 
            dashboardSmallpanel.Anchor = AnchorStyles.None;
            dashboardSmallpanel.Controls.Add(dashboardTitle);
            dashboardSmallpanel.Controls.Add(dashboardPictureBox);
            dashboardSmallpanel.Location = new Point(0, 0);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(274, 224);
            dashboardSmallpanel.TabIndex = 9;
            // 
            // dashboardTitle
            // 
            dashboardTitle.Anchor = AnchorStyles.None;
            dashboardTitle.BackColor = Color.Transparent;
            dashboardTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.Location = new Point(13, 124);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(261, 67);
            dashboardTitle.TabIndex = 3;
            dashboardTitle.Text = "Student Attendance Management System";
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.None;
            dashboardPictureBox.Image = (Image)resources.GetObject("dashboardPictureBox.Image");
            dashboardPictureBox.Location = new Point(100, 42);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new Size(64, 64);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboardPictureBox.TabIndex = 2;
            dashboardPictureBox.TabStop = false;
            // 
            // archivedButton
            // 
            archivedButton.Anchor = AnchorStyles.None;
            archivedButton.FlatAppearance.BorderSize = 0;
            archivedButton.FlatStyle = FlatStyle.Flat;
            archivedButton.Font = new Font("Century Gothic", 11F);
            archivedButton.Image = (Image)resources.GetObject("archivedButton.Image");
            archivedButton.ImageAlign = ContentAlignment.MiddleLeft;
            archivedButton.Location = new Point(74, 1522);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            panel9.Controls.Add(logoutButton);
            panel9.Location = new Point(1328, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(200, 125);
            panel9.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(0, 0);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 67);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dashboardPanel);
            Controls.Add(panelBack);
            Controls.Add(TabControl);
            Name = "Attendance";
            Text = "Attendance";
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            markAttendanceTabPage.ResumeLayout(false);
            markAttendanceTabPage.PerformLayout();
            TabControl.ResumeLayout(false);
            viewAttendancetabPage.ResumeLayout(false);
            viewAttendancetabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AttendanceDataGridView).EndInit();
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            panel9.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBack;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Panel panel2;
        private TabPage markAttendanceTabPage;
        private Label addStudentLabel;
        private Label studentIDLabel;
        private Panel panel1;
        private DateTimePicker StudentDateTimePicker;
        private TabControl TabControl;
        private Label label1;
        private Panel panel3;
        private UserControlDashboard userControlDashboard1;
        private ComboBox StudentIDComboBox;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private ComboBox CourseComboBox;
        private Label label2;
        private Panel panel7;
        private TabPage viewAttendancetabPage;
        private ComboBox StudentStatusComboBox;
        private Label label3;
        private Panel panel8;
        private UserControlDashboard userControlDashboard2;
        private DataGridView AttendanceDataGridView;
        private Button SaveAttendanceButton;
        private Label label4;
        private Panel dashboardPanel;
        private Button ReportButton;
        private Button departmentButton;
        private Button professorButton;
        private Button classButton;
        private Button courseButton;
        private Button attendanceButton;
        private Button studentButton;
        private Button dashboardButton;
        private Panel dashboardSmallpanel;
        private Label dashboardTitle;
        private PictureBox dashboardPictureBox;
        private Button archivedButton;
        private Button ReportsButton;
        private Button RegisterButton;
        private Panel panel9;
        private Button logoutButton;
    }
}