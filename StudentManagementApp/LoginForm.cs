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
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(DbConfig.ConnectionString);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterYourAccount_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void CheckLoginBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            LoginPassword.PasswordChar = CheckLogInBoxPassword.Checked ? '\0' : '●';
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (LoginUsername.Text == "" || LoginPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string selectData = "SELECT COUNT(id) FROM Users WHERE username = @username AND password = @password";
                        using (SqlCommand command = new SqlCommand(selectData, connect))
                        {
                            command.Parameters.AddWithValue("@username", LoginUsername.Text.Trim());
                            command.Parameters.AddWithValue("@password", LoginPassword.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                MainForm mainForm = new MainForm();
                                mainForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                        return;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                
            }
        }
    }
}
