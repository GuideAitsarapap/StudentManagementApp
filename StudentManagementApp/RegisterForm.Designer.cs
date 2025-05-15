namespace StudentManagementApp
{
    partial class RegisterForm
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
            panel1 = new Panel();
            PictureBoxLogin = new PictureBox();
            label5 = new Label();
            LoginYourAccount = new Label();
            RegisterBtn = new Button();
            RegisterPassword = new TextBox();
            RegisterUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Exit = new Label();
            label3 = new Label();
            CheckRegisterBoxPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(PictureBoxLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(LoginYourAccount);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 480);
            panel1.TabIndex = 17;
            // 
            // PictureBoxLogin
            // 
            PictureBoxLogin.Image = Properties.Resources.StudentIcon;
            PictureBoxLogin.Location = new Point(75, 68);
            PictureBoxLogin.Name = "PictureBoxLogin";
            PictureBoxLogin.Size = new Size(192, 190);
            PictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxLogin.TabIndex = 12;
            PictureBoxLogin.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(6, 280);
            label5.Name = "label5";
            label5.Size = new Size(340, 37);
            label5.TabIndex = 11;
            label5.Text = "Student Management";
            // 
            // LoginYourAccount
            // 
            LoginYourAccount.AutoSize = true;
            LoginYourAccount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginYourAccount.ForeColor = SystemColors.ButtonFace;
            LoginYourAccount.Location = new Point(105, 429);
            LoginYourAccount.Name = "LoginYourAccount";
            LoginYourAccount.Size = new Size(119, 16);
            LoginYourAccount.TabIndex = 10;
            LoginYourAccount.Text = "LogIn your account";
            LoginYourAccount.Click += LoginYourAccount_Click;
            // 
            // RegisterBtn
            // 
            RegisterBtn.BackColor = Color.MidnightBlue;
            RegisterBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterBtn.ForeColor = SystemColors.ButtonFace;
            RegisterBtn.Location = new Point(582, 330);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(126, 55);
            RegisterBtn.TabIndex = 15;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = false;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // RegisterPassword
            // 
            RegisterPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterPassword.Location = new Point(414, 261);
            RegisterPassword.Name = "RegisterPassword";
            RegisterPassword.PasswordChar = '●';
            RegisterPassword.Size = new Size(294, 29);
            RegisterPassword.TabIndex = 14;
            // 
            // RegisterUsername
            // 
            RegisterUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterUsername.Location = new Point(414, 198);
            RegisterUsername.Name = "RegisterUsername";
            RegisterUsername.Size = new Size(294, 29);
            RegisterUsername.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(414, 234);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 12;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(409, 171);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 11;
            label1.Text = "Username:";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(703, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(34, 40);
            Exit.TabIndex = 19;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(409, 104);
            label3.Name = "label3";
            label3.Size = new Size(253, 33);
            label3.TabIndex = 18;
            label3.Text = "Register Account";
            // 
            // CheckRegisterBoxPassword
            // 
            CheckRegisterBoxPassword.AutoSize = true;
            CheckRegisterBoxPassword.Location = new Point(600, 305);
            CheckRegisterBoxPassword.Name = "CheckRegisterBoxPassword";
            CheckRegisterBoxPassword.Size = new Size(108, 19);
            CheckRegisterBoxPassword.TabIndex = 29;
            CheckRegisterBoxPassword.Text = "Show password";
            CheckRegisterBoxPassword.UseVisualStyleBackColor = true;
            CheckRegisterBoxPassword.CheckedChanged += CheckRegisterBoxPassword_CheckedChanged;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 480);
            Controls.Add(CheckRegisterBoxPassword);
            Controls.Add(panel1);
            Controls.Add(RegisterBtn);
            Controls.Add(RegisterPassword);
            Controls.Add(RegisterUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox PictureBoxLogin;
        private Label label5;
        private Label LoginYourAccount;
        private Button RegisterBtn;
        private TextBox RegisterPassword;
        private TextBox RegisterUsername;
        private Label label2;
        private Label label1;
        private Label Exit;
        private Label label3;
        private CheckBox CheckRegisterBoxPassword;
    }
}