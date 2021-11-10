using MySql.Data.MySqlClient;
using Student_Enrolment_System.Controllers;
using Student_Enrolment_System.Models;
using Student_Enrolment_System.Utility;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Student_Enrolment_System
{
    public partial class ST_Enroll_UI : Form
    {
        private IFormController formController = new FormController();

        enum Gender
        {
            Male = 'M',
            Female = 'F'
        }

        public ST_Enroll_UI()
        {
            InitializeComponent();
            cmb_courses.SelectedIndex = 0;
        }

        //performed when choose a date
        private void pik_date_CloseUp(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(pik_date.Text);
            //int age = formController.get_age(dob);
            //txt_age.Text = age.ToString();
        }

        //preformed when press the insert button
        private void btn_insert_Click(object sender, EventArgs e)
        {
            //bool formStatus = formController.validate_form(this);

            //if (formStatus)
            //{
            // MessageBox.Show("Complete the Missing Data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            // else
            //{
            try
            {
                char gender;
                IFormController form = new FormController();

                if (rdbtn_female.Checked)
                {
                    gender = (char)Gender.Female;
                }
                else
                {
                    gender = (char)Gender.Male;
                }

                Student student_ob = new Student(Int32.Parse(txt_regNumber.Text.ToString()), txt_studentName.Text.ToString()
                    , DateTime.Parse(pik_date.Text.ToString()), gender, Int32.Parse(txt_contact.Text.ToString()),cmb_courses.SelectedItem.ToString());

                bool result = form.insert_student(student_ob);

                if (result)
                {
                    MessageBox.Show("Student Inserted Successfully", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                }
                else
                {
                    throw new Exception();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Data insertion error", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //}
        }

        /**
            <summary>Allow only numerical values</summary>
        */
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            string contact = txt_contact.Text;

            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //if yes returns 6 and if no returns 7
            int result = (Int32)MessageBox.Show("Confirm  Delete Yes/No", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            formatForm();
        }

        private void formatForm()
        {
            txt_studentName.Clear();
            txt_regNumber.Clear();
            rdbtn_female.Checked = false;
            rdbtn_male.Checked = false;
            pik_date.Text = DateTime.Now.ToString();
            txt_age.Text = "0";
            txt_contact.Clear();
            cmb_courses.SelectedIndex = 0;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
