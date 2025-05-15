using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            displayStudentData();
        }

        public void displayStudentData()
        {
            StudentsData studentsData = new StudentsData();
            List<StudentsData> listData = studentsData.StudentListData();

            StudentDGV.DataSource = listData;
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StudentDataBtn_Click(object sender, EventArgs e)
        {
            manageStudentForm.SendToBack();
        }

        private void ManageBtn_Click(object sender, EventArgs e)
        {
            manageStudentForm.BringToFront();
        }
    }
}
