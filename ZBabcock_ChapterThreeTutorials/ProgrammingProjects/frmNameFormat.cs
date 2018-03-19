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
    public partial class frmNameFormat : Form
    {
        public frmNameFormat()
        {
            InitializeComponent();
        }

         

        private void btnPFML_Click(object sender, EventArgs e)
        {/*
            So we are simply setting up a name formatter, so I created a variable for the inputted first name, another one
            for the middle name, the last name, and another for the title/prefix. Then I simply put the variables in the
            order that this button specifies.
            */
            try
            {
                string first = txtFirst.Text;
                string middle = txtMiddle.Text;
                string last = txtLast.Text;
                string title = txtPrefix.Text;
                string name = title + " " + first + " " + middle + " " + last;

                lblNameDisplay.Text = name;
            }
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }

        }

        private void btnFML_Click(object sender, EventArgs e)
        { //Same as the previous button.
            try
            {
                string first = txtFirst.Text;
                string middle = txtMiddle.Text;
                string last = txtLast.Text;
                string name = first + " " + middle + " " + last;

                lblNameDisplay.Text = name;
            }
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }
        }

        private void btnFL_Click(object sender, EventArgs e)
        { //Same as the previous button.
            try
            {
                string first = txtFirst.Text;
                string last = txtLast.Text;
                string name = first + " " + last;

                lblNameDisplay.Text = name;
            }
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }
        }

        private void btnLFMP_Click(object sender, EventArgs e)
        { //Same as the previous button.
            try
            {
                string first = txtFirst.Text;
                string middle = txtMiddle.Text;
                string last = txtLast.Text;
                string title = txtPrefix.Text;
                string name = last + ", " + first + " " + middle + ", " + title;

                lblNameDisplay.Text = name;
            }
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }
        }

        private void btnLFM_Click(object sender, EventArgs e)
        { //Same as the previous button.
            try
            {
                string first = txtFirst.Text;
                string middle = txtMiddle.Text;
                string last = txtLast.Text;
                string title = txtPrefix.Text;
                string name = last + ", " + first + " " + middle;

                lblNameDisplay.Text = name;
            }
        
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }
        }

        private void btnLF_Click(object sender, EventArgs e)
        {   //Same as the previous button.
            try { 
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first;

                lblNameDisplay.Text = name;
        }
            catch
            {
                MessageBox.Show("Not sure how you caused this error. Good on you, mate.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        { /*
            This, the Clear button, simply takes all of the text fields of the name input text boxes, and the display
            area for the full name, and sets their value to NULL.
            */
            txtFirst.Text = "";
            txtMiddle.Text = "";
            txtLast.Text = "";
            txtPrefix.Text = "";
            lblNameDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
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
        private void btnNextProblem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTipTaxTotal a = new frmTipTaxTotal();
            a.ShowDialog();
            this.Close();
            
        }
    }
}
