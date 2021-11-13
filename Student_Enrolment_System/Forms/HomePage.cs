using System;
using System.Windows.Forms;

namespace Student_Enrolment_System.Forms
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ST_Enroll_UI Form = new ST_Enroll_UI();
            Form.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            this.Hide();

            CourseFeePage Form = new CourseFeePage();
            Form.Show();
        }
    }
}
