﻿namespace Student_Attendance_Management_System
{
    partial class Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor));
            searchStudentLabel = new Label();
            totalStudentslabel = new Label();
            searchPictureBox = new PictureBox();
            SearchdataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ProfessorLabel = new Label();
            panel7 = new Panel();
            addStudentTabPage = new TabPage();
            addStudentLabel = new Label();
            studentLNameTextBox = new TextBox();
            addButton = new Button();
            studentLNameLabel = new Label();
            studentIDLabel = new Label();
            studFNameLabel = new Label();
            studentIDTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            studentFNameTextBox = new TextBox();
            panel3 = new Panel();
            searchTextBox = new TextBox();
            deleteStudentbutton = new Button();
            label2 = new Label();
            updateStudentButton = new Button();
            panelBack = new Panel();
            panel14 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            totalStudOutputLabel = new Label();
            SearchProfessorTabPage = new TabPage();
            tabPage1 = new TabPage();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            panel6 = new Panel();
            panel4 = new Panel();
            textBox3 = new TextBox();
            panel5 = new Panel();
            dashboardPanel = new Panel();
            ReportButton = new Button();
            button2 = new Button();
            button1 = new Button();
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
            TabControl = new TabControl();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).BeginInit();
            addStudentTabPage.SuspendLayout();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            SearchProfessorTabPage.SuspendLayout();
            tabPage1.SuspendLayout();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            TabControl.SuspendLayout();
            SuspendLayout();
            // 
            // searchStudentLabel
            // 
            searchStudentLabel.AutoSize = true;
            searchStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            searchStudentLabel.Location = new Point(9, 8);
            searchStudentLabel.Name = "searchStudentLabel";
            searchStudentLabel.Size = new Size(219, 23);
            searchStudentLabel.TabIndex = 16;
            searchStudentLabel.Text = "Search Course Code:";
            // 
            // totalStudentslabel
            // 
            totalStudentslabel.AutoSize = true;
            totalStudentslabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStudentslabel.Location = new Point(1271, 687);
            totalStudentslabel.Name = "totalStudentslabel";
            totalStudentslabel.Size = new Size(124, 22);
            totalStudentslabel.TabIndex = 14;
            totalStudentslabel.Text = "Total Course:";
            // 
            // searchPictureBox
            // 
            searchPictureBox.Image = (Image)resources.GetObject("searchPictureBox.Image");
            searchPictureBox.Location = new Point(545, 101);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(24, 24);
            searchPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            searchPictureBox.TabIndex = 13;
            searchPictureBox.TabStop = false;
            // 
            // SearchdataGridView
            // 
            SearchdataGridView.AllowUserToAddRows = false;
            SearchdataGridView.AllowUserToDeleteRows = false;
            SearchdataGridView.AllowUserToResizeColumns = false;
            SearchdataGridView.AllowUserToResizeRows = false;
            SearchdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SearchdataGridView.BackgroundColor = Color.White;
            SearchdataGridView.BorderStyle = BorderStyle.None;
            SearchdataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            SearchdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SearchdataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            SearchdataGridView.Location = new Point(63, 211);
            SearchdataGridView.Name = "SearchdataGridView";
            SearchdataGridView.ReadOnly = true;
            SearchdataGridView.RowHeadersWidth = 51;
            SearchdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SearchdataGridView.Size = new Size(1421, 456);
            SearchdataGridView.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.HeaderText = "Professor ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Last Name";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "First Name";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Email";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // ProfessorLabel
            // 
            ProfessorLabel.AutoSize = true;
            ProfessorLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProfessorLabel.Location = new Point(299, 73);
            ProfessorLabel.Name = "ProfessorLabel";
            ProfessorLabel.Size = new Size(94, 22);
            ProfessorLabel.TabIndex = 9;
            ProfessorLabel.Text = "Professor:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(293, 120);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 11;
            // 
            // addStudentTabPage
            // 
            addStudentTabPage.BackColor = SystemColors.Window;
            addStudentTabPage.Controls.Add(addStudentLabel);
            addStudentTabPage.Controls.Add(studentLNameTextBox);
            addStudentTabPage.Controls.Add(addButton);
            addStudentTabPage.Controls.Add(studentLNameLabel);
            addStudentTabPage.Controls.Add(studentIDLabel);
            addStudentTabPage.Controls.Add(studFNameLabel);
            addStudentTabPage.Controls.Add(studentIDTextBox);
            addStudentTabPage.Controls.Add(panel1);
            addStudentTabPage.Controls.Add(panel2);
            addStudentTabPage.Controls.Add(studentFNameTextBox);
            addStudentTabPage.Controls.Add(panel3);
            addStudentTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentTabPage.Location = new Point(4, 4);
            addStudentTabPage.Name = "addStudentTabPage";
            addStudentTabPage.Padding = new Padding(3);
            addStudentTabPage.Size = new Size(1624, 726);
            addStudentTabPage.TabIndex = 0;
            addStudentTabPage.Text = "Add Professor";
            addStudentTabPage.Click += addStudentTabPage_Click;
            // 
            // addStudentLabel
            // 
            addStudentLabel.AutoSize = true;
            addStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            addStudentLabel.Location = new Point(9, 9);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(149, 23);
            addStudentLabel.TabIndex = 22;
            addStudentLabel.Text = "Add Professor:";
            // 
            // studentLNameTextBox
            // 
            studentLNameTextBox.BackColor = SystemColors.Window;
            studentLNameTextBox.BorderStyle = BorderStyle.None;
            studentLNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentLNameTextBox.Location = new Point(558, 140);
            studentLNameTextBox.Name = "studentLNameTextBox";
            studentLNameTextBox.Size = new Size(270, 23);
            studentLNameTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(142, 195, 176);
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(180, 246);
            addButton.Name = "addButton";
            addButton.Size = new Size(150, 40);
            addButton.TabIndex = 21;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            // 
            // studentLNameLabel
            // 
            studentLNameLabel.AutoSize = true;
            studentLNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLNameLabel.Location = new Point(564, 118);
            studentLNameLabel.Name = "studentLNameLabel";
            studentLNameLabel.Size = new Size(106, 22);
            studentLNameLabel.TabIndex = 4;
            studentLNameLabel.Text = "First Name:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(180, 122);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(107, 22);
            studentIDLabel.TabIndex = 5;
            studentIDLabel.Text = "Last Name:";
            // 
            // studFNameLabel
            // 
            studFNameLabel.AutoSize = true;
            studFNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studFNameLabel.Location = new Point(952, 118);
            studFNameLabel.Name = "studFNameLabel";
            studFNameLabel.Size = new Size(132, 22);
            studFNameLabel.TabIndex = 6;
            studFNameLabel.Text = "Email Address";
            // 
            // studentIDTextBox
            // 
            studentIDTextBox.BackColor = SystemColors.Window;
            studentIDTextBox.BorderStyle = BorderStyle.None;
            studentIDTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentIDTextBox.Location = new Point(180, 140);
            studentIDTextBox.Name = "studentIDTextBox";
            studentIDTextBox.Size = new Size(270, 23);
            studentIDTextBox.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(180, 169);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 2);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(558, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(270, 2);
            panel2.TabIndex = 10;
            // 
            // studentFNameTextBox
            // 
            studentFNameTextBox.BackColor = SystemColors.Window;
            studentFNameTextBox.BorderStyle = BorderStyle.None;
            studentFNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentFNameTextBox.Location = new Point(946, 140);
            studentFNameTextBox.Name = "studentFNameTextBox";
            studentFNameTextBox.Size = new Size(270, 23);
            studentFNameTextBox.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(946, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 10;
            // 
            // searchTextBox
            // 
            searchTextBox.BackColor = SystemColors.Window;
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(293, 91);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(270, 23);
            searchTextBox.TabIndex = 10;
            // 
            // deleteStudentbutton
            // 
            deleteStudentbutton.BackColor = Color.Red;
            deleteStudentbutton.FlatAppearance.BorderSize = 0;
            deleteStudentbutton.FlatStyle = FlatStyle.Flat;
            deleteStudentbutton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteStudentbutton.Location = new Point(401, 256);
            deleteStudentbutton.Name = "deleteStudentbutton";
            deleteStudentbutton.Size = new Size(150, 40);
            deleteStudentbutton.TabIndex = 46;
            deleteStudentbutton.Text = "Delete";
            deleteStudentbutton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(142, 195, 176);
            label2.Location = new Point(6, 6);
            label2.Name = "label2";
            label2.Size = new Size(287, 23);
            label2.TabIndex = 45;
            label2.Text = "Update and Delete Professor";
            // 
            // updateStudentButton
            // 
            updateStudentButton.BackColor = Color.FromArgb(142, 195, 176);
            updateStudentButton.FlatAppearance.BorderSize = 0;
            updateStudentButton.FlatStyle = FlatStyle.Flat;
            updateStudentButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateStudentButton.Location = new Point(180, 256);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(150, 40);
            updateStudentButton.TabIndex = 44;
            updateStudentButton.Text = "Update";
            updateStudentButton.UseVisualStyleBackColor = false;
            // 
            // panelBack
            // 
            panelBack.BackColor = SystemColors.Window;
            panelBack.Controls.Add(panel14);
            panelBack.Controls.Add(expandPictureBox);
            panelBack.Controls.Add(logoutPictureBox);
            panelBack.Location = new Point(274, 0);
            panelBack.Name = "panelBack";
            panelBack.Size = new Size(1628, 224);
            panelBack.TabIndex = 28;
            // 
            // panel14
            // 
            panel14.BackColor = Color.FromArgb(188, 234, 213);
            panel14.Location = new Point(0, 98);
            panel14.Name = "panel14";
            panel14.Size = new Size(1628, 126);
            panel14.TabIndex = 3;
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
            // totalStudOutputLabel
            // 
            totalStudOutputLabel.AutoSize = true;
            totalStudOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalStudOutputLabel.Location = new Point(1411, 687);
            totalStudOutputLabel.Name = "totalStudOutputLabel";
            totalStudOutputLabel.Size = new Size(33, 21);
            totalStudOutputLabel.TabIndex = 15;
            totalStudOutputLabel.Text = "(?)";
            // 
            // SearchProfessorTabPage
            // 
            SearchProfessorTabPage.BackColor = SystemColors.Window;
            SearchProfessorTabPage.Controls.Add(searchStudentLabel);
            SearchProfessorTabPage.Controls.Add(totalStudOutputLabel);
            SearchProfessorTabPage.Controls.Add(totalStudentslabel);
            SearchProfessorTabPage.Controls.Add(searchPictureBox);
            SearchProfessorTabPage.Controls.Add(SearchdataGridView);
            SearchProfessorTabPage.Controls.Add(ProfessorLabel);
            SearchProfessorTabPage.Controls.Add(panel7);
            SearchProfessorTabPage.Controls.Add(searchTextBox);
            SearchProfessorTabPage.Location = new Point(4, 4);
            SearchProfessorTabPage.Name = "SearchProfessorTabPage";
            SearchProfessorTabPage.Padding = new Padding(3);
            SearchProfessorTabPage.Size = new Size(1624, 726);
            SearchProfessorTabPage.TabIndex = 1;
            SearchProfessorTabPage.Text = "Search Professor";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(deleteStudentbutton);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(updateStudentButton);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Controls.Add(panel6);
            tabPage1.Controls.Add(panel4);
            tabPage1.Controls.Add(textBox3);
            tabPage1.Controls.Add(panel5);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1624, 726);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Update and Delete Professor";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Window;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(565, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(270, 23);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(571, 127);
            label1.Name = "label1";
            label1.Size = new Size(106, 22);
            label1.TabIndex = 29;
            label1.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(180, 127);
            label3.Name = "label3";
            label3.Size = new Size(107, 22);
            label3.TabIndex = 30;
            label3.Text = "Last Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(959, 127);
            label4.Name = "label4";
            label4.Size = new Size(132, 22);
            label4.TabIndex = 31;
            label4.Text = "Email Address";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Window;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(180, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 23);
            textBox2.TabIndex = 32;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(953, 178);
            panel6.Name = "panel6";
            panel6.Size = new Size(270, 2);
            panel6.TabIndex = 37;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(180, 174);
            panel4.Name = "panel4";
            panel4.Size = new Size(270, 2);
            panel4.TabIndex = 33;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.Window;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(953, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(270, 23);
            textBox3.TabIndex = 35;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(565, 178);
            panel5.Name = "panel5";
            panel5.Size = new Size(270, 2);
            panel5.TabIndex = 36;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(ReportButton);
            dashboardPanel.Controls.Add(button2);
            dashboardPanel.Controls.Add(button1);
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
            dashboardPanel.TabIndex = 26;
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
            ReportButton.TabIndex = 23;
            ReportButton.Text = "                Report";
            ReportButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportButton.UseVisualStyleBackColor = true;
            ReportButton.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11F);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(48, 1066);
            button2.Name = "button2";
            button2.Size = new Size(220, 40);
            button2.TabIndex = 18;
            button2.Text = "                Archived";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(102, 1524);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 17;
            button1.Text = "                Archived";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
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
            archivedButton.Location = new Point(167, 1988);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(addStudentTabPage);
            TabControl.Controls.Add(SearchProfessorTabPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(272, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 27;
            // 
            // Professor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelBack);
            Controls.Add(dashboardPanel);
            Controls.Add(TabControl);
            Name = "Professor";
            Text = "Professor";
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).EndInit();
            addStudentTabPage.ResumeLayout(false);
            addStudentTabPage.PerformLayout();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            SearchProfessorTabPage.ResumeLayout(false);
            SearchProfessorTabPage.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            TabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label searchStudentLabel;
        private Label totalStudentslabel;
        private PictureBox searchPictureBox;
        private DataGridView SearchdataGridView;
        private Label ProfessorLabel;
        private Panel panel7;
        private TabPage addStudentTabPage;
        private Label addStudentLabel;
        private TextBox studentLNameTextBox;
        private Button addButton;
        private Label studentLNameLabel;
        private Label studentIDLabel;
        private Label studFNameLabel;
        private TextBox studentIDTextBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox studentFNameTextBox;
        private Panel panel3;
        private TextBox searchTextBox;
        private Button deleteStudentbutton;
        private Label label2;
        private Button updateStudentButton;
        private Panel panelBack;
        private Panel panel14;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Label totalStudOutputLabel;
        private TabPage SearchProfessorTabPage;
        private TabPage tabPage1;
        private Panel dashboardPanel;
        private Button button2;
        private Button button1;
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
        private TabControl TabControl;
        private Button ReportButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private Panel panel6;
        private Panel panel4;
        private TextBox textBox3;
        private Panel panel5;
    }
}