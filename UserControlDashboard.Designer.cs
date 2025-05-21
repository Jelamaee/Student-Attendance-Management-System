namespace Student_Attendance_Management_System
{
    partial class UserControlDashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlDashboard));
            studentPanel = new Panel();
            TotalStudentOutputLabel = new Label();
            studentLabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            TotalAttendanceOutputLabel = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            TotalRoleOutputLabel = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            studentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // studentPanel
            // 
            studentPanel.Anchor = AnchorStyles.None;
            studentPanel.BackColor = Color.FromArgb(158, 213, 197);
            studentPanel.Controls.Add(TotalStudentOutputLabel);
            studentPanel.Controls.Add(studentLabel);
            studentPanel.Controls.Add(pictureBox1);
            studentPanel.Location = new Point(145, 88);
            studentPanel.Name = "studentPanel";
            studentPanel.Size = new Size(250, 125);
            studentPanel.TabIndex = 0;
            // 
            // TotalStudentOutputLabel
            // 
            TotalStudentOutputLabel.Anchor = AnchorStyles.None;
            TotalStudentOutputLabel.AutoSize = true;
            TotalStudentOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalStudentOutputLabel.Location = new Point(148, 84);
            TotalStudentOutputLabel.Name = "TotalStudentOutputLabel";
            TotalStudentOutputLabel.Size = new Size(33, 21);
            TotalStudentOutputLabel.TabIndex = 2;
            TotalStudentOutputLabel.Text = "(?)";
            TotalStudentOutputLabel.Click += TotalStudentOutputLabel_Click;
            // 
            // studentLabel
            // 
            studentLabel.Anchor = AnchorStyles.None;
            studentLabel.AutoSize = true;
            studentLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentLabel.Location = new Point(126, 54);
            studentLabel.Name = "studentLabel";
            studentLabel.Size = new Size(86, 21);
            studentLabel.TabIndex = 1;
            studentLabel.Text = "Students";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(158, 213, 197);
            panel1.Controls.Add(TotalAttendanceOutputLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(723, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            // 
            // TotalAttendanceOutputLabel
            // 
            TotalAttendanceOutputLabel.Anchor = AnchorStyles.None;
            TotalAttendanceOutputLabel.AutoSize = true;
            TotalAttendanceOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalAttendanceOutputLabel.Location = new Point(148, 84);
            TotalAttendanceOutputLabel.Name = "TotalAttendanceOutputLabel";
            TotalAttendanceOutputLabel.Size = new Size(33, 21);
            TotalAttendanceOutputLabel.TabIndex = 2;
            TotalAttendanceOutputLabel.Text = "(?)";
            TotalAttendanceOutputLabel.Click += TotalAttendanceOutputLabel_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(110, 54);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 1;
            label3.Text = "Attendances";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(158, 213, 197);
            panel2.Controls.Add(TotalRoleOutputLabel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(440, 318);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 3;
            // 
            // TotalRoleOutputLabel
            // 
            TotalRoleOutputLabel.Anchor = AnchorStyles.None;
            TotalRoleOutputLabel.AutoSize = true;
            TotalRoleOutputLabel.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TotalRoleOutputLabel.Location = new Point(148, 84);
            TotalRoleOutputLabel.Name = "TotalRoleOutputLabel";
            TotalRoleOutputLabel.Size = new Size(33, 21);
            TotalRoleOutputLabel.TabIndex = 2;
            TotalRoleOutputLabel.Text = "(?)";
            TotalRoleOutputLabel.Click += TotalRoleOutputLabel_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(146, 51);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 1;
            label5.Text = "Roles";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 21);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // UserControlDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(studentPanel);
            Name = "UserControlDashboard";
            Size = new Size(1337, 550);
            studentPanel.ResumeLayout(false);
            studentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel studentPanel;
        private Label TotalStudentOutputLabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label TotalAttendanceOutputLabel;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label TotalRoleOutputLabel;
        private Label label5;
        private PictureBox pictureBox3;
        private Label studentLabel;
    }
}
