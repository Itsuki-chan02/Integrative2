using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string id = txtStudentID.Text;
            string fname = txtFirstName.Text;
            string lname = txtLastName.Text;

           
            StudentInfo student = new StudentInfo(id, fname, lname);

            
            lstStudentID.Items.Add(student.StudentID);
            lstFirstName.Items.Add(student.FirstName);
            lstLastName.Items.Add(student.LastName);

            
            txtStudentID.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStudentID.Focus();
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
