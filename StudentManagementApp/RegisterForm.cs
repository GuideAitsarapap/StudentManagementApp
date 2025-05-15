using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace StudentManagementApp
{
    public partial class RegisterForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-J98UMHR\SQLEXPRESS;Initial Catalog=Studentsdb;Integrated Security=True;Trust Server Certificate=True");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (RegisterUsername.Text == "" || RegisterPassword.Text == "")
            {
                MessageBox.Show("Please fill all fields");
            }
            else
            {
                if(connect.State != ConnectionState.Open) // if connection is not open
                {
                    try//try to open it
                    {
                        connect.Open();
                        //check if the username already exists
                        string selectUsername = "SELECT COUNT(id) FROM Users WHERE username = @username";
                        using (SqlCommand checkUsername = new SqlCommand(selectUsername, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim());
                            int count = (int)checkUsername.ExecuteScalar();
                            if (count >= 1)
                            {
                                MessageBox.Show("Username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Username is available", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            //insert the data into the database
                            string insertData = "INSERT INTO Users (username, password,date_register) " +
                                            "VALUES (@username, @password,@dateReg)";
                            using SqlCommand command = new SqlCommand(insertData, connect);
                            {
                                command.Parameters.AddWithValue("@username", RegisterUsername.Text.Trim());
                                command.Parameters.AddWithValue("@password", RegisterPassword.Text.Trim());
                                command.Parameters.AddWithValue("@dateReg", DateTime.Now);
                                command.ExecuteNonQuery();

                                MessageBox.Show("You have registered successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LoginForm loginForm = new LoginForm();
                                loginForm.Show();
                                this.Hide();
                            }
                        }
                    }
                    catch (Exception ex) //if it's not possible to open it
                    {
                        MessageBox.Show("Error: " + ex,
                        "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void LoginYourAccount_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void CheckRegisterBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPassword.PasswordChar = CheckRegisterBoxPassword.Checked ? '\0' : '●';
        }
    }
}
