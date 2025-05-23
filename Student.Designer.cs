﻿using MySql.Data.MySqlClient;

namespace Student_Attendance_Management_System
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            minimizeButton = new Button();
            archivedButton = new Button();
            logoutButton = new Button();
            panelExpand = new Panel();
            minimizePanel = new Panel();
            logoutPictureBox = new PictureBox();
            panelTop = new Panel();
            panel20 = new Panel();
            ButtonLogout = new Button();
            panelBack = new Panel();
            expandPictureBox = new PictureBox();
            dashboardPanel = new Panel();
            RegisterButton = new Button();
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
            studentLNameLabel = new Label();
            studentIDLabel = new Label();
            studFNameLabel = new Label();
            studentIDTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            studentLNameTextBox = new TextBox();
            panel3 = new Panel();
            studentFNameTextBox = new TextBox();
            panel4 = new Panel();
            studentEmailTextBox = new TextBox();
            panel6 = new Panel();
            programAndYearTextBox = new TextBox();
            genderLabel = new Label();
            programAndYearLabel = new Label();
            dobLabel = new Label();
            emailLabel = new Label();
            addButton = new Button();
            TabControl = new TabControl();
            addStudentTabPage = new TabPage();
            panel5 = new Panel();
            panel14 = new Panel();
            panel15 = new Panel();
            panel16 = new Panel();
            StudentdobdateTimePicker = new DateTimePicker();
            addStudentLabel = new Label();
            maleRadioButton = new RadioButton();
            femaleRadioButton = new RadioButton();
            searchStudentTabPage = new TabPage();
            searchStudentLabel = new Label();
            totalStudOutputLabel = new Label();
            totalStudentslabel = new Label();
            searchPictureBox = new PictureBox();
            SearchdataGridView = new DataGridView();
            label1 = new Label();
            panel7 = new Panel();
            searchTextBox = new TextBox();
            tabPage1 = new TabPage();
            panel11 = new Panel();
            panel17 = new Panel();
            panel18 = new Panel();
            panel19 = new Panel();
            UDdobdateTimePicker = new DateTimePicker();
            deleteStudentbutton = new Button();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            UDStudentLNametextBox = new TextBox();
            updateStudentButton = new Button();
            label3 = new Label();
            label4 = new Label();
            panel8 = new Panel();
            label5 = new Label();
            UDStudentIDtextBox = new TextBox();
            UDStudentEmailtextBox = new TextBox();
            panel9 = new Panel();
            label6 = new Label();
            panel10 = new Panel();
            UDStudentFNametextBox = new TextBox();
            panel12 = new Panel();
            panel13 = new Panel();
            UDProgramYeartextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panelExpand.SuspendLayout();
            minimizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            panelTop.SuspendLayout();
            panel20.SuspendLayout();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            TabControl.SuspendLayout();
            addStudentTabPage.SuspendLayout();
            searchStudentTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).BeginInit();
            tabPage1.SuspendLayout();
            SuspendLayout();
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
            // archivedButton
            // 
            archivedButton.Anchor = AnchorStyles.None;
            archivedButton.FlatAppearance.BorderSize = 0;
            archivedButton.FlatStyle = FlatStyle.Flat;
            archivedButton.Font = new Font("Century Gothic", 11F);
            archivedButton.Image = (Image)resources.GetObject("archivedButton.Image");
            archivedButton.ImageAlign = ContentAlignment.MiddleLeft;
            archivedButton.Location = new Point(37, 1056);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
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
            // panelExpand
            // 
            panelExpand.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelExpand.BackColor = Color.FromArgb(188, 234, 213);
            panelExpand.Controls.Add(logoutButton);
            panelExpand.Controls.Add(minimizePanel);
            panelExpand.Location = new Point(2669, 0);
            panelExpand.Name = "panelExpand";
            panelExpand.Size = new Size(200, 125);
            panelExpand.TabIndex = 0;
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
            panelTop.Controls.Add(panel20);
            panelTop.Controls.Add(panelExpand);
            panelTop.Dock = DockStyle.Bottom;
            panelTop.Location = new Point(0, 98);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1628, 126);
            panelTop.TabIndex = 0;
            // 
            // panel20
            // 
            panel20.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel20.BackColor = Color.FromArgb(188, 234, 213);
            panel20.Controls.Add(ButtonLogout);
            panel20.Location = new Point(1318, 1);
            panel20.Name = "panel20";
            panel20.Size = new Size(200, 125);
            panel20.TabIndex = 1;
            // 
            // ButtonLogout
            // 
            ButtonLogout.Font = new Font("Century Gothic", 10.8F);
            ButtonLogout.Location = new Point(0, -2);
            ButtonLogout.Name = "ButtonLogout";
            ButtonLogout.Size = new Size(200, 67);
            ButtonLogout.TabIndex = 0;
            ButtonLogout.Text = "Logout";
            ButtonLogout.UseVisualStyleBackColor = true;
            ButtonLogout.Click += ButtonLogout_Click;
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
            panelBack.TabIndex = 3;
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
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(RegisterButton);
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
            dashboardPanel.Location = new Point(0, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(274, 1033);
            dashboardPanel.TabIndex = 2;
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
            RegisterButton.TabIndex = 23;
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
            ReportButton.TabIndex = 17;
            ReportButton.Text = "                Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += button1_Click;
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
            professorButton.Location = new Point(13, 492);
            professorButton.Name = "professorButton";
            professorButton.Size = new Size(220, 40);
            professorButton.TabIndex = 15;
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
            classButton.Location = new Point(13, 442);
            classButton.Name = "classButton";
            classButton.Size = new Size(220, 40);
            classButton.TabIndex = 14;
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
            courseButton.Location = new Point(13, 392);
            courseButton.Name = "courseButton";
            courseButton.Size = new Size(220, 40);
            courseButton.TabIndex = 13;
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
            attendanceButton.Location = new Point(13, 342);
            attendanceButton.Name = "attendanceButton";
            attendanceButton.Size = new Size(220, 40);
            attendanceButton.TabIndex = 12;
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
            studentButton.Location = new Point(13, 292);
            studentButton.Name = "studentButton";
            studentButton.Size = new Size(220, 40);
            studentButton.TabIndex = 11;
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
            dashboardButton.Location = new Point(13, 242);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(220, 40);
            dashboardButton.TabIndex = 10;
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
            dashboardSmallpanel.Location = new Point(0, 0);
            dashboardSmallpanel.Name = "dashboardSmallpanel";
            dashboardSmallpanel.Size = new Size(274, 224);
            dashboardSmallpanel.TabIndex = 9;
            dashboardSmallpanel.Paint += dashboardSmallpanel_Paint;
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
            // studentLNameLabel
            // 
            studentLNameLabel.Anchor = AnchorStyles.None;
            studentLNameLabel.AutoSize = true;
            studentLNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLNameLabel.Location = new Point(558, 112);
            studentLNameLabel.Name = "studentLNameLabel";
            studentLNameLabel.Size = new Size(107, 22);
            studentLNameLabel.TabIndex = 4;
            studentLNameLabel.Text = "Last Name:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.Anchor = AnchorStyles.None;
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(180, 116);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(103, 22);
            studentIDLabel.TabIndex = 5;
            studentIDLabel.Text = "Student ID:";
            studentIDLabel.Click += studentIDLabel_Click;
            // 
            // studFNameLabel
            // 
            studFNameLabel.Anchor = AnchorStyles.None;
            studFNameLabel.AutoSize = true;
            studFNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studFNameLabel.Location = new Point(946, 112);
            studFNameLabel.Name = "studFNameLabel";
            studFNameLabel.Size = new Size(106, 22);
            studFNameLabel.TabIndex = 6;
            studFNameLabel.Text = "First Name:";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.Anchor = AnchorStyles.None;
            studentIDTextBox.BackColor = SystemColors.Window;
            studentIDTextBox.BorderStyle = BorderStyle.None;
            studentIDTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDTextBox.Location = new Point(180, 140);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(270, 23);
            studentIDTextBox.TabIndex = 7;
            studentIDTextBox.TextChanged += studentIDTextBox_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(180, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(558, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 10;
            // 
            // studentLNameTextBox
            // 
            studentLNameTextBox.Anchor = AnchorStyles.None;
            studentLNameTextBox.BackColor = SystemColors.Window;
            studentLNameTextBox.BorderStyle = BorderStyle.None;
            studentLNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentLNameTextBox.Location = new Point(558, 140);
            studentLNameTextBox.Name = "studentLNameTextBox";
            studentLNameTextBox.Size = new Size(270, 23);
            studentLNameTextBox.TabIndex = 9;
            studentLNameTextBox.TextChanged += studentLNameTextBox_TextChanged;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(946, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 10;
            // 
            // studentFNameTextBox
            // 
            studentFNameTextBox.Anchor = AnchorStyles.None;
            studentFNameTextBox.BackColor = SystemColors.Window;
            studentFNameTextBox.BorderStyle = BorderStyle.None;
            studentFNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentFNameTextBox.Location = new Point(946, 140);
            studentFNameTextBox.Name = "studentFNameTextBox";
            studentFNameTextBox.Size = new Size(270, 23);
            studentFNameTextBox.TabIndex = 9;
            studentFNameTextBox.TextChanged += studentFNameTextBox_TextChanged;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(946, 365);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 18;
            // 
            // studentEmailTextBox
            // 
            studentEmailTextBox.Anchor = AnchorStyles.None;
            studentEmailTextBox.BackColor = SystemColors.Window;
            studentEmailTextBox.BorderStyle = BorderStyle.None;
            studentEmailTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentEmailTextBox.Location = new Point(946, 336);
            studentEmailTextBox.Name = "studentEmailTextBox";
            studentEmailTextBox.Size = new Size(270, 23);
            studentEmailTextBox.TabIndex = 16;
            studentEmailTextBox.TextChanged += studentEmailTextBox_TextChanged;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(180, 365);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 15;
            // 
            // programAndYearTextBox
            // 
            programAndYearTextBox.Anchor = AnchorStyles.None;
            programAndYearTextBox.BackColor = SystemColors.Window;
            programAndYearTextBox.BorderStyle = BorderStyle.None;
            programAndYearTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            programAndYearTextBox.Location = new Point(180, 336);
            programAndYearTextBox.Name = "programAndYearTextBox";
            programAndYearTextBox.Size = new Size(270, 23);
            programAndYearTextBox.TabIndex = 14;
            programAndYearTextBox.TextChanged += programAndYearTextBox_TextChanged;
            // 
            // genderLabel
            // 
            genderLabel.Anchor = AnchorStyles.None;
            genderLabel.AutoSize = true;
            genderLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            genderLabel.Location = new Point(1262, 106);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(83, 22);
            genderLabel.TabIndex = 13;
            genderLabel.Text = "Gender:";
            genderLabel.Click += genderLabel_Click;
            // 
            // programAndYearLabel
            // 
            programAndYearLabel.Anchor = AnchorStyles.None;
            programAndYearLabel.AutoSize = true;
            programAndYearLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            programAndYearLabel.Location = new Point(180, 312);
            programAndYearLabel.Name = "programAndYearLabel";
            programAndYearLabel.Size = new Size(176, 22);
            programAndYearLabel.TabIndex = 12;
            programAndYearLabel.Text = "Program and Year:";
            // 
            // dobLabel
            // 
            dobLabel.Anchor = AnchorStyles.None;
            dobLabel.AutoSize = true;
            dobLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dobLabel.Location = new Point(558, 308);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new Size(120, 22);
            dobLabel.TabIndex = 11;
            dobLabel.Text = "Date of Birth:";
            // 
            // emailLabel
            // 
            emailLabel.Anchor = AnchorStyles.None;
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(946, 304);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(137, 22);
            emailLabel.TabIndex = 18;
            emailLabel.Text = "Email Address:";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.BackColor = Color.FromArgb(142, 195, 176);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(180, 492);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 40);
            addButton.TabIndex = 21;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(addStudentTabPage);
            TabControl.Controls.Add(searchStudentTabPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(272, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 22;
            // 
            // addStudentTabPage
            // 
            addStudentTabPage.BackColor = SystemColors.Window;
            addStudentTabPage.Controls.Add(panel5);
            addStudentTabPage.Controls.Add(panel14);
            addStudentTabPage.Controls.Add(panel15);
            addStudentTabPage.Controls.Add(panel16);
            addStudentTabPage.Controls.Add(StudentdobdateTimePicker);
            addStudentTabPage.Controls.Add(addStudentLabel);
            addStudentTabPage.Controls.Add(maleRadioButton);
            addStudentTabPage.Controls.Add(femaleRadioButton);
            addStudentTabPage.Controls.Add(studentLNameTextBox);
            addStudentTabPage.Controls.Add(addButton);
            addStudentTabPage.Controls.Add(studentLNameLabel);
            addStudentTabPage.Controls.Add(studentIDLabel);
            addStudentTabPage.Controls.Add(panel4);
            addStudentTabPage.Controls.Add(studFNameLabel);
            addStudentTabPage.Controls.Add(studentIDTextBox);
            addStudentTabPage.Controls.Add(studentEmailTextBox);
            addStudentTabPage.Controls.Add(panel1);
            addStudentTabPage.Controls.Add(emailLabel);
            addStudentTabPage.Controls.Add(panel2);
            addStudentTabPage.Controls.Add(studentFNameTextBox);
            addStudentTabPage.Controls.Add(panel6);
            addStudentTabPage.Controls.Add(panel3);
            addStudentTabPage.Controls.Add(programAndYearTextBox);
            addStudentTabPage.Controls.Add(dobLabel);
            addStudentTabPage.Controls.Add(genderLabel);
            addStudentTabPage.Controls.Add(programAndYearLabel);
            addStudentTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentTabPage.Location = new Point(4, 4);
            addStudentTabPage.Name = "addStudentTabPage";
            addStudentTabPage.Padding = new Padding(3);
            addStudentTabPage.Size = new Size(1624, 726);
            addStudentTabPage.TabIndex = 0;
            addStudentTabPage.Text = "Add Student";
            addStudentTabPage.Click += tabPage1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(796, 340);
            panel5.Name = "panel5";
            panel5.Size = new Size(10, 27);
            panel5.TabIndex = 35;
            // 
            // panel14
            // 
            panel14.BackColor = Color.Transparent;
            panel14.Location = new Point(549, 340);
            panel14.Name = "panel14";
            panel14.Size = new Size(10, 30);
            panel14.TabIndex = 33;
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Location = new Point(558, 365);
            panel15.Name = "panel15";
            panel15.Size = new Size(240, 2);
            panel15.TabIndex = 32;
            // 
            // panel16
            // 
            panel16.BackColor = Color.Transparent;
            panel16.Location = new Point(554, 331);
            panel16.Name = "panel16";
            panel16.Size = new Size(250, 10);
            panel16.TabIndex = 31;
            // 
            // StudentdobdateTimePicker
            // 
            StudentdobdateTimePicker.CalendarTitleForeColor = SystemColors.Window;
            StudentdobdateTimePicker.CalendarTrailingForeColor = SystemColors.Control;
            StudentdobdateTimePicker.CustomFormat = "MM/dd/yyyy";
            StudentdobdateTimePicker.Format = DateTimePickerFormat.Custom;
            StudentdobdateTimePicker.Location = new Point(558, 337);
            StudentdobdateTimePicker.Name = "StudentdobdateTimePicker";
            StudentdobdateTimePicker.Size = new Size(242, 30);
            StudentdobdateTimePicker.TabIndex = 34;
            // 
            // addStudentLabel
            // 
            addStudentLabel.Anchor = AnchorStyles.None;
            addStudentLabel.AutoSize = true;
            addStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            addStudentLabel.Location = new Point(3, 3);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(135, 23);
            addStudentLabel.TabIndex = 22;
            addStudentLabel.Text = "Add Student:";
            // 
            // maleRadioButton
            // 
            maleRadioButton.Anchor = AnchorStyles.None;
            maleRadioButton.AutoSize = true;
            maleRadioButton.Location = new Point(1316, 143);
            maleRadioButton.Name = "maleRadioButton";
            maleRadioButton.Size = new Size(75, 25);
            maleRadioButton.TabIndex = 1;
            maleRadioButton.Text = "Male";
            maleRadioButton.UseVisualStyleBackColor = true;
            maleRadioButton.CheckedChanged += maleRadioButton_CheckedChanged;
            // 
            // femaleRadioButton
            // 
            femaleRadioButton.Anchor = AnchorStyles.None;
            femaleRadioButton.AutoSize = true;
            femaleRadioButton.Checked = true;
            femaleRadioButton.Location = new Point(1316, 174);
            femaleRadioButton.Name = "femaleRadioButton";
            femaleRadioButton.Size = new Size(96, 25);
            femaleRadioButton.TabIndex = 0;
            femaleRadioButton.TabStop = true;
            femaleRadioButton.Text = "Female";
            femaleRadioButton.UseVisualStyleBackColor = true;
            femaleRadioButton.CheckedChanged += femaleRadioButton_CheckedChanged;
            // 
            // searchStudentTabPage
            // 
            searchStudentTabPage.BackColor = SystemColors.Window;
            searchStudentTabPage.Controls.Add(searchStudentLabel);
            searchStudentTabPage.Controls.Add(totalStudOutputLabel);
            searchStudentTabPage.Controls.Add(totalStudentslabel);
            searchStudentTabPage.Controls.Add(searchPictureBox);
            searchStudentTabPage.Controls.Add(SearchdataGridView);
            searchStudentTabPage.Controls.Add(label1);
            searchStudentTabPage.Controls.Add(panel7);
            searchStudentTabPage.Controls.Add(searchTextBox);
            searchStudentTabPage.Location = new Point(4, 4);
            searchStudentTabPage.Name = "searchStudentTabPage";
            searchStudentTabPage.Padding = new Padding(3);
            searchStudentTabPage.Size = new Size(1624, 726);
            searchStudentTabPage.TabIndex = 1;
            searchStudentTabPage.Text = "Search Student";
            // 
            // searchStudentLabel
            // 
            searchStudentLabel.Anchor = AnchorStyles.None;
            searchStudentLabel.AutoSize = true;
            searchStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            searchStudentLabel.Location = new Point(3, 2);
            searchStudentLabel.Name = "searchStudentLabel";
            searchStudentLabel.Size = new Size(161, 23);
            searchStudentLabel.TabIndex = 16;
            searchStudentLabel.Text = "Search Student:";
            // 
            // totalStudOutputLabel
            // 
            totalStudOutputLabel.Anchor = AnchorStyles.None;
            totalStudOutputLabel.AutoSize = true;
            totalStudOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalStudOutputLabel.Location = new Point(1535, 701);
            totalStudOutputLabel.Name = "totalStudOutputLabel";
            totalStudOutputLabel.Size = new Size(33, 21);
            totalStudOutputLabel.TabIndex = 15;
            totalStudOutputLabel.Text = "(?)";
            totalStudOutputLabel.Click += totalStudOutputLabel_Click;
            // 
            // totalStudentslabel
            // 
            totalStudentslabel.Anchor = AnchorStyles.None;
            totalStudentslabel.AutoSize = true;
            totalStudentslabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStudentslabel.Location = new Point(1395, 701);
            totalStudentslabel.Name = "totalStudentslabel";
            totalStudentslabel.Size = new Size(134, 22);
            totalStudentslabel.TabIndex = 14;
            totalStudentslabel.Text = "Total Students:";
            totalStudentslabel.Click += totalStudentsLabel_Click;
            // 
            // searchPictureBox
            // 
            searchPictureBox.Anchor = AnchorStyles.None;
            searchPictureBox.Image = (Image)resources.GetObject("searchPictureBox.Image");
            searchPictureBox.Location = new Point(389, 105);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(24, 24);
            searchPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            searchPictureBox.TabIndex = 13;
            searchPictureBox.TabStop = false;
            searchPictureBox.Click += searchPictureBox_Click;
            // 
            // SearchdataGridView
            // 
            SearchdataGridView.AllowUserToAddRows = false;
            SearchdataGridView.AllowUserToDeleteRows = false;
            SearchdataGridView.AllowUserToResizeColumns = false;
            SearchdataGridView.AllowUserToResizeRows = false;
            SearchdataGridView.Anchor = AnchorStyles.None;
            SearchdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchdataGridView.BackgroundColor = Color.White;
            SearchdataGridView.BorderStyle = BorderStyle.None;
            SearchdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SearchdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchdataGridView.Location = new Point(90, 211);
            SearchdataGridView.Name = "SearchdataGridView";
            SearchdataGridView.ReadOnly = true;
            SearchdataGridView.RowHeadersWidth = 51;
            SearchdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SearchdataGridView.Size = new Size(1421, 456);
            SearchdataGridView.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(143, 77);
            label1.Name = "label1";
            label1.Size = new Size(103, 22);
            label1.TabIndex = 9;
            label1.Text = "Student ID:";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(143, 130);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 11;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.BackColor = SystemColors.Window;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(143, 101);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 23);
            searchTextBox.TabIndex = 10;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Controls.Add(panel11);
            tabPage1.Controls.Add(panel17);
            tabPage1.Controls.Add(panel18);
            tabPage1.Controls.Add(panel19);
            tabPage1.Controls.Add(UDdobdateTimePicker);
            tabPage1.Controls.Add(deleteStudentbutton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(UDStudentLNametextBox);
            tabPage1.Controls.Add(updateStudentButton);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(panel8);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(UDStudentIDtextBox);
            tabPage1.Controls.Add(UDStudentEmailtextBox);
            tabPage1.Controls.Add(panel9);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(UDStudentFNametextBox);
            tabPage1.Controls.Add(panel12);
            tabPage1.Controls.Add(panel13);
            tabPage1.Controls.Add(UDProgramYeartextBox);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1624, 726);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Update and Delete Student";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Location = new Point(793, 337);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 27);
            panel11.TabIndex = 51;
            // 
            // panel17
            // 
            panel17.BackColor = Color.Transparent;
            panel17.Location = new Point(546, 337);
            panel17.Name = "panel17";
            panel17.Size = new Size(10, 30);
            panel17.TabIndex = 49;
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Location = new Point(555, 362);
            panel18.Name = "panel18";
            panel18.Size = new Size(240, 2);
            panel18.TabIndex = 48;
            // 
            // panel19
            // 
            panel19.BackColor = Color.Transparent;
            panel19.Location = new Point(551, 328);
            panel19.Name = "panel19";
            panel19.Size = new Size(250, 10);
            panel19.TabIndex = 47;
            // 
            // UDdobdateTimePicker
            // 
            UDdobdateTimePicker.CalendarTitleForeColor = SystemColors.Window;
            UDdobdateTimePicker.CalendarTrailingForeColor = SystemColors.Control;
            UDdobdateTimePicker.CustomFormat = "MM/dd/yyyy";
            UDdobdateTimePicker.Format = DateTimePickerFormat.Custom;
            UDdobdateTimePicker.Location = new Point(555, 334);
            UDdobdateTimePicker.Name = "UDdobdateTimePicker";
            UDdobdateTimePicker.Size = new Size(242, 30);
            UDdobdateTimePicker.TabIndex = 50;
            // 
            // deleteStudentbutton
            // 
            deleteStudentbutton.BackColor = Color.Red;
            deleteStudentbutton.FlatAppearance.BorderSize = 0;
            deleteStudentbutton.FlatStyle = FlatStyle.Flat;
            deleteStudentbutton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteStudentbutton.Location = new Point(398, 489);
            deleteStudentbutton.Name = "deleteStudentbutton";
            deleteStudentbutton.Size = new Size(150, 40);
            deleteStudentbutton.TabIndex = 46;
            deleteStudentbutton.Text = "Delete";
            deleteStudentbutton.UseVisualStyleBackColor = false;
            deleteStudentbutton.Click += deleteStudentbutton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(142, 195, 176);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(279, 23);
            label2.TabIndex = 45;
            label2.Text = "Update and Delete Student:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(1313, 140);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(75, 25);
            radioButton1.TabIndex = 24;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Checked = true;
            radioButton2.Location = new Point(1313, 171);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 25);
            radioButton2.TabIndex = 23;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // UDStudentLNametextBox
            // 
            UDStudentLNametextBox.BackColor = SystemColors.Window;
            UDStudentLNametextBox.BorderStyle = BorderStyle.None;
            UDStudentLNametextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDStudentLNametextBox.Location = new Point(555, 137);
            UDStudentLNametextBox.Name = "UDStudentLNametextBox";
            UDStudentLNametextBox.Size = new Size(270, 23);
            UDStudentLNametextBox.TabIndex = 30;
            // 
            // updateStudentButton
            // 
            updateStudentButton.BackColor = Color.FromArgb(142, 195, 176);
            updateStudentButton.FlatAppearance.BorderSize = 0;
            updateStudentButton.FlatStyle = FlatStyle.Flat;
            updateStudentButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateStudentButton.Location = new Point(177, 489);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(150, 40);
            updateStudentButton.TabIndex = 44;
            updateStudentButton.Text = "Update";
            updateStudentButton.UseVisualStyleBackColor = false;
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(555, 109);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 25;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(177, 113);
            label4.Name = "label4";
            label4.Size = new Size(103, 22);
            label4.TabIndex = 26;
            label4.Text = "Student ID:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(943, 362);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 2);
            panel8.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(943, 109);
            label5.Name = "label5";
            label5.Size = new Size(106, 22);
            label5.TabIndex = 27;
            label5.Text = "First Name:";
            // 
            // UDStudentIDtextBox
            // 
            UDStudentIDtextBox.BackColor = SystemColors.Window;
            UDStudentIDtextBox.BorderStyle = BorderStyle.None;
            UDStudentIDtextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDStudentIDtextBox.Location = new Point(177, 137);
            UDStudentIDtextBox.Name = "UDStudentIDtextBox";
            UDStudentIDtextBox.Size = new Size(270, 23);
            UDStudentIDtextBox.TabIndex = 28;
            UDStudentIDtextBox.TextChanged += UDStudentIDtextBox_TextChanged;
            // 
            // UDStudentEmailtextBox
            // 
            UDStudentEmailtextBox.BackColor = SystemColors.Window;
            UDStudentEmailtextBox.BorderStyle = BorderStyle.None;
            UDStudentEmailtextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDStudentEmailtextBox.Location = new Point(943, 333);
            UDStudentEmailtextBox.Name = "UDStudentEmailtextBox";
            UDStudentEmailtextBox.Size = new Size(270, 23);
            UDStudentEmailtextBox.TabIndex = 39;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(177, 166);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(943, 301);
            label6.Name = "label6";
            label6.Size = new Size(137, 22);
            label6.TabIndex = 42;
            label6.Text = "Email Address:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(555, 166);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 33;
            // 
            // UDStudentFNametextBox
            // 
            UDStudentFNametextBox.BackColor = SystemColors.Window;
            UDStudentFNametextBox.BorderStyle = BorderStyle.None;
            UDStudentFNametextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDStudentFNametextBox.Location = new Point(943, 137);
            UDStudentFNametextBox.Name = "UDStudentFNametextBox";
            UDStudentFNametextBox.Size = new Size(270, 23);
            UDStudentFNametextBox.TabIndex = 31;
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(177, 362);
            panel12.Name = "panel12";
            panel12.Size = new Size(270, 2);
            panel12.TabIndex = 38;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(943, 166);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 32;
            // 
            // UDProgramYeartextBox
            // 
            UDProgramYeartextBox.BackColor = SystemColors.Window;
            UDProgramYeartextBox.BorderStyle = BorderStyle.None;
            UDProgramYeartextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDProgramYeartextBox.Location = new Point(177, 333);
            UDProgramYeartextBox.Name = "UDProgramYeartextBox";
            UDProgramYeartextBox.Size = new Size(270, 23);
            UDProgramYeartextBox.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(555, 305);
            label7.Name = "label7";
            label7.Size = new Size(120, 22);
            label7.TabIndex = 34;
            label7.Text = "Date of Birth:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(1259, 103);
            label8.Name = "label8";
            label8.Size = new Size(83, 22);
            label8.TabIndex = 36;
            label8.Text = "Gender:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(177, 309);
            label9.Name = "label9";
            label9.Size = new Size(176, 22);
            label9.TabIndex = 35;
            label9.Text = "Program and Year:";
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1902, 1033);
            Controls.Add(TabControl);
            Controls.Add(panelBack);
            Controls.Add(dashboardPanel);
            Name = "Student";
            Text = "Student";
            Load += Student_Load;
            panelExpand.ResumeLayout(false);
            minimizePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            panelTop.ResumeLayout(false);
            panel20.ResumeLayout(false);
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            TabControl.ResumeLayout(false);
            addStudentTabPage.ResumeLayout(false);
            addStudentTabPage.PerformLayout();
            searchStudentTabPage.ResumeLayout(false);
            searchStudentTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button minimizeButton;
        private Button archivedButton;
        private Button logoutButton;
        private Panel panelExpand;
        private Panel minimizePanel;
        private PictureBox logoutPictureBox;
        private Panel panelTop;
        private Panel panelBack;
        private PictureBox expandPictureBox;
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
        private Label studentLNameLabel;
        private Label studentIDLabel;
        private Label studFNameLabel;
        private TextBox studentIDTextBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox studentLNameTextBox;
        private Panel panel3;
        private TextBox studentFNameTextBox;
        private Panel panel4;
        private TextBox studentEmailTextBox;
        private Panel panel6;
        private TextBox programAndYearTextBox;
        private Label genderLabel;
        private Label programAndYearLabel;
        private Label dobLabel;
        private Label emailLabel;
        private Button addButton;
        private TabControl TabControl;
        private TabPage addStudentTabPage;
        private TabPage searchStudentTabPage;
        private RadioButton maleRadioButton;
        private RadioButton femaleRadioButton;
        private TabPage tabPage1;
        private Label label1;
        private TextBox searchTextBox;
        private Panel panel7;
        private DataGridView SearchdataGridView;
        private PictureBox searchPictureBox;
        private Label totalStudentslabel;
        private Label totalStudOutputLabel;
        private Label searchStudentLabel;
        private Label addStudentLabel;
        private Button deleteStudentbutton;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private TextBox UDStudentLNametextBox;
        private Button updateStudentButton;
        private Label label3;
        private Label label4;
        private Panel panel8;
        private Label label5;
        private TextBox UDStudentIDtextBox;
        private TextBox UDStudentEmailtextBox;
        private Panel panel9;
        private Label label6;
        private Panel panel10;
        private TextBox UDStudentFNametextBox;
        private Panel panel12;
        private Panel panel13;
        private TextBox UDProgramYeartextBox;
        private Label label7;
        private Label label8;
        private Label label9;
        private Panel panel5;
        private Panel panel14;
        private Panel panel15;
        private Panel panel16;
        private DateTimePicker StudentdobdateTimePicker;
        private Panel panel11;
        private Panel panel17;
        private Panel panel18;
        private Panel panel19;
        private DateTimePicker UDdobdateTimePicker;
        private Button RegisterButton;
        private Panel panel20;
        private Button ButtonLogout;
    }
}