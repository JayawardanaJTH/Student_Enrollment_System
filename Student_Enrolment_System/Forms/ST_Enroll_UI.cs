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
        private IFormController _formController = new FormController();

        //enum for gender
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
            int age = _formController.get_age(dob);
            txt_age.Text = age.ToString();
        }

        /**
            <summary>Allow only numerical values for contact</summary>
        */
        private void txt_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /**
            <summary>Allow only numerical values for registration number</summary>
        */
        private void txt_regNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
            btn_insert.Enabled = true;
            btn_delete.Enabled = true;
            btn_insert.ButtonColor = System.Drawing.SystemColors.Highlight;
            btn_delete.ButtonColor = System.Drawing.SystemColors.Highlight;
        }

        private void txt_regNumber_Leave(object sender, EventArgs e)
        {
            if (!txt_regNumber.Text.Equals(""))
            {
                bool result = _formController.find_student_by_regno(int.Parse(txt_regNumber.Text));
                if (result)
                {
                    btn_insert.Enabled = false;
                    btn_insert.ButtonColor = System.Drawing.SystemColors.ControlDark;

                    btn_delete.Enabled = true;
                    btn_delete.ButtonColor = System.Drawing.SystemColors.Highlight;
                }
                else
                {
                    btn_insert.Enabled = true;
                    btn_insert.ButtonColor = System.Drawing.SystemColors.Highlight;

                    btn_delete.Enabled = false;
                    btn_delete.ButtonColor = System.Drawing.SystemColors.ControlDark;
                }
            }
        }

        //----Button functions implementation----

        private void btn_insert_Click(object sender, EventArgs e)
        {
            bool formStatus = _formController.validate_form(this);

            if (formStatus)
            {
                MessageBox.Show("Complete the Missing Data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    char gender;

                    if (rdbtn_female.Checked)
                    {
                        gender = (char)Gender.Female;
                    }
                    else
                    {
                        gender = (char)Gender.Male;
                    }

                    Student student_ob = new Student(Int32.Parse(txt_regNumber.Text), txt_studentName.Text
                        , DateTime.Parse(pik_date.Text), gender, Int32.Parse(txt_contact.Text), cmb_courses.SelectedItem.ToString());

                    bool result = _formController.insert_student(student_ob);

                    if (result)
                    {
                        MessageBox.Show("Student Inserted Successfully", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data insertion error", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //if yes returns 6 and if no returns 7
            int result = (Int32)MessageBox.Show("Confirm  Delete Yes/No", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == 6)
            {
                _formController.delete_student_by_regno(Int32.Parse(txt_regNumber.Text));
                MessageBox.Show("Student Deleted Successfully", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            formatForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
