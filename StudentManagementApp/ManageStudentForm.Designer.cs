namespace StudentManagementApp
{
    partial class ManageStudentForm
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
            panel3 = new Panel();
            label2 = new Label();
            StudentManageDGV = new DataGridView();
            panel4 = new Panel();
            ClearStudentDataBtn = new Button();
            DeleteStudentDataBtn = new Button();
            UpdateStudentDataBtn = new Button();
            AddStudentDataBtn = new Button();
            addTel = new TextBox();
            addAge = new TextBox();
            addLastName = new TextBox();
            addFirstName = new TextBox();
            addStudentId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)StudentManageDGV).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(StudentManageDGV);
            panel3.Location = new Point(19, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(701, 277);
            panel3.TabIndex = 39;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(20, 9);
            label2.Name = "label2";
            label2.Size = new Size(166, 29);
            label2.TabIndex = 34;
            label2.Text = "Student's Data";
            // 
            // StudentManageDGV
            // 
            StudentManageDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentManageDGV.Location = new Point(41, 50);
            StudentManageDGV.Name = "StudentManageDGV";
            StudentManageDGV.Size = new Size(608, 195);
            StudentManageDGV.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(ClearStudentDataBtn);
            panel4.Controls.Add(DeleteStudentDataBtn);
            panel4.Controls.Add(UpdateStudentDataBtn);
            panel4.Controls.Add(AddStudentDataBtn);
            panel4.Controls.Add(addTel);
            panel4.Controls.Add(addAge);
            panel4.Controls.Add(addLastName);
            panel4.Controls.Add(addFirstName);
            panel4.Controls.Add(addStudentId);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Location = new Point(19, 312);
            panel4.Name = "panel4";
            panel4.Size = new Size(701, 253);
            panel4.TabIndex = 40;
            // 
            // ClearStudentDataBtn
            // 
            ClearStudentDataBtn.BackColor = Color.MidnightBlue;
            ClearStudentDataBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClearStudentDataBtn.ForeColor = SystemColors.ButtonFace;
            ClearStudentDataBtn.Location = new Point(425, 184);
            ClearStudentDataBtn.Name = "ClearStudentDataBtn";
            ClearStudentDataBtn.Size = new Size(106, 51);
            ClearStudentDataBtn.TabIndex = 45;
            ClearStudentDataBtn.Text = "Clear";
            ClearStudentDataBtn.UseVisualStyleBackColor = false;
            ClearStudentDataBtn.Click += ClearStudentDataBtn_Click;
            // 
            // DeleteStudentDataBtn
            // 
            DeleteStudentDataBtn.BackColor = Color.MidnightBlue;
            DeleteStudentDataBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteStudentDataBtn.ForeColor = SystemColors.ButtonFace;
            DeleteStudentDataBtn.Location = new Point(425, 126);
            DeleteStudentDataBtn.Name = "DeleteStudentDataBtn";
            DeleteStudentDataBtn.Size = new Size(106, 53);
            DeleteStudentDataBtn.TabIndex = 44;
            DeleteStudentDataBtn.Text = "Delete";
            DeleteStudentDataBtn.UseVisualStyleBackColor = false;
            DeleteStudentDataBtn.Click += DeleteStudentDataBtn_Click;
            // 
            // UpdateStudentDataBtn
            // 
            UpdateStudentDataBtn.BackColor = Color.MidnightBlue;
            UpdateStudentDataBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateStudentDataBtn.ForeColor = SystemColors.ButtonFace;
            UpdateStudentDataBtn.Location = new Point(425, 79);
            UpdateStudentDataBtn.Name = "UpdateStudentDataBtn";
            UpdateStudentDataBtn.Size = new Size(106, 47);
            UpdateStudentDataBtn.TabIndex = 43;
            UpdateStudentDataBtn.Text = "Update";
            UpdateStudentDataBtn.UseVisualStyleBackColor = false;
            UpdateStudentDataBtn.Click += UpdateStudentDataBtn_Click;
            // 
            // AddStudentDataBtn
            // 
            AddStudentDataBtn.BackColor = Color.MidnightBlue;
            AddStudentDataBtn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddStudentDataBtn.ForeColor = SystemColors.ButtonFace;
            AddStudentDataBtn.Location = new Point(425, 30);
            AddStudentDataBtn.Name = "AddStudentDataBtn";
            AddStudentDataBtn.Size = new Size(106, 47);
            AddStudentDataBtn.TabIndex = 33;
            AddStudentDataBtn.Text = "Add";
            AddStudentDataBtn.UseVisualStyleBackColor = false;
            AddStudentDataBtn.Click += AddStudentDataBtn_Click;
            // 
            // addTel
            // 
            addTel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addTel.Location = new Point(116, 194);
            addTel.Name = "addTel";
            addTel.Size = new Size(294, 29);
            addTel.TabIndex = 42;
            // 
            // addAge
            // 
            addAge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addAge.Location = new Point(116, 159);
            addAge.Name = "addAge";
            addAge.Size = new Size(294, 29);
            addAge.TabIndex = 41;
            // 
            // addLastName
            // 
            addLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addLastName.Location = new Point(116, 122);
            addLastName.Name = "addLastName";
            addLastName.Size = new Size(294, 29);
            addLastName.TabIndex = 40;
            // 
            // addFirstName
            // 
            addFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addFirstName.Location = new Point(116, 87);
            addFirstName.Name = "addFirstName";
            addFirstName.Size = new Size(294, 29);
            addFirstName.TabIndex = 39;
            // 
            // addStudentId
            // 
            addStudentId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStudentId.Location = new Point(116, 30);
            addStudentId.Name = "addStudentId";
            addStudentId.Size = new Size(294, 29);
            addStudentId.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(76, 198);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 38;
            label8.Text = "Tel:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(68, 159);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 37;
            label7.Text = "Age:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(19, 34);
            label6.Name = "label6";
            label6.Size = new Size(91, 20);
            label6.TabIndex = 36;
            label6.Text = "Student ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(21, 126);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 35;
            label4.Text = "Last Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(20, 91);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 34;
            label3.Text = "First Name:";
            // 
            // ManageStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Name = "ManageStudentForm";
            Size = new Size(739, 618);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)StudentManageDGV).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private DataGridView StudentManageDGV;
        private Label label2;
        private Panel panel4;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Button ClearStudentDataBtn;
        private Button DeleteStudentDataBtn;
        private Button UpdateStudentDataBtn;
        private Button AddStudentDataBtn;
        private TextBox addTel;
        private TextBox addAge;
        private TextBox addLastName;
        private TextBox addFirstName;
        private TextBox addStudentId;
    }
}
