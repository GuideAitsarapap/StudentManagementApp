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
    public partial class ManageStudentForm : UserControl
    {
        SqlConnection connect = new SqlConnection(DbConfig.studentdbConnectionString);

        public ManageStudentForm()
        {
            InitializeComponent();

            displayStudentData();
        }


        public void displayStudentData()
        {
            StudentsData studentsData = new StudentsData();
            List<StudentsData> listData = studentsData.StudentListData();

            StudentManageDGV.DataSource = listData;
        }
        private void AddStudentDataBtn_Click(object sender, EventArgs e)
        {
            if (addStudentId.Text == ""
                || addFirstName.Text == ""
                || addLastName.Text == ""
                || addAge.Text == ""
                || addTel.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkStudentId = "SELECT * FROM Students WHERE id = @id";

                        using (SqlCommand checkStudent = new SqlCommand(checkStudentId, connect))
                        {
                            //check if the student id already exists
                            checkStudent.Parameters.AddWithValue("@id", addStudentId.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkStudent);

                            if (adapter.Fill(new DataTable()) >= 1)
                            {
                                MessageBox.Show("Student ID already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                string insertData = "INSERT INTO Students (id, firstname, lastname, age, contact) " +
                                    "VALUES (@id, @firstname, @lastname, @age, @contact)";
                                using (SqlCommand command = new SqlCommand(insertData, connect))
                                {
                                    command.Parameters.AddWithValue("@id", addStudentId.Text.Trim());
                                    command.Parameters.AddWithValue("@firstname", addFirstName.Text.Trim());
                                    command.Parameters.AddWithValue("@lastname", addLastName.Text.Trim());
                                    command.Parameters.AddWithValue("@age", int.Parse(addAge.Text.Trim()));
                                    command.Parameters.AddWithValue("@contact", addTel.Text.Trim());
                                    command.ExecuteNonQuery();
                                    MessageBox.Show("Student added successfully"
                                        , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayStudentData();

                                    MessageBox.Show("Student added successfully"
                                        , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearfield();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void UpdateStudentDataBtn_Click(object sender, EventArgs e)
        {
            if (addStudentId.Text == ""
                || addFirstName.Text == ""
                || addLastName.Text == ""
                || addAge.Text == ""
                || addTel.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string updateData = "UPDATE Students SET firstname = @firstname, lastname = @lastname, age = @age, contact = @contact WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@id", addStudentId.Text.Trim());
                            command.Parameters.AddWithValue("@firstname", addFirstName.Text.Trim());
                            command.Parameters.AddWithValue("@lastname", addLastName.Text.Trim());
                            command.Parameters.AddWithValue("@age", int.Parse(addAge.Text.Trim()));
                            command.Parameters.AddWithValue("@contact", addTel.Text.Trim());
                            command.ExecuteNonQuery();
                            MessageBox.Show("Student updated successfully"
                                , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayStudentData();
                            clearfield();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void DeleteStudentDataBtn_Click(object sender, EventArgs e)
        {
            if (addStudentId.Text == "")
            {
                MessageBox.Show("Please fill Student ID"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to delete this student?"
                    , "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();
                        string deleteData = "DELETE FROM Students WHERE id = @id";
                        using (SqlCommand command = new SqlCommand(deleteData, connect))
                        {
                            command.Parameters.AddWithValue("@id", addStudentId.Text.Trim());
                            command.ExecuteNonQuery();
                            MessageBox.Show("Student deleted successfully"
                                , "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            displayStudentData();
                            clearfield();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void ClearStudentDataBtn_Click(object sender, EventArgs e)
        {
            clearfield();
        }

        private void clearfield()
        {
            //clear all fields
            addStudentId.Clear();
            addFirstName.Clear();
            addLastName.Clear();
            addAge.Clear();
            addTel.Clear();
        }
    }
}
