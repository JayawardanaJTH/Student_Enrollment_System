using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ST_Enroll_UI form = (ST_Enroll_UI) obj;
            bool status = false;

            if (form.txt_regNumber.Text.Equals(""))
            {
                status = true;
            }
           else if(form.txt_studentName.Text.Equals(""))
            {
                status = true;
            }
            else if(get_age(DateTime.Parse(form.pik_date.Text)) < 18)
            {
                status = true;
            }
            else if (!form.rdbtn_male.Checked && !form.rdbtn_female.Checked)
            {
                status = true;
            }
            else if(form.txt_contact.Text.Equals("") || form.txt_contact.Text.Length != 10)
            {
                status = true;
            }
            else if(form.cmb_courses.SelectedIndex == 0)
            {
                status = true;
            }
            else
            {
                status = false;
            }

            return status;
        }
    }
}
