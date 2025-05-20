namespace Student_Attendance_Management_System
{
    partial class ForgotPassword
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
            ResetPassGroupBox = new GroupBox();
            UsernameLabel = new Label();
            NewPassLabel = new Label();
            ConfirmPassLabel = new Label();
            UsernameTextBox = new TextBox();
            NewPassTextBox = new TextBox();
            ConfirmPassTextBox = new TextBox();
            ResetButton = new Button();
            CancelButton = new Button();
            ResetPassGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ResetPassGroupBox
            // 
            ResetPassGroupBox.Controls.Add(CancelButton);
            ResetPassGroupBox.Controls.Add(ResetButton);
            ResetPassGroupBox.Controls.Add(ConfirmPassTextBox);
            ResetPassGroupBox.Controls.Add(NewPassTextBox);
            ResetPassGroupBox.Controls.Add(UsernameTextBox);
            ResetPassGroupBox.Controls.Add(ConfirmPassLabel);
            ResetPassGroupBox.Controls.Add(NewPassLabel);
            ResetPassGroupBox.Controls.Add(UsernameLabel);
            ResetPassGroupBox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ResetPassGroupBox.Location = new Point(341, 64);
            ResetPassGroupBox.Name = "ResetPassGroupBox";
            ResetPassGroupBox.Size = new Size(514, 411);
            ResetPassGroupBox.TabIndex = 0;
            ResetPassGroupBox.TabStop = false;
            ResetPassGroupBox.Text = "Reset Password";
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(112, 52);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(113, 23);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // NewPassLabel
            // 
            NewPassLabel.AutoSize = true;
            NewPassLabel.Location = new Point(112, 139);
            NewPassLabel.Name = "NewPassLabel";
            NewPassLabel.Size = new Size(160, 23);
            NewPassLabel.TabIndex = 1;
            NewPassLabel.Text = "New Password:";
            // 
            // ConfirmPassLabel
            // 
            ConfirmPassLabel.AutoSize = true;
            ConfirmPassLabel.Location = new Point(118, 213);
            ConfirmPassLabel.Name = "ConfirmPassLabel";
            ConfirmPassLabel.Size = new Size(189, 23);
            ConfirmPassLabel.TabIndex = 2;
            ConfirmPassLabel.Text = "Confirm Password:";
            ConfirmPassLabel.Click += label2_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(118, 78);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(281, 32);
            UsernameTextBox.TabIndex = 3;
            UsernameTextBox.TextChanged += UsernameTextBox_TextChanged;
            // 
            // NewPassTextBox
            // 
            NewPassTextBox.Location = new Point(118, 165);
            NewPassTextBox.Name = "NewPassTextBox";
            NewPassTextBox.Size = new Size(281, 32);
            NewPassTextBox.TabIndex = 4;
            NewPassTextBox.TextChanged += NewPassTextBox_TextChanged;
            // 
            // ConfirmPassTextBox
            // 
            ConfirmPassTextBox.Location = new Point(118, 253);
            ConfirmPassTextBox.Name = "ConfirmPassTextBox";
            ConfirmPassTextBox.Size = new Size(281, 32);
            ConfirmPassTextBox.TabIndex = 5;
            ConfirmPassTextBox.TextChanged += ConfirmPassTextBox_TextChanged;
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(126, 327);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(94, 29);
            ResetButton.TabIndex = 6;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(315, 327);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 7;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1023, 528);
            Controls.Add(ResetPassGroupBox);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResetPassGroupBox.ResumeLayout(false);
            ResetPassGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ResetPassGroupBox;
        private Label ConfirmPassLabel;
        private Label NewPassLabel;
        private Label UsernameLabel;
        private TextBox NewPassTextBox;
        private TextBox UsernameTextBox;
        private TextBox ConfirmPassTextBox;
        private Button CancelButton;
        private Button ResetButton;
    }
}