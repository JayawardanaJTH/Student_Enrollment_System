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
        public int get_age(DateTime dob)
        {
            try
            {
                int age = DateTime.Now.AddYears(-dob.Year).Year;

                if (age < 18)
                {
                    throw new Exception("Cannot Enroll – Below 18 years");
                }
                return age;

            }
            catch (Exception e)
            {
                MessageBox.Show("Cannot Enroll – Below 18 years", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return 0;
            }
        }

        public bool validate_form(object obj)
        {
            ST_Enroll_UI form = (ST_Enroll_UI)obj;
            bool status = false;

            if (form.txt_regNumber.Text.Equals(""))
            {
                status = true;
            }
            else if (form.txt_studentName.Text.Equals(""))
            {
                status = true;
            }
            else if (get_age(DateTime.Parse(form.pik_date.Text)) < 18)
            {
                status = true;
            }
            else if (!form.rdbtn_male.Checked && !form.rdbtn_female.Checked)
            {
                status = true;
            }
            else if (form.txt_contact.Text.Equals("") || form.txt_contact.Text.Length != 10)
            {
                status = true;
            }
            else if (form.cmb_courses.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }

        //Database functions

        public bool insert_student(Student student)
        {
            try
            {
                MySqlConnection connection = DBconnection.getConnection();

                string query = Constants.insert_student;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@regno", student.regno);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@dob", student.dob);
                cmd.Parameters.AddWithValue("@gender", student.gender);
                cmd.Parameters.AddWithValue("@contact", student.contact);
                cmd.Parameters.AddWithValue("@course", student.course);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                DBconnection.closeConnection();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public Student find_student_by_regno(int regno)
        {
            Student student = new Student();

            try
            {
                MySqlConnection connection = DBconnection.getConnection();

                string query = Constants.get_student_by_regno;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@regno", regno);
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        student.regno = reader.GetInt32(0);
                        student.name = reader.GetString(1);
                        student.dob = reader.GetDateTime(2);
                        student.gender = reader.GetChar(3);
                        student.contact = reader.GetInt32(4);
                        student.course = reader.GetString(5);
                        student.status = true;
                    }

                    reader.Close();
                    DBconnection.closeConnection();

                    return student;
                }
                else
                {
                    reader.Close();
                    DBconnection.closeConnection();
                    return student;
                }
            }
            catch (Exception e)
            {
                DBconnection.closeConnection();
                student.status = false;
                return student;
            }
        }

        public bool delete_student_by_regno(int regno)
        {
            try
            {
                MySqlConnection connection = DBconnection.getConnection();

                string query = Constants.delete_student_by_regno;
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("regno", regno);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
                DBconnection.closeConnection();

                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
