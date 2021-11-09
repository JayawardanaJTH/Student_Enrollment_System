using Student_Enrolment_System.Controllers;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Student_Enrolment_System
{
    public partial class ST_Enroll_UI : Form
    {
        private IFormController formController = new FormController();

        public ST_Enroll_UI()
        {
            InitializeComponent();
            cmb_courses.SelectedIndex = 0;
        }

        //performed when choose a date
        private void pik_date_CloseUp(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(pik_date.Text);
            int age = formController.get_age(dob);
            txt_age.Text = age.ToString();
        }

        //preformed when press the insert button
        private void btn_insert_Click(object sender, EventArgs e)
        {
            bool formStatus = formController.validate_form(this);

            if (formStatus)
            {
                MessageBox.Show("Complete the Missing Data", "Data Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Student Inserted Successfully", "Data Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
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
