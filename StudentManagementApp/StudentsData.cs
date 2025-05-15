using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace StudentManagementApp
{
    internal class StudentsData
    {
        public string id { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }

        public int age { get; set; }

        public string tel { get;set; }

        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-J98UMHR\SQLEXPRESS;Initial Catalog=Studentsdb;Integrated Security=True;Trust Server Certificate=True");

        public List<StudentsData> StudentListData()
        {
            List<StudentsData> listData = new List<StudentsData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM Students";
                    using (SqlCommand command = new SqlCommand(selectData,connect))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while(reader.Read())
                        {
                            StudentsData studentsData = new StudentsData();
                            studentsData.id = reader["id"].ToString();
                            studentsData.firstName = reader["firstname"].ToString();
                            studentsData.lastName = reader["lastname"].ToString();
                            studentsData.age = Convert.ToInt32(reader["age"]);
                            studentsData.tel = reader["contact"].ToString();

                            listData.Add(studentsData);
                        }

                    }
                }
                catch ( Exception ex)
                {
                    Console.WriteLine("Error: "+ex);
                }
                finally
                {
                    connect.Close();
                }
              
            }
            return listData;
        }
    }
}
