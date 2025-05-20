namespace Student_Attendance_Management_System
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            dashboardPanel = new Panel();
            RegisterButton = new Button();
            ReportButton = new Button();
            DepartmentButton = new Button();
            ProfessorButton = new Button();
            ClassButton = new Button();
            CourseButton = new Button();
            AttendanceButton = new Button();
            StudentButton = new Button();
            DashboardButton = new Button();
            dashboardSmallpanel = new Panel();
            dashboardTitle = new Label();
            dashboardPictureBox = new PictureBox();
            panelBack = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            panelTop = new Panel();
            panelExpand = new Panel();
            logoutButton = new Button();
            minimizePanel = new Panel();
            minimizeButton = new Button();
            userControlDashboard1 = new UserControlDashboard();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            panelTop.SuspendLayout();
            panelExpand.SuspendLayout();
            minimizePanel.SuspendLayout();
            SuspendLayout();
            // 
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(RegisterButton);
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(DepartmentButton);
            dashboardPanel.Controls.Add(ProfessorButton);
            dashboardPanel.Controls.Add(ClassButton);
            dashboardPanel.Controls.Add(CourseButton);
            dashboardPanel.Controls.Add(AttendanceButton);
            dashboardPanel.Controls.Add(StudentButton);
            dashboardPanel.Controls.Add(DashboardButton);
            dashboardPanel.Controls.Add(dashboardSmallpanel);
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(274, 1033);
            dashboardPanel.TabIndex = 0;
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
            RegisterButton.TabIndex = 9;
            RegisterButton.Text = "                Register";
            RegisterButton.TextAlign = ContentAlignment.MiddleLeft;
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.None;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 11F);
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(13, 592);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(220, 40);
            ReportButton.TabIndex = 8;
            ReportButton.Text = "                Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += ReportButton_Click;
            // 
            // DepartmentButton
            // 
            DepartmentButton.Anchor = AnchorStyles.None;
            DepartmentButton.FlatAppearance.BorderSize = 0;
            DepartmentButton.FlatStyle = FlatStyle.Flat;
            DepartmentButton.Font = new Font("Century Gothic", 11F);
            DepartmentButton.Image = (Image)resources.GetObject("DepartmentButton.Image");
            DepartmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            DepartmentButton.Location = new Point(13, 542);
            DepartmentButton.Name = "DepartmentButton";
            DepartmentButton.Size = new Size(220, 40);
            DepartmentButton.TabIndex = 7;
            DepartmentButton.Text = "                Department";
            DepartmentButton.TextAlign = ContentAlignment.MiddleLeft;
            DepartmentButton.UseVisualStyleBackColor = true;
            DepartmentButton.Click += DepartmentButton_Click;
            // 
            // ProfessorButton
            // 
            ProfessorButton.Anchor = AnchorStyles.None;
            ProfessorButton.FlatAppearance.BorderSize = 0;
            ProfessorButton.FlatStyle = FlatStyle.Flat;
            ProfessorButton.Font = new Font("Century Gothic", 11F);
            ProfessorButton.Image = (Image)resources.GetObject("ProfessorButton.Image");
            ProfessorButton.ImageAlign = ContentAlignment.MiddleLeft;
            ProfessorButton.Location = new Point(13, 492);
            ProfessorButton.Name = "ProfessorButton";
            ProfessorButton.Size = new Size(220, 40);
            ProfessorButton.TabIndex = 6;
            ProfessorButton.Text = "                Professor";
            ProfessorButton.TextAlign = ContentAlignment.MiddleLeft;
            ProfessorButton.UseVisualStyleBackColor = true;
            ProfessorButton.Click += ProfessorButton_Click;
            // 
            // ClassButton
            // 
            ClassButton.Anchor = AnchorStyles.None;
            ClassButton.FlatAppearance.BorderSize = 0;
            ClassButton.FlatStyle = FlatStyle.Flat;
            ClassButton.Font = new Font("Century Gothic", 11F);
            ClassButton.Image = (Image)resources.GetObject("ClassButton.Image");
            ClassButton.ImageAlign = ContentAlignment.MiddleLeft;
            ClassButton.Location = new Point(13, 442);
            ClassButton.Name = "ClassButton";
            ClassButton.Size = new Size(220, 40);
            ClassButton.TabIndex = 5;
            ClassButton.Text = "                Class";
            ClassButton.TextAlign = ContentAlignment.MiddleLeft;
            ClassButton.UseVisualStyleBackColor = true;
            ClassButton.Click += ClassButton_Click;
            // 
            // CourseButton
            // 
            CourseButton.Anchor = AnchorStyles.None;
            CourseButton.FlatAppearance.BorderSize = 0;
            CourseButton.FlatStyle = FlatStyle.Flat;
            CourseButton.Font = new Font("Century Gothic", 11F);
            CourseButton.Image = (Image)resources.GetObject("CourseButton.Image");
            CourseButton.ImageAlign = ContentAlignment.MiddleLeft;
            CourseButton.Location = new Point(13, 392);
            CourseButton.Name = "CourseButton";
            CourseButton.Size = new Size(220, 40);
            CourseButton.TabIndex = 4;
            CourseButton.Text = "                Course";
            CourseButton.TextAlign = ContentAlignment.MiddleLeft;
            CourseButton.UseVisualStyleBackColor = true;
            CourseButton.Click += CourseButton_Click;
            // 
            // AttendanceButton
            // 
            AttendanceButton.Anchor = AnchorStyles.None;
            AttendanceButton.FlatAppearance.BorderSize = 0;
            AttendanceButton.FlatStyle = FlatStyle.Flat;
            AttendanceButton.Font = new Font("Century Gothic", 11F);
            AttendanceButton.Image = (Image)resources.GetObject("AttendanceButton.Image");
            AttendanceButton.ImageAlign = ContentAlignment.MiddleLeft;
            AttendanceButton.Location = new Point(13, 342);
            AttendanceButton.Name = "AttendanceButton";
            AttendanceButton.Size = new Size(220, 40);
            AttendanceButton.TabIndex = 3;
            AttendanceButton.Text = "                Attendance";
            AttendanceButton.TextAlign = ContentAlignment.MiddleLeft;
            AttendanceButton.UseVisualStyleBackColor = true;
            AttendanceButton.Click += AttendanceButton_Click;
            // 
            // StudentButton
            // 
            StudentButton.Anchor = AnchorStyles.None;
            StudentButton.BackgroundImageLayout = ImageLayout.Zoom;
            StudentButton.FlatAppearance.BorderSize = 0;
            StudentButton.FlatStyle = FlatStyle.Flat;
            StudentButton.Font = new Font("Century Gothic", 11F);
            StudentButton.Image = (Image)resources.GetObject("StudentButton.Image");
            StudentButton.ImageAlign = ContentAlignment.MiddleLeft;
            StudentButton.Location = new Point(13, 292);
            StudentButton.Name = "StudentButton";
            StudentButton.Size = new Size(220, 40);
            StudentButton.TabIndex = 2;
            StudentButton.Text = "                Student";
            StudentButton.TextAlign = ContentAlignment.MiddleLeft;
            StudentButton.UseVisualStyleBackColor = true;
            StudentButton.Click += StudentButton_Click;
            // 
            // DashboardButton
            // 
            DashboardButton.Anchor = AnchorStyles.None;
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Century Gothic", 11F);
            DashboardButton.Image = (Image)resources.GetObject("DashboardButton.Image");
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(13, 242);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Size = new Size(220, 40);
            DashboardButton.TabIndex = 1;
            DashboardButton.Text = "                Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.UseVisualStyleBackColor = true;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // dashboardSmallpanel
            // 
            dashboardSmallpanel.Anchor = AnchorStyles.None;
            dashboardSmallpanel.Controls.Add(dashboardTitle);
            dashboardSmallpanel.Controls.Add(dashboardPictureBox);
            dashboardSmallpanel.Location = new Point(0, 0);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(274, 224);
            dashboardSmallpanel.TabIndex = 0;
            // 
            // dashboardTitle
            // 
            dashboardTitle.Anchor = AnchorStyles.None;
            dashboardTitle.BackColor = Color.Transparent;
            dashboardTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.Location = new Point(13, 124);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(261, 67);
            dashboardTitle.TabIndex = 1;
            dashboardTitle.Text = "Student Attendance Management System";
            dashboardTitle.Click += dashboardTitle_Click;
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.None;
            dashboardPictureBox.Image = (Image)resources.GetObject("dashboardPictureBox.Image");
            dashboardPictureBox.Location = new Point(100, 42);
            dashboardPictureBox.Name = "dashboardPictureBox";
            dashboardPictureBox.Size = new Size(64, 64);
            dashboardPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            dashboardPictureBox.TabIndex = 0;
            dashboardPictureBox.TabStop = false;
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Window;
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Controls.Add(panelTop);
            panelBack.Location = new Point(274, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1628, 224);
            panelBack.TabIndex = 1;
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
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(188, 234, 213);
            panelTop.Controls.Add(panelExpand);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 98);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1628, 126);
            panelTop.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(188, 234, 213);
            panelExpand.Controls.Add(logoutButton);
            panelExpand.Controls.Add(minimizePanel);
            panelExpand.Location = new Point(1326, 0);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 125);
            panelExpand.TabIndex = 0;
            // 
            // logoutButton
            // 
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutButton.Location = new Point(0, 59);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(200, 67);
            logoutButton.TabIndex = 1;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // minimizePanel
            // 
            minimizePanel.Anchor = AnchorStyles.Top;
            minimizePanel.Controls.Add(minimizeButton);
            minimizePanel.Location = new Point(0, -1);
            minimizePanel.Name = "minimizePanel";
            minimizePanel.Size = new Size(200, 63);
            minimizePanel.TabIndex = 0;
            // 
            // minimizeButton
            // 
            minimizeButton.Anchor = AnchorStyles.Top;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            minimizeButton.Location = new Point(0, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Size = new Size(200, 70);
            minimizeButton.TabIndex = 0;
            minimizeButton.Text = "Minimize";
            minimizeButton.UseVisualStyleBackColor = true;
            // 
            // userControlDashboard1
            // 
            userControlDashboard1.AutoSize = true;
            userControlDashboard1.BackColor = SystemColors.Window;
            userControlDashboard1.Location = new Point(274, 225);
            userControlDashboard1.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1761, 767);
            userControlDashboard1.TabIndex = 2;
            userControlDashboard1.Load += userControlDashboard1_Load;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1902, 1033);
            Controls.Add(userControlDashboard1);
            Controls.Add(panelBack);
            Controls.Add(dashboardPanel);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            panelTop.ResumeLayout(false);
            panelExpand.ResumeLayout(false);
            minimizePanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel dashboardPanel;
        private Panel dashboardSmallpanel;
        private Label dashboardTitle;
        private PictureBox dashboardPictureBox;
        private Button DashboardButton;
        private Button StudentButton;
        private Button CourseButton;
        private Button AttendanceButton;
        private Button ClassButton;
        private Button ProfessorButton;
        private Button DepartmentButton;
        private Button ReportButton;
        private Panel panelBack;
        private Panel panelTop;
        private PictureBox logoutPictureBox;
        private PictureBox expandPictureBox;
        private Panel panelExpand;
        private Panel minimizePanel;
        private Button minimizeButton;
        private Button logoutButton;
        private UserControlDashboard userControlDashboard1;
        private Button RegisterButton;
    }
}