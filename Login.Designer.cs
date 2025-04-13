namespace Student_Attendance_Management_System
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            title = new Label();
            emailTextBox = new TextBox();
            passwordTextBox = new TextBox();
            email = new Label();
            password = new Label();
            loginButton = new Button();
            loginPictureBox = new PictureBox();
            label1 = new Label();
            forgotPassLinkLabel = new LinkLabel();
            loginGroupBox = new GroupBox();
            panel = new Panel();
            title2 = new Label();
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).BeginInit();
            loginGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.Anchor = AnchorStyles.None;
            title.AutoSize = true;
            title.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.Location = new Point(345, 456);
            title.Name = "title";
            title.Size = new Size(344, 40);
            title.TabIndex = 0;
            title.Text = "Student Attendance";
            title.Click += title_Click;
            // 
            // emailTextBox
            // 
            emailTextBox.Anchor = AnchorStyles.None;
            emailTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTextBox.Location = new Point(186, 102);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 32);
            emailTextBox.TabIndex = 1;
            emailTextBox.TextChanged += emailTextBox_TextChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.None;
            passwordTextBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(186, 181);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(125, 32);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            // 
            // email
            // 
            email.Anchor = AnchorStyles.None;
            email.AutoSize = true;
            email.Font = new Font("Century Gothic", 12F);
            email.Location = new Point(66, 111);
            email.Name = "email";
            email.Size = new Size(67, 23);
            email.TabIndex = 3;
            email.Text = "Email:";
            email.Click += email_Click;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.None;
            password.AutoSize = true;
            password.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(66, 184);
            password.Name = "password";
            password.Size = new Size(108, 23);
            password.TabIndex = 4;
            password.Text = "Password:";
            password.Click += password_Click;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.BackColor = Color.FromArgb(142, 195, 176);
            loginButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.Location = new Point(145, 264);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(104, 40);
            loginButton.TabIndex = 5;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginPictureBox
            // 
            loginPictureBox.Anchor = AnchorStyles.None;
            loginPictureBox.Image = (Image)resources.GetObject("loginPictureBox.Image");
            loginPictureBox.Location = new Point(421, 251);
            loginPictureBox.Name = "loginPictureBox";
            loginPictureBox.Size = new Size(171, 183);
            loginPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginPictureBox.TabIndex = 6;
            loginPictureBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(84, 283);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 7;
            // 
            // forgotPassLinkLabel
            // 
            forgotPassLinkLabel.Anchor = AnchorStyles.None;
            forgotPassLinkLabel.AutoSize = true;
            forgotPassLinkLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgotPassLinkLabel.LinkColor = Color.Black;
            forgotPassLinkLabel.Location = new Point(106, 323);
            forgotPassLinkLabel.Name = "forgotPassLinkLabel";
            forgotPassLinkLabel.Size = new Size(183, 23);
            forgotPassLinkLabel.TabIndex = 8;
            forgotPassLinkLabel.TabStop = true;
            forgotPassLinkLabel.Text = "Forgot Password?";
            // 
            // loginGroupBox
            // 
            loginGroupBox.Anchor = AnchorStyles.None;
            loginGroupBox.Controls.Add(email);
            loginGroupBox.Controls.Add(forgotPassLinkLabel);
            loginGroupBox.Controls.Add(emailTextBox);
            loginGroupBox.Controls.Add(label1);
            loginGroupBox.Controls.Add(passwordTextBox);
            loginGroupBox.Controls.Add(password);
            loginGroupBox.Controls.Add(loginButton);
            loginGroupBox.Location = new Point(1025, 251);
            loginGroupBox.Name = "loginGroupBox";
            loginGroupBox.Size = new Size(415, 373);
            loginGroupBox.TabIndex = 9;
            loginGroupBox.TabStop = false;
            loginGroupBox.Text = "Please Login First";
            loginGroupBox.Enter += loginGroupBox_Enter;
            // 
            // panel
            // 
            panel.BackColor = SystemColors.Control;
            panel.Location = new Point(883, 233);
            panel.Name = "panel";
            panel.Size = new Size(5, 405);
            panel.TabIndex = 0;
            // 
            // title2
            // 
            title2.Anchor = AnchorStyles.None;
            title2.AutoSize = true;
            title2.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.Location = new Point(336, 515);
            title2.Name = "title2";
            title2.Size = new Size(367, 40);
            title2.TabIndex = 10;
            title2.Text = "Management System";
            title2.Click += title2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(title2);
            Controls.Add(panel);
            Controls.Add(loginGroupBox);
            Controls.Add(loginPictureBox);
            Controls.Add(title);
            Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)loginPictureBox).EndInit();
            loginGroupBox.ResumeLayout(false);
            loginGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private TextBox emailTextBox;
        private TextBox passwordTextBox;
        private Label email;
        private Label password;
        private Button loginButton;
        private PictureBox loginPictureBox;
        private Label label1;
        private LinkLabel forgotPassLinkLabel;
        private GroupBox loginGroupBox;
        private Panel panel;
        private Label title2;
    }
}
