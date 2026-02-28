using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double eng = Convert.ToDouble(Eng.Text);
            double math = Convert.ToDouble(maths.Text);
            double sci = Convert.ToDouble(Sci.Text);
            double fil = Convert.ToDouble(Fil.Text);
            double his = Convert.ToDouble(His.Text);

            double average = (eng + math + math + sci + his) / 5;
            lblStatus.Text = (average >= 75.00) ? "The student passed." : "The student failed.";

            lblAverage.Text = $"The general average of {NameBox.Text} is {average:F2}.";
        

            try
            {

            }
            catch (FormatException)
            {
                MessageBox.Show("please enter valid number");
            }

        




    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblAverage_Click(object sender, EventArgs e)
        {

        }
    }
    }
    
    

