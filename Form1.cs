using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            {

                cmbDay.Items.Add("-Day-");
                cmbMonth.Items.Add("-Month-");
                cmbYear.Items.Add("-Year-");



                for (int day = 1; day <= 31; day++)
                {
                    cmbDay.Items.Add(day);
                }


                for (int month = 1; month <= 12; month++)
                {
                    cmbMonth.Items.Add(month);
                }


                int currentYear = DateTime.Now.Year;
                for (int year = 1900; year <= currentYear; year++)
                {
                    cmbYear.Items.Add(year);
                }


                cmbDay.SelectedIndex = 0;
                cmbMonth.SelectedIndex = 0;
                cmbYear.SelectedIndex = 0;
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(LastNametxt.Text))
            {
                MessageBox.Show("Please enter the last name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LastNametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstNametxt.Text))
            {
                MessageBox.Show("Please enter the first name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FirstNametxt.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(MiddleNametxt.Text))
            {
                MessageBox.Show("Please enter the middle name.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MiddleNametxt.Focus();
                return;
            }

            if (!MALE.Checked && !FEMALE.Checked)
            {
                MessageBox.Show("Please select a gender.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbDay.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a day.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbMonth.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a month.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbYear.SelectedIndex == 0)
            {
                MessageBox.Show("Please select a year.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string day = cmbDay.SelectedItem.ToString();
            string month = cmbMonth.SelectedItem.ToString();
            string year = cmbYear.SelectedItem.ToString();

            string gender = "";
            if (MALE.Checked)
            {
                gender = "Male";
            }
            else if (FEMALE.Checked)
            {
                gender = "Female";
            }

            string fullName = FirstNametxt.Text + " " + MiddleNametxt.Text + " " + LastNametxt.Text;


            string dateOfBirth = day + "/" + month + "/" + year;


            string message = "Student name: " + fullName + "\n"
                           + "Gender: " + gender + "\n"
                           + "Date of birth: " + dateOfBirth;

            MessageBox.Show(message);
        }
    }
}



