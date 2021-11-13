using Student_Enrolment_System.Controllers;
using Student_Enrolment_System.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Enrolment_System.Forms
{
    public partial class CourseFeePage : Form
    {
        private IFormController _FormController = new FormController();

        public CourseFeePage()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            List<int> RegistrationNumbers = _FormController.GetRegistraionNumbers();

            if (RegistrationNumbers != null)
            {
                int Size = RegistrationNumbers.Count + 1;
                int Counter = 0;
                Object[] Items = new object[Size];

                Items.SetValue("Select", Counter);

                foreach (var Item in RegistrationNumbers)
                {
                    Counter++;
                    Items.SetValue(Item,Counter);
                }

                cmb_regno.Items.AddRange(Items);
                cmb_regno.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please input at least one student", "No student data found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public double GetTotal()
        {
            double Amount = 0.00;
            double Discount = 0.00;
            double Total = 0.00;

            if (!txt_amount.Text.Equals(string.Empty))
            {
                Amount = Double.Parse(txt_amount.Text);
            }

            if (!txt_discount.Text.Equals(string.Empty))
            {
                Discount = Double.Parse(txt_discount.Text);
            }

            Total = Amount * ((100 - Discount) / 100);

            return Total;

        }
        //button functions

        private void btn_home_Click(object sender, EventArgs e)
        {
            Hide();

            HomePage Home = new HomePage();
            Home.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        private void btn_saveFee_Click(object sender, EventArgs e)
        {
            if((cmb_regno.SelectedIndex != 0) && (!txt_total.Text.Equals(string.Empty)))
            {
                double Amount = double.Parse(txt_amount.Text);
                double Discount = double.Parse(txt_discount.Text);
                double Total = double.Parse(txt_total.Text);
                int RegNo = Int32.Parse(cmb_regno.SelectedItem.ToString());

                CourseFee Fee = new CourseFee(RegNo,Amount,Discount,Total);
                bool IsSuccess = _FormController.InsertCourseFee(Fee);

                if (IsSuccess)
                {
                    MessageBox.Show("Course fee inserted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new Exception();
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields", "Data missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsControl(e.KeyChar)) && (!Char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txt_amount_Leave(object sender, EventArgs e)
        {
            txt_total.Text = GetTotal().ToString();
        }

        private void txt_discount_Leave(object sender, EventArgs e)
        {
            txt_total.Text = GetTotal().ToString();
        }
    }
}
