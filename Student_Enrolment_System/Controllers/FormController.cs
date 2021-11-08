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
    }
}
