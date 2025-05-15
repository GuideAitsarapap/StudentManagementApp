namespace StudentManagementApp
{
    partial class MainForm
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
            StudentDGV = new DataGridView();
            label1 = new Label();
            Exit = new Label();
            label5 = new Label();
            PictureBoxLogin = new PictureBox();
            panel1 = new Panel();
            ManageBtn = new Button();
            StudentDataBtn = new Button();
            LogOutBtn = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            manageStudentForm = new ManageStudentForm();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogin).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // StudentDGV
            // 
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDGV.Location = new Point(270, 96);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.Size = new Size(862, 530);
            StudentDGV.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 60);
            label1.Name = "label1";
            label1.Size = new Size(204, 33);
            label1.TabIndex = 29;
            label1.Text = "Student's Data";
            // 
            // Exit
            // 
            Exit.AutoSize = true;
            Exit.Cursor = Cursors.Hand;
            Exit.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Exit.ForeColor = SystemColors.ButtonFace;
            Exit.Location = new Point(1138, 3);
            Exit.Name = "Exit";
            Exit.Size = new Size(28, 32);
            Exit.TabIndex = 28;
            Exit.Text = "X";
            Exit.Click += Exit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(38, 230);
            label5.Name = "label5";
            label5.Size = new Size(178, 29);
            label5.TabIndex = 11;
            label5.Text = "Welcome, User";
            // 
            // PictureBoxLogin
            // 
            PictureBoxLogin.BackColor = Color.Transparent;
            PictureBoxLogin.Image = Properties.Resources.StudentIcon;
            PictureBoxLogin.Location = new Point(60, 89);
            PictureBoxLogin.Name = "PictureBoxLogin";
            PictureBoxLogin.Size = new Size(131, 131);
            PictureBoxLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBoxLogin.TabIndex = 12;
            PictureBoxLogin.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(ManageBtn);
            panel1.Controls.Add(StudentDataBtn);
            panel1.Controls.Add(LogOutBtn);
            panel1.Controls.Add(PictureBoxLogin);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(246, 635);
            panel1.TabIndex = 26;
            // 
            // ManageBtn
            // 
            ManageBtn.BackColor = Color.MidnightBlue;
            ManageBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManageBtn.ForeColor = SystemColors.ButtonFace;
            ManageBtn.Location = new Point(30, 435);
            ManageBtn.Name = "ManageBtn";
            ManageBtn.Size = new Size(196, 64);
            ManageBtn.TabIndex = 37;
            ManageBtn.Text = "MANAGE";
            ManageBtn.UseVisualStyleBackColor = false;
            ManageBtn.Click += ManageBtn_Click;
            // 
            // StudentDataBtn
            // 
            StudentDataBtn.BackColor = Color.MidnightBlue;
            StudentDataBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StudentDataBtn.ForeColor = SystemColors.ButtonFace;
            StudentDataBtn.Location = new Point(30, 313);
            StudentDataBtn.Name = "StudentDataBtn";
            StudentDataBtn.Size = new Size(196, 65);
            StudentDataBtn.TabIndex = 36;
            StudentDataBtn.Text = "STUDENT";
            StudentDataBtn.UseVisualStyleBackColor = false;
            StudentDataBtn.Click += StudentDataBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.ImageLocation = "E:\\SQL Project Web app\\StudentManagementApp\\StudentManagementApp\\myImages\\LogOutIcon.png";
            LogOutBtn.Location = new Point(195, 574);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(31, 32);
            LogOutBtn.SizeMode = PictureBoxSizeMode.StretchImage;
            LogOutBtn.TabIndex = 35;
            LogOutBtn.TabStop = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(298, 29);
            label2.TabIndex = 33;
            label2.Text = "Student Manament System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Exit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1169, 35);
            panel2.TabIndex = 39;
            // 
            // manageStudentForm
            // 
            manageStudentForm.Location = new Point(243, 35);
            manageStudentForm.Name = "manageStudentForm";
            manageStudentForm.Size = new Size(948, 650);
            manageStudentForm.TabIndex = 40;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 667);
            Controls.Add(panel2);
            Controls.Add(StudentDGV);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(manageStudentForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)PictureBoxLogin).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LogOutBtn).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentDGV;
        private Label label1;
        private Label Exit;
        private Label label5;
        private PictureBox PictureBoxLogin;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private PictureBox LogOutBtn;
        private Button ManageBtn;
        private Button StudentDataBtn;
        private ManageStudentForm manageStudentForm;
    }
}