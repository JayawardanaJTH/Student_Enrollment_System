using Student_Enrolment_System.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrolment_System
{
    public partial class ST_Enroll_UI : Form
    {
        private IFormController formController = new FormController();

        public ST_Enroll_UI()
        {
            InitializeComponent();

        }

        private void pik_date_CloseUp(object sender, EventArgs e)
        {
            DateTime dob = DateTime.Parse(pik_date.Text);
            int age = formController.get_age(dob);
            txt_age.Text = age.ToString();
        }
    }
}
