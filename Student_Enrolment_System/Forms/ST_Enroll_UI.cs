using MySql.Data.MySqlClient;
using Student_Enrolment_System.Controllers;
using Student_Enrolment_System.Forms;
using Student_Enrolment_System.Models;
using Student_Enrolment_System.Utility;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Student_Enrolment_System
{
    public partial class ST_Enroll_UI : Form
    {
        private IFormController _FormController = new FormController();

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
            DateTime Birthday = DateTime.Parse(pik_date.Text);
            int Age = _FormController.GetAge(Birthday);
            txt_age.Text = Age.ToString();
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
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = true;
            }

            //check is the pressed key is Enter
            if (e.KeyChar == (char)Keys.Enter)
            {
                FindStudent();
            }
            btn_exit.Enabled = false;
            btn_exit.ButtonColor = System.Drawing.SystemColors.ControlDark;
        }

        private void txt_regNumber_Leave(object sender, EventArgs e)
        {
            FindStudent();
        }

        private void FormatForm()
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
            btn_exit.Enabled = true;
            btn_insert.ButtonColor = System.Drawing.SystemColors.Highlight;
            btn_delete.ButtonColor = System.Drawing.SystemColors.Highlight;
            btn_exit.ButtonColor = System.Drawing.Color.Red;
        }

        private void FindStudent()
        {
            if (!txt_regNumber.Text.Equals(""))
            {
                Student Result = _FormController.FindStudentByRegno(int.Parse(txt_regNumber.Text));
                if (Result.Status)
                {
                    txt_studentName.Text = Result.Name;
                    pik_date.Value = Result.Birthday;
                    txt_contact.Text = Result.Contact.ToString();
                    cmb_courses.SelectedItem = Result.Course;

                    if (Result.Gender.Equals((Char)Gender.Male))
                    {
                        rdbtn_male.Checked = true;
                        rdbtn_female.Checked = false;
                    }
                    else
                    {
                        rdbtn_female.Checked = true;
                        rdbtn_male.Checked = false;
                    }

                    txt_age.Text = _FormController.GetAge(Result.Birthday).ToString();

                    btn_insert.Enabled = false;
                    btn_insert.ButtonColor = System.Drawing.SystemColors.ControlDark;

                    btn_delete.Enabled = true;
                    btn_delete.ButtonColor = System.Drawing.SystemColors.Highlight;
                }
                else
                {
                    txt_studentName.Text = "";
                    pik_date.Value = DateTime.Now;
                    txt_contact.Text = "";
                    cmb_courses.SelectedIndex = 0;
                    rdbtn_female.Checked = false;
                    rdbtn_male.Checked = false;
                    txt_age.Text = "";

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
            bool FormStatus = _FormController.ValidatForm(this);

            if (FormStatus)
            {
                MessageBox.Show("Complete the Missing Data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    char Gender;

                    if (rdbtn_female.Checked)
                    {
                        Gender = (char)ST_Enroll_UI.Gender.Female;
                    }
                    else
                    {
                        Gender = (char)ST_Enroll_UI.Gender.Male;
                    }

                    Student StudentObject = new Student(Int32.Parse(txt_regNumber.Text), txt_studentName.Text
                        , DateTime.Parse(pik_date.Text), Gender, Int32.Parse(txt_contact.Text), cmb_courses.SelectedItem.ToString());

                    bool Result = _FormController.InsertStudent(StudentObject);

                    if (Result)
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
            int Result = (Int32)MessageBox.Show("Confirm  Delete Yes/No", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Result == 6)
            {
                _FormController.DeleteStudentByRegno(Int32.Parse(txt_regNumber.Text));
                MessageBox.Show("Student Deleted Successfully", "Data Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            FormatForm();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();

            HomePage Home = new HomePage();
            Home.Show();
        }
    }
}
