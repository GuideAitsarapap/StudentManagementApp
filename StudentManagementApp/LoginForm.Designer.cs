namespace StudentManagementApp
{
    partial class LoginForm
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
            RegisterYourAccount = new Label();
            LoginBtn = new Button();
            LoginPassword = new TextBox();
            LoginUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Exit = new Label();
            label3 = new Label();
            CheckLogInBoxPassword = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogin).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(PictureBoxLogin);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(RegisterYourAccount);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 480);
            panel1.TabIndex = 25;
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
            // RegisterYourAccount
            // 
            RegisterYourAccount.AutoSize = true;
            RegisterYourAccount.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterYourAccount.ForeColor = SystemColors.ButtonFace;
            RegisterYourAccount.Location = new Point(105, 429);
            RegisterYourAccount.Name = "RegisterYourAccount";
            RegisterYourAccount.Size = new Size(137, 16);
            RegisterYourAccount.TabIndex = 10;
            RegisterYourAccount.Text = "Register your account";
            RegisterYourAccount.Click += RegisterYourAccount_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.MidnightBlue;
            LoginBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = SystemColors.ButtonFace;
            LoginBtn.Location = new Point(577, 330);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(126, 55);
            LoginBtn.TabIndex = 24;
            LoginBtn.Text = "LogIn";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // LoginPassword
            // 
            LoginPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginPassword.Location = new Point(409, 261);
            LoginPassword.Name = "LoginPassword";
            LoginPassword.PasswordChar = '●';
            LoginPassword.Size = new Size(294, 29);
            LoginPassword.TabIndex = 23;
            // 
            // LoginUsername
            // 
            LoginUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginUsername.Location = new Point(409, 198);
            LoginUsername.Name = "LoginUsername";
            LoginUsername.Size = new Size(294, 29);
            LoginUsername.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 234);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 21;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(404, 171);
            label1.Name = "label1";
            label1.Size = new Size(102, 24);
            label1.TabIndex = 20;
            label1.Text = "Username:";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.Location = new Point(698, 9);
            Exit.Name = "Exit";
            Exit.Size = new Size(34, 40);
            Exit.TabIndex = 27;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(404, 104);
            label3.Name = "label3";
            label3.Size = new Size(212, 33);
            label3.TabIndex = 26;
            label3.Text = "Login Account";
            // 
            // CheckLogInBoxPassword
            // 
            CheckLogInBoxPassword.AutoSize = true;
            CheckLogInBoxPassword.Location = new Point(595, 305);
            CheckLogInBoxPassword.Name = "CheckLogInBoxPassword";
            CheckLogInBoxPassword.Size = new Size(108, 19);
            CheckLogInBoxPassword.TabIndex = 28;
            CheckLogInBoxPassword.Text = "Show password";
            CheckLogInBoxPassword.UseVisualStyleBackColor = true;
            CheckLogInBoxPassword.CheckedChanged += CheckLoginBoxPassword_CheckedChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 480);
            Controls.Add(CheckLogInBoxPassword);
            Controls.Add(panel1);
            Controls.Add(LoginBtn);
            Controls.Add(LoginPassword);
            Controls.Add(LoginUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exit);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
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
        private Label RegisterYourAccount;
        private Button LoginBtn;
        private TextBox LoginPassword;
        private TextBox LoginUsername;
        private Label label2;
        private Label label1;
        private Label Exit;
        private Label label3;
        private CheckBox CheckLogInBoxPassword;
    }
}