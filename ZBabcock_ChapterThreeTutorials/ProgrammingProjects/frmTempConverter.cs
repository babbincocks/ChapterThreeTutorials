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
    public partial class frmTempConverter : Form
    {
        public frmTempConverter()
        {
            InitializeComponent();
        }

        private void btnToCelsius_Click(object sender, EventArgs e)
        {
            try
            {/*
                As this is for a temperature converter, I have two buttons: one for fahrenheit to celsius (this button),
                and one for celsius to fahrenheit. This button works by taking the value that someone put in the Input
                Temperature text box, turns it into the double data type and puts it into an alias (fahr). Then another
                alias is created that takes the value that's representing fahrenheit, and puts it into the formula that
                converts fahrenheit to celsius (9/5 / (F - 32)). After that, I take the resulting value, and put it 
                into the Output Temperature text field.
             */
                double fahr = double.Parse(txtInput.Text);
                double cels = (fahr - 32.0) / 1.8;

                lblOutput.Text = cels.ToString();
            }

            catch
            { //This is just the error message that will arise in the event that a user, say, put's "a" in for the input.
                MessageBox.Show("There seems to have been an error. As the kids say, 'GG no re'.");

            }
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            { /*
                This is the code for the To Fahrenheit button instead, which functions very similarly to the To Celsius
                button, unsurprisingly. Instead though, it starts with the input being treated as celsius, and puts it
                into the formula to convert celsius to fahrenheit ((9/5 * C) + 32). I put it in the format I did, as the
                order of operations ensures that it'll still come to the correct result. That result is put into the 
                text box for the Output Temperature.
                */
                double cels = double.Parse(txtInput.Text);
                double fahr = cels * 1.8 + 32;

                lblOutput.Text = fahr.ToString();
            }
            catch
            { //Same error message as last time again.
                MessageBox.Show("There seems to have been an error. As the kids say, 'GG no re'.");

            }
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
            frmBMI a = new frmBMI();
            a.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        { /*
            This is the code for the Clear button, where it will turn the text value for the input field and the 
            output field into a null value when the button is clicked.
          */
            txtInput.Text = "";
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
