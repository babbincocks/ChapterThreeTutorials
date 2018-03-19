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
    public partial class frmCookies : Form
    {
        public frmCookies()
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
            frmCalories a = new frmCalories();
            a.ShowDialog();
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {/*
                As this is a button to just calculate how many calories are in an inputted number of cookies, and they
                all have 75 calories, the solution is just a matter of simple multiplication. I created a single variable
                for the number of calories and had it equal the value put in for the number of cookies, and multiplied
                it by 75. I then took the new value, and inserted it into the text field of the Calories text box.
                */
                double calories = double.Parse(txtCookies.Text) * 75;

                lblCalories.Text = calories.ToString();
            }
            catch
            {
                MessageBox.Show("There seems to be something wrong with your input.");

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//This resets the values of the Cookie Number input text box and the Total Calories output text box to a NULL value.
            txtCookies.Text = "";
            lblCalories.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
