using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingProjects
{
    public partial class frmBMI : Form
    {
        public frmBMI()
        {
            InitializeComponent();
        }

        /*
        This bit of code below sets the functionality of the Next Problem button. It starts off with hiding this window,
        so as to more seamlessly transition. Then it creates a new form of the next problem in the book, and shows it.
        The reason I used ShowDialog, as opposed to just Show is that I wanted to switch over to the next problem with
        no remnants of the previous so it can be properly closed, and using ShowDialog shows the new form modally 
        (making it so directly returning to the previous form [so... THIS form] is impossible), as opposed to Show's 
        nonmodal format. Using Show makes it so the next line of code that is supposed to just close this form instead 
        closes all forms. Still not 100% certain why, but yeah, that happens.
        */
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSentenceBuild a = new frmSentenceBuild();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        { /*
           This form calculates Body Mass Index, which requires a person's height and weight, hence the two text boxes
           in the form that are meant to accept those. Due to that, this button takes the values put in those text
           boxes and turns them into variables that are used to calculate the value for a new variable for what the 
           returned BMI will be using the formula "W * 703 / H2(squared)". This is then put into the output text box
           on the right, which will be restricted to having only 3 decimal places, so it doesn't become too overwhelming.
            */
            try
            {
                double weight = double.Parse(txtWeight.Text);
                double height = double.Parse(txtHeight.Text);
                double BMI = weight * 703 / (height * height);

                lblOutput.Text = BMI.ToString("N3");
            }
            catch
            { //This is just the error message that will arise in the event that a user, say, put's "a" in for the input.
                MessageBox.Show("There seems to be an issue with your input. Perhaps the values you put in weren't entirely numeric?");

            }
        }



        private void btnClear_Click(object sender, EventArgs e)
        {
            /*
            This is the code for the Clear button, where it will turn the text value for all of the input fields and the 
            output field into a null value.
          */
            txtHeight.Text = "";
            txtWeight.Text = "";
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }


    }
}
