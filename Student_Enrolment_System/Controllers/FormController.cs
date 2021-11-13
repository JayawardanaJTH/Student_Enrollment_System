using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Enrolment_System.Models;
using MySql.Data.MySqlClient;
using Student_Enrolment_System.Utility;

namespace Student_Enrolment_System.Controllers
{
    class FormController : IFormController
    {
        public int GetAge(DateTime Birthday)
        {
            try
            {
                int Age = DateTime.Now.AddYears(-Birthday.Year).Year;

                if (Age < 18)
                {
                    throw new Exception("Cannot Enroll – Below 18 years");
                }
                return Age;

            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot Enroll – Below 18 years", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
        }

        public bool ValidatForm(object Object)
        {
            ST_Enroll_UI Form = (ST_Enroll_UI)Object;
            bool Status = false;

            if (Form.txt_regNumber.Text.Equals(string.Empty))
            {
                Status = true;
            }
            else if (Form.txt_studentName.Text.Equals(string.Empty))
            {
                Status = true;
            }
            else if (GetAge(DateTime.Parse(Form.pik_date.Text)) < 18)
            {
                Status = true;
            }
            else if (!Form.rdbtn_male.Checked && !Form.rdbtn_female.Checked)
            {
                Status = true;
            }
            else if (Form.txt_contact.Text.Equals(string.Empty) || Form.txt_contact.Text.Length != 10)
            {
                Status = true;
            }
            else if (Form.cmb_courses.SelectedIndex == 0)
            {
                Status = true;
            }
            else
            {
                Status = false;
            }

            return Status;
        }

        //Database functions

        public bool InsertStudent(Student student)
        {
            try
            {
                MySqlConnection Connection = DbConnection.getConnection();

                string Query = Constants.InsertStudent;
                MySqlCommand Command = new MySqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@regno", student.Regno);
                Command.Parameters.AddWithValue("@name", student.Name);
                Command.Parameters.AddWithValue("@dob", student.Birthday);
                Command.Parameters.AddWithValue("@gender", student.Gender);
                Command.Parameters.AddWithValue("@contact", student.Contact);
                Command.Parameters.AddWithValue("@course", student.Course);
                Command.Prepare();

                Command.ExecuteNonQuery();
                DbConnection.closeConnection();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public Student FindStudentByRegno(int regno)
        {
            Student Student = new Student();

            try
            {
                MySqlConnection Connection = DbConnection.getConnection();

                string Query = Constants.GetStudentByRegno;
                MySqlCommand Command = new MySqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("@regno", regno);
                Command.Prepare();

                MySqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        Student.Regno = Reader.GetInt32(0);
                        Student.Name = Reader.GetString(1);
                        Student.Birthday = Reader.GetDateTime(2);
                        Student.Gender = Reader.GetChar(3);
                        Student.Contact = Reader.GetInt32(4);
                        Student.Course = Reader.GetString(5);
                        Student.Status = true;
                    }

                    Reader.Close();
                    DbConnection.closeConnection();

                    return Student;
                }
                else
                {
                    Reader.Close();
                    DbConnection.closeConnection();
                    return Student;
                }
            }
            catch (Exception e)
            {
                DbConnection.closeConnection();
                Student.Status = false;
                return Student;
            }
        }

        public bool DeleteStudentByRegno(int regno)
        {
            try
            {
                MySqlConnection Connection = DbConnection.getConnection();

                string Query = Constants.DeleteStudentByRegno;
                MySqlCommand Command = new MySqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("regno", regno);
                Command.Prepare();

                Command.ExecuteNonQuery();
                DbConnection.closeConnection();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<int> GetRegistraionNumbers()
        {
            try
            {
                List<int> RegistrationNumbers = new List<int>();

                MySqlConnection Connection = DbConnection.getConnection();

                string Query = Constants.GetAllStudentsRegistrationNumbers;
                MySqlCommand Command = new MySqlCommand(Query, Connection);

                MySqlDataReader Reader = Command.ExecuteReader();

                if (Reader.HasRows)
                {
                    while (Reader.Read())
                    {
                        RegistrationNumbers.Add(Reader.GetInt32(0));
                    }

                    Reader.Close();
                    DbConnection.closeConnection();

                    return RegistrationNumbers;
                }
                else
                {
                    Reader.Close();
                    DbConnection.closeConnection();

                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool InsertCourseFee(CourseFee Fee)
        {
            try
            {
                MySqlConnection Connection = DbConnection.getConnection();
                string Query = Constants.InsertCourseFee;
                MySqlCommand Command = new MySqlCommand(Query, Connection);

                Command.Parameters.AddWithValue("regno", Fee.RegistrationNumber);
                Command.Parameters.AddWithValue("amount", Fee.Amount);
                Command.Parameters.AddWithValue("discount", Fee.Discount);
                Command.Parameters.AddWithValue("total", Fee.Total);
                Command.Prepare();

                Command.ExecuteNonQuery();
                DbConnection.closeConnection();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
