namespace Student_Attendance_Management_System
{
    partial class MarkAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkAttendance));
            dashboardPanel = new Panel();
            ButtonReport = new Button();
            ReportsButton = new Button();
            ReportButton = new Button();
            attendanceButton = new Button();
            dashboardSmallpanel = new Panel();
            dashboardTitle = new Label();
            dashboardPictureBox = new PictureBox();
            archivedButton = new Button();
            panel2 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            panelBack = new Panel();
            markAttendanceTabPage = new TabPage();
            SaveButton = new Button();
            StudentListDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewCheckBoxColumn();
            CourseOutputLabel = new Label();
            userControlDashboard2 = new UserControlDashboard();
            CourseComboBox = new ComboBox();
            label2 = new Label();
            panel7 = new Panel();
            panel6 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            userControlDashboard1 = new UserControlDashboard();
            addStudentLabel = new Label();
            studentIDLabel = new Label();
            panel1 = new Panel();
            AttendanceDateTimePicker = new DateTimePicker();
            TabControl = new TabControl();
            panel3 = new Panel();
            logoutButton = new Button();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            panelBack.SuspendLayout();
            markAttendanceTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentListDataGridView).BeginInit();
            TabControl.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
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
            dashboardPanel.TabIndex = 28;
            // 
            // ButtonReport
            // 
            ButtonReport.Anchor = AnchorStyles.None;
            ButtonReport.FlatAppearance.BorderSize = 0;
            ButtonReport.FlatStyle = FlatStyle.Flat;
            ButtonReport.Font = new Font("Century Gothic", 11F);
            ButtonReport.Image = (Image)resources.GetObject("ButtonReport.Image");
            ButtonReport.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonReport.Location = new Point(13, 292);
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
            ReportsButton.Location = new Point(50, 1058);
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
            ReportButton.Location = new Point(86, 1509);
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
            attendanceButton.Location = new Point(13, 242);
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
            archivedButton.Location = new Point(111, 1988);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(188, 234, 213);
            panel2.Controls.Add(panel3);
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
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Window;
            panelBack.Controls.Add(panel2);
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Location = new Point(272, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1628, 224);
            panelBack.TabIndex = 27;
            // 
            // markAttendanceTabPage
            // 
            markAttendanceTabPage.BackColor = SystemColors.Window;
            markAttendanceTabPage.Controls.Add(SaveButton);
            markAttendanceTabPage.Controls.Add(StudentListDataGridView);
            markAttendanceTabPage.Controls.Add(CourseOutputLabel);
            markAttendanceTabPage.Controls.Add(userControlDashboard2);
            markAttendanceTabPage.Controls.Add(CourseComboBox);
            markAttendanceTabPage.Controls.Add(label2);
            markAttendanceTabPage.Controls.Add(panel7);
            markAttendanceTabPage.Controls.Add(panel6);
            markAttendanceTabPage.Controls.Add(panel5);
            markAttendanceTabPage.Controls.Add(panel4);
            markAttendanceTabPage.Controls.Add(userControlDashboard1);
            markAttendanceTabPage.Controls.Add(addStudentLabel);
            markAttendanceTabPage.Controls.Add(studentIDLabel);
            markAttendanceTabPage.Controls.Add(panel1);
            markAttendanceTabPage.Controls.Add(AttendanceDateTimePicker);
            markAttendanceTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            markAttendanceTabPage.Location = new Point(4, 4);
            markAttendanceTabPage.Name = "markAttendanceTabPage";
            markAttendanceTabPage.Padding = new Padding(3);
            markAttendanceTabPage.Size = new Size(1624, 726);
            markAttendanceTabPage.TabIndex = 0;
            markAttendanceTabPage.Text = "Mark Attendance";
            // 
            // SaveButton
            // 
            SaveButton.BackColor = Color.FromArgb(142, 195, 176);
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(1317, 121);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(150, 40);
            SaveButton.TabIndex = 39;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click_1;
            // 
            // StudentListDataGridView
            // 
            StudentListDataGridView.AllowUserToAddRows = false;
            StudentListDataGridView.AllowUserToDeleteRows = false;
            StudentListDataGridView.AllowUserToResizeColumns = false;
            StudentListDataGridView.AllowUserToResizeRows = false;
            StudentListDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StudentListDataGridView.BackgroundColor = Color.White;
            StudentListDataGridView.BorderStyle = BorderStyle.None;
            StudentListDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            StudentListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentListDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            StudentListDataGridView.Location = new Point(83, 245);
            StudentListDataGridView.Name = "StudentListDataGridView";
            StudentListDataGridView.ReadOnly = true;
            StudentListDataGridView.RowHeadersWidth = 51;
            StudentListDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            StudentListDataGridView.ScrollBars = ScrollBars.Vertical;
            StudentListDataGridView.Size = new Size(1421, 456);
            StudentListDataGridView.TabIndex = 36;
            StudentListDataGridView.CellContentClick += StudentListDataGridView_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Student ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Student Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Status";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
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
            userControlDashboard2.Location = new Point(1748, 324);
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
            label2.Location = new Point(901, 99);
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
            userControlDashboard1.Location = new Point(1748, 104);
            userControlDashboard1.Margin = new Padding(6, 3, 6, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(0, 615);
            userControlDashboard1.TabIndex = 29;
            // 
            // addStudentLabel
            // 
            addStudentLabel.AutoSize = true;
            addStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            addStudentLabel.Location = new Point(9, 9);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(187, 23);
            addStudentLabel.TabIndex = 22;
            addStudentLabel.Text = "Mark Attendance:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(338, 99);
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
            // AttendanceDateTimePicker
            // 
            AttendanceDateTimePicker.CalendarTitleForeColor = SystemColors.Window;
            AttendanceDateTimePicker.CalendarTrailingForeColor = SystemColors.Control;
            AttendanceDateTimePicker.CustomFormat = "MM/dd/yyyy";
            AttendanceDateTimePicker.Format = DateTimePickerFormat.Custom;
            AttendanceDateTimePicker.Location = new Point(339, 131);
            AttendanceDateTimePicker.Name = "AttendanceDateTimePicker";
            AttendanceDateTimePicker.Size = new Size(242, 30);
            AttendanceDateTimePicker.TabIndex = 23;
            AttendanceDateTimePicker.ValueChanged += AttendanceDateTimePicker_ValueChanged;
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(markAttendanceTabPage);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(270, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 26;
            // 
            // panel3
            // 
            panel3.Controls.Add(logoutButton);
            panel3.Location = new Point(1328, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 125);
            panel3.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(0, -3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 67);
            logoutButton.TabIndex = 0;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // MarkAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dashboardPanel);
            Controls.Add(TabControl);
            Controls.Add(panelBack);
            Name = "MarkAttendance";
            Text = "MarkAttendance";
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            markAttendanceTabPage.ResumeLayout(false);
            markAttendanceTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentListDataGridView).EndInit();
            TabControl.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel dashboardPanel;
        private Button ReportsButton;
        private Button ReportButton;
        private Button attendanceButton;
        private Panel dashboardSmallpanel;
        private Label dashboardTitle;
        private PictureBox dashboardPictureBox;
        private Button archivedButton;
        private Panel panel2;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Panel panelBack;
        private TabPage markAttendanceTabPage;
        private UserControlDashboard userControlDashboard2;
        private ComboBox CourseComboBox;
        private Label label2;
        private Panel panel7;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private UserControlDashboard userControlDashboard1;
        private Label addStudentLabel;
        private Label studentIDLabel;
        private Panel panel1;
        private DateTimePicker AttendanceDateTimePicker;
        private TabControl TabControl;
        private Button ButtonReport;
        private Label CourseOutputLabel;
        private DataGridView StudentListDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewCheckBoxColumn Column3;
        private Button SaveButton;
        private Panel panel3;
        private Button logoutButton;
    }
}