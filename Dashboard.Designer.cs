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
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(departmentButton);
            dashboardPanel.Controls.Add(professorButton);
            dashboardPanel.Controls.Add(classButton);
            dashboardPanel.Controls.Add(courseButton);
            dashboardPanel.Controls.Add(attendanceButton);
            dashboardPanel.Controls.Add(studentButton);
            dashboardPanel.Controls.Add(dashboardButton);
            dashboardPanel.Controls.Add(dashboardSmallpanel);
            dashboardPanel.Location = new Point(-1, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(330, 1033);
            dashboardPanel.TabIndex = 0;
            // 
            // ReportButton
            // 
            ReportButton.Anchor = AnchorStyles.None;
            ReportButton.FlatAppearance.BorderSize = 0;
            ReportButton.FlatStyle = FlatStyle.Flat;
            ReportButton.Font = new Font("Century Gothic", 11F);
            ReportButton.Image = (Image)resources.GetObject("ReportButton.Image");
            ReportButton.ImageAlign = ContentAlignment.MiddleLeft;
            ReportButton.Location = new Point(0, 592);
            ReportButton.Name = "ReportButton";
            ReportButton.Size = new Size(220, 40);
            ReportButton.TabIndex = 8;
            ReportButton.Text = "                Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += archivedButton_Click;
            // 
            // departmentButton
            // 
            departmentButton.Anchor = AnchorStyles.None;
            departmentButton.FlatAppearance.BorderSize = 0;
            departmentButton.FlatStyle = FlatStyle.Flat;
            departmentButton.Font = new Font("Century Gothic", 11F);
            departmentButton.Image = (Image)resources.GetObject("departmentButton.Image");
            departmentButton.ImageAlign = ContentAlignment.MiddleLeft;
            departmentButton.Location = new Point(0, 542);
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
            professorButton.Location = new Point(0, 492);
            professorButton.Name = "professorButton";
            professorButton.Size = new Size(220, 40);
            professorButton.TabIndex = 6;
            professorButton.Text = "                Professor";
            professorButton.TextAlign = ContentAlignment.MiddleLeft;
            professorButton.UseVisualStyleBackColor = true;
            professorButton.Click += professorButton_Click;
            // 
            // classButton
            // 
            classButton.Anchor = AnchorStyles.None;
            classButton.FlatAppearance.BorderSize = 0;
            classButton.FlatStyle = FlatStyle.Flat;
            classButton.Font = new Font("Century Gothic", 11F);
            classButton.Image = (Image)resources.GetObject("classButton.Image");
            classButton.ImageAlign = ContentAlignment.MiddleLeft;
            classButton.Location = new Point(0, 442);
            classButton.Name = "classButton";
            classButton.Size = new Size(220, 40);
            classButton.TabIndex = 5;
            classButton.Text = "                Class";
            classButton.TextAlign = ContentAlignment.MiddleLeft;
            classButton.UseVisualStyleBackColor = true;
            classButton.Click += classButton_Click;
            // 
            // courseButton
            // 
            courseButton.Anchor = AnchorStyles.None;
            courseButton.FlatAppearance.BorderSize = 0;
            courseButton.FlatStyle = FlatStyle.Flat;
            courseButton.Font = new Font("Century Gothic", 11F);
            courseButton.Image = (Image)resources.GetObject("courseButton.Image");
            courseButton.ImageAlign = ContentAlignment.MiddleLeft;
            courseButton.Location = new Point(0, 392);
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
            attendanceButton.Location = new Point(0, 342);
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
            studentButton.Location = new Point(0, 292);
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
            dashboardButton.Location = new Point(0, 242);
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
            dashboardSmallpanel.Location = new Point(-8, 0);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(365, 224);
            dashboardSmallpanel.TabIndex = 0;
            // 
            // dashboardTitle
            // 
            dashboardTitle.Anchor = AnchorStyles.None;
            dashboardTitle.BackColor = Color.Transparent;
            dashboardTitle.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardTitle.Location = new Point(34, 129);
            dashboardTitle.Name = "dashboardTitle";
            dashboardTitle.Size = new Size(286, 67);
            dashboardTitle.TabIndex = 1;
            dashboardTitle.Text = "Student Attendance Management System";
            dashboardTitle.Click += dashboardTitle_Click;
            // 
            // dashboardPictureBox
            // 
            dashboardPictureBox.Anchor = AnchorStyles.None;
            dashboardPictureBox.Image = (Image)resources.GetObject("dashboardPictureBox.Image");
            dashboardPictureBox.Location = new Point(123, 48);
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
            panelBack.Location = new Point(328, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1572, 221);
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
            panelTop.Location = new Point(0, 95);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1572, 126);
            panelTop.TabIndex = 0;
            // 
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(188, 234, 213);
            panelExpand.Controls.Add(logoutButton);
            panelExpand.Controls.Add(minimizePanel);
            panelExpand.Location = new Point(1270, 0);
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
            userControlDashboard1.Location = new Point(328, 220);
            userControlDashboard1.Margin = new Padding(4, 3, 4, 3);
            userControlDashboard1.Name = "userControlDashboard1";
            userControlDashboard1.Size = new Size(1707, 734);
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
        private Button dashboardButton;
        private Button studentButton;
        private Button courseButton;
        private Button attendanceButton;
        private Button classButton;
        private Button professorButton;
        private Button departmentButton;
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
    }
}