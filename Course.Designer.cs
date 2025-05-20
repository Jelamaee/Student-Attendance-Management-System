namespace Student_Attendance_Management_System
{
    partial class Course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Course));
            TabControl = new TabControl();
            addCourseTabPage = new TabPage();
            addStudentLabel = new Label();
            courseNameTextBox = new TextBox();
            addButton = new Button();
            studentLNameLabel = new Label();
            studentIDLabel = new Label();
            studFNameLabel = new Label();
            courseCodeTextBox = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            creditHoursTextBox = new TextBox();
            panel3 = new Panel();
            searchCourseTabPage = new TabPage();
            searchStudentLabel = new Label();
            TotalCourseOutputLabel = new Label();
            totalStudentslabel = new Label();
            searchPictureBox = new PictureBox();
            SearchdataGridView = new DataGridView();
            label1 = new Label();
            panel7 = new Panel();
            searchTextBox = new TextBox();
            tabPage1 = new TabPage();
            DeleteCourseButton = new Button();
            label2 = new Label();
            UDCourseNameTextBox = new TextBox();
            UpdateCourseButton = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            UDCourseIDTextBox = new TextBox();
            panel9 = new Panel();
            panel10 = new Panel();
            UDCreditHoursTextBox = new TextBox();
            panel13 = new Panel();
            panelBack = new Panel();
            panel14 = new Panel();
            expandPictureBox = new PictureBox();
            logoutPictureBox = new PictureBox();
            dashboardPanel = new Panel();
            ReportsButton = new Button();
            button1 = new Button();
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
            TabControl.SuspendLayout();
            addCourseTabPage.SuspendLayout();
            searchCourseTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).BeginInit();
            tabPage1.SuspendLayout();
            panelBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).BeginInit();
            dashboardPanel.SuspendLayout();
            dashboardSmallpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Alignment = TabAlignment.Bottom;
            TabControl.Controls.Add(addCourseTabPage);
            TabControl.Controls.Add(searchCourseTabPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabControl.ImeMode = ImeMode.NoControl;
            TabControl.Location = new Point(272, 220);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1632, 760);
            TabControl.TabIndex = 23;
            // 
            // addCourseTabPage
            // 
            addCourseTabPage.BackColor = SystemColors.Window;
            addCourseTabPage.Controls.Add(addStudentLabel);
            addCourseTabPage.Controls.Add(courseNameTextBox);
            addCourseTabPage.Controls.Add(addButton);
            addCourseTabPage.Controls.Add(studentLNameLabel);
            addCourseTabPage.Controls.Add(studentIDLabel);
            addCourseTabPage.Controls.Add(studFNameLabel);
            addCourseTabPage.Controls.Add(courseCodeTextBox);
            addCourseTabPage.Controls.Add(panel1);
            addCourseTabPage.Controls.Add(panel2);
            addCourseTabPage.Controls.Add(creditHoursTextBox);
            addCourseTabPage.Controls.Add(panel3);
            addCourseTabPage.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addCourseTabPage.Location = new Point(4, 4);
            addCourseTabPage.Name = "addCourseTabPage";
            addCourseTabPage.Padding = new Padding(3);
            addCourseTabPage.Size = new Size(1624, 726);
            addCourseTabPage.TabIndex = 0;
            addCourseTabPage.Text = "Add Course";
            // 
            // addStudentLabel
            // 
            addStudentLabel.AutoSize = true;
            addStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            addStudentLabel.Location = new Point(6, 6);
            addStudentLabel.Name = "addStudentLabel";
            addStudentLabel.Size = new Size(132, 23);
            addStudentLabel.TabIndex = 22;
            addStudentLabel.Text = "Add Course:";
            // 
            // courseNameTextBox
            // 
            courseNameTextBox.BackColor = SystemColors.Window;
            courseNameTextBox.BorderStyle = BorderStyle.None;
            courseNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseNameTextBox.Location = new Point(558, 140);
            courseNameTextBox.Name = "courseNameTextBox";
            courseNameTextBox.Size = new Size(270, 23);
            courseNameTextBox.TabIndex = 9;
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
            addButton.Click += addButton_Click;
            // 
            // studentLNameLabel
            // 
            studentLNameLabel.AutoSize = true;
            studentLNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentLNameLabel.Location = new Point(561, 115);
            studentLNameLabel.Name = "studentLNameLabel";
            studentLNameLabel.Size = new Size(137, 22);
            studentLNameLabel.TabIndex = 4;
            studentLNameLabel.Text = "Course Name:";
            // 
            // studentIDLabel
            // 
            studentIDLabel.AutoSize = true;
            studentIDLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentIDLabel.Location = new Point(183, 119);
            studentIDLabel.Name = "studentIDLabel";
            studentIDLabel.Size = new Size(133, 22);
            studentIDLabel.TabIndex = 5;
            studentIDLabel.Text = "Course Code:";
            // 
            // studFNameLabel
            // 
            studFNameLabel.AutoSize = true;
            studFNameLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studFNameLabel.Location = new Point(949, 115);
            studFNameLabel.Name = "studFNameLabel";
            studFNameLabel.Size = new Size(122, 22);
            studFNameLabel.TabIndex = 6;
            studFNameLabel.Text = "Credit Hours:";
            // 
            // courseCodeTextBox
            // 
            courseCodeTextBox.AcceptsReturn = true;
            courseCodeTextBox.BackColor = SystemColors.Window;
            courseCodeTextBox.BorderStyle = BorderStyle.None;
            courseCodeTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseCodeTextBox.Location = new Point(180, 140);
            courseCodeTextBox.Name = "courseCodeTextBox";
            courseCodeTextBox.Size = new Size(270, 23);
            courseCodeTextBox.TabIndex = 7;
            courseCodeTextBox.TextChanged += studentIDTextBox_TextChanged;
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
            // creditHoursTextBox
            // 
            creditHoursTextBox.BackColor = SystemColors.Window;
            creditHoursTextBox.BorderStyle = BorderStyle.None;
            creditHoursTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            creditHoursTextBox.Location = new Point(946, 140);
            creditHoursTextBox.Name = "creditHoursTextBox";
            creditHoursTextBox.Size = new Size(270, 23);
            creditHoursTextBox.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(946, 169);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 2);
            panel3.TabIndex = 10;
            // 
            // searchCourseTabPage
            // 
            searchCourseTabPage.BackColor = SystemColors.Window;
            searchCourseTabPage.Controls.Add(searchStudentLabel);
            searchCourseTabPage.Controls.Add(TotalCourseOutputLabel);
            searchCourseTabPage.Controls.Add(totalStudentslabel);
            searchCourseTabPage.Controls.Add(searchPictureBox);
            searchCourseTabPage.Controls.Add(SearchdataGridView);
            searchCourseTabPage.Controls.Add(label1);
            searchCourseTabPage.Controls.Add(panel7);
            searchCourseTabPage.Controls.Add(searchTextBox);
            searchCourseTabPage.Location = new Point(4, 4);
            searchCourseTabPage.Name = "searchCourseTabPage";
            searchCourseTabPage.Padding = new Padding(3);
            searchCourseTabPage.Size = new Size(1624, 726);
            searchCourseTabPage.TabIndex = 1;
            searchCourseTabPage.Text = "Search Course";
            // 
            // searchStudentLabel
            // 
            searchStudentLabel.AutoSize = true;
            searchStudentLabel.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchStudentLabel.ForeColor = Color.FromArgb(142, 195, 176);
            searchStudentLabel.Location = new Point(6, 5);
            searchStudentLabel.Name = "searchStudentLabel";
            searchStudentLabel.Size = new Size(219, 23);
            searchStudentLabel.TabIndex = 16;
            searchStudentLabel.Text = "Search Course Code:";
            // 
            // TotalCourseOutputLabel
            // 
            TotalCourseOutputLabel.AutoSize = true;
            TotalCourseOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalCourseOutputLabel.Location = new Point(1408, 684);
            TotalCourseOutputLabel.Name = "TotalCourseOutputLabel";
            TotalCourseOutputLabel.Size = new Size(33, 21);
            TotalCourseOutputLabel.TabIndex = 15;
            TotalCourseOutputLabel.Text = "(?)";
            // 
            // totalStudentslabel
            // 
            totalStudentslabel.AutoSize = true;
            totalStudentslabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalStudentslabel.Location = new Point(1268, 684);
            totalStudentslabel.Name = "totalStudentslabel";
            totalStudentslabel.Size = new Size(124, 22);
            totalStudentslabel.TabIndex = 14;
            totalStudentslabel.Text = "Total Course:";
            // 
            // searchPictureBox
            // 
            searchPictureBox.Image = (Image)resources.GetObject("searchPictureBox.Image");
            searchPictureBox.Location = new Point(542, 98);
            searchPictureBox.Name = "searchPictureBox";
            searchPictureBox.Size = new Size(24, 24);
            searchPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            searchPictureBox.TabIndex = 13;
            searchPictureBox.TabStop = false;
            searchPictureBox.Click += searchPictureBox_Click_1;
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
            SearchdataGridView.Location = new Point(63, 211);
            SearchdataGridView.Name = "SearchdataGridView";
            SearchdataGridView.ReadOnly = true;
            SearchdataGridView.RowHeadersWidth = 51;
            SearchdataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            SearchdataGridView.Size = new Size(1421, 456);
            SearchdataGridView.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(296, 70);
            label1.Name = "label1";
            label1.Size = new Size(133, 22);
            label1.TabIndex = 9;
            label1.Text = "Course Code:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(293, 120);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 2);
            panel7.TabIndex = 11;
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
            searchTextBox.TextChanged += searchTextBox_TextChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Window;
            tabPage1.Controls.Add(DeleteCourseButton);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(UDCourseNameTextBox);
            tabPage1.Controls.Add(UpdateCourseButton);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(UDCourseIDTextBox);
            tabPage1.Controls.Add(panel9);
            tabPage1.Controls.Add(panel10);
            tabPage1.Controls.Add(UDCreditHoursTextBox);
            tabPage1.Controls.Add(panel13);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1624, 726);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Update and Delete Course";
            // 
            // DeleteCourseButton
            // 
            DeleteCourseButton.BackColor = Color.Red;
            DeleteCourseButton.FlatAppearance.BorderSize = 0;
            DeleteCourseButton.FlatStyle = FlatStyle.Flat;
            DeleteCourseButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCourseButton.Location = new Point(401, 256);
            DeleteCourseButton.Name = "DeleteCourseButton";
            DeleteCourseButton.Size = new Size(150, 40);
            DeleteCourseButton.TabIndex = 46;
            DeleteCourseButton.Text = "Delete";
            DeleteCourseButton.UseVisualStyleBackColor = false;
            DeleteCourseButton.Click += DeleteCourseButton_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(142, 195, 176);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(270, 23);
            label2.TabIndex = 45;
            label2.Text = "Update and Delete Course";
            // 
            // UDCourseNameTextBox
            // 
            UDCourseNameTextBox.BackColor = SystemColors.Window;
            UDCourseNameTextBox.BorderStyle = BorderStyle.None;
            UDCourseNameTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDCourseNameTextBox.Location = new Point(555, 137);
            UDCourseNameTextBox.Name = "UDCourseNameTextBox";
            UDCourseNameTextBox.Size = new Size(270, 23);
            UDCourseNameTextBox.TabIndex = 30;
            // 
            // UpdateCourseButton
            // 
            UpdateCourseButton.BackColor = Color.FromArgb(142, 195, 176);
            UpdateCourseButton.FlatAppearance.BorderSize = 0;
            UpdateCourseButton.FlatStyle = FlatStyle.Flat;
            UpdateCourseButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateCourseButton.Location = new Point(180, 256);
            UpdateCourseButton.Name = "UpdateCourseButton";
            UpdateCourseButton.Size = new Size(150, 40);
            UpdateCourseButton.TabIndex = 44;
            UpdateCourseButton.Text = "Update";
            UpdateCourseButton.UseVisualStyleBackColor = false;
            UpdateCourseButton.Click += UpdateCourseButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(558, 112);
            label3.Name = "label3";
            label3.Size = new Size(137, 22);
            label3.TabIndex = 25;
            label3.Text = "Course Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(180, 116);
            label4.Name = "label4";
            label4.Size = new Size(133, 22);
            label4.TabIndex = 26;
            label4.Text = "Course Code:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(946, 112);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 27;
            label5.Text = "Credit Hours:";
            // 
            // UDCourseIDTextBox
            // 
            UDCourseIDTextBox.BackColor = SystemColors.Window;
            UDCourseIDTextBox.BorderStyle = BorderStyle.None;
            UDCourseIDTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDCourseIDTextBox.Location = new Point(177, 137);
            UDCourseIDTextBox.Name = "UDCourseIDTextBox";
            UDCourseIDTextBox.Size = new Size(270, 23);
            UDCourseIDTextBox.TabIndex = 28;
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(177, 166);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 2);
            panel9.TabIndex = 29;
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Location = new Point(555, 166);
            panel10.Name = "panel10";
            panel10.Size = new Size(270, 2);
            panel10.TabIndex = 33;
            // 
            // UDCreditHoursTextBox
            // 
            UDCreditHoursTextBox.BackColor = SystemColors.Window;
            UDCreditHoursTextBox.BorderStyle = BorderStyle.None;
            UDCreditHoursTextBox.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UDCreditHoursTextBox.Location = new Point(943, 137);
            UDCreditHoursTextBox.Name = "UDCreditHoursTextBox";
            UDCreditHoursTextBox.Size = new Size(270, 23);
            UDCreditHoursTextBox.TabIndex = 31;
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Location = new Point(943, 166);
            panel13.Name = "panel13";
            panel13.Size = new Size(270, 2);
            panel13.TabIndex = 32;
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
            panelBack.TabIndex = 25;
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
            // dashboardPanel
            // 
            dashboardPanel.Anchor = AnchorStyles.None;
            dashboardPanel.BackColor = Color.FromArgb(188, 234, 213);
            dashboardPanel.Controls.Add(ReportsButton);
            dashboardPanel.Controls.Add(button1);
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
            dashboardPanel.TabIndex = 26;
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
            ReportsButton.TabIndex = 23;
            ReportsButton.Text = "                Report";
            ReportsButton.TextAlign = ContentAlignment.MiddleLeft;
            ReportsButton.UseVisualStyleBackColor = true;
            ReportsButton.Click += ReportsButton_Click_1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11F);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(49, 1042);
            button1.Name = "button1";
            button1.Size = new Size(220, 40);
            button1.TabIndex = 19;
            button1.Text = "                Report";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
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
            archivedButton.Location = new Point(111, 1988);
            archivedButton.Name = "archivedButton";
            archivedButton.Size = new Size(220, 40);
            archivedButton.TabIndex = 8;
            archivedButton.Text = "                Archived";
            archivedButton.TextAlign = ContentAlignment.MiddleLeft;
            archivedButton.UseVisualStyleBackColor = true;
            // 
            // Course
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dashboardPanel);
            Controls.Add(panelBack);
            Controls.Add(TabControl);
            Name = "Course";
            Text = "Course";
            TabControl.ResumeLayout(false);
            addCourseTabPage.ResumeLayout(false);
            addCourseTabPage.PerformLayout();
            searchCourseTabPage.ResumeLayout(false);
            searchCourseTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchdataGridView).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panelBack.ResumeLayout(false);
            panelBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)logoutPictureBox).EndInit();
            dashboardPanel.ResumeLayout(false);
            dashboardSmallpanel.ResumeLayout(false);
            dashboardSmallpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dashboardPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabControl TabControl;
        private TabPage addCourseTabPage;
        private Label addStudentLabel;
        private TextBox courseNameTextBox;
        private Button addButton;
        private Label studentLNameLabel;
        private Label studentIDLabel;
        private Label studFNameLabel;
        private TextBox courseCodeTextBox;
        private Panel panel1;
        private Panel panel2;
        private TextBox creditHoursTextBox;
        private Panel panel3;
        private TabPage searchCourseTabPage;
        private Label searchStudentLabel;
        private Label TotalCourseOutputLabel;
        private Label totalStudentslabel;
        private PictureBox searchPictureBox;
        private DataGridView SearchdataGridView;
        private Label label1;
        private Panel panel7;
        private TextBox searchTextBox;
        private TabPage tabPage1;
        private Button DeleteCourseButton;
        private Label label2;
        private TextBox UDCourseNameTextBox;
        private Button UpdateCourseButton;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox UDCourseIDTextBox;
        private Panel panel9;
        private Panel panel10;
        private TextBox UDCreditHoursTextBox;
        private Panel panel13;
        private Panel panelBack;
        private Panel panel14;
        private PictureBox expandPictureBox;
        private PictureBox logoutPictureBox;
        private Panel dashboardPanel;
        private Button button1;
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
    }
}