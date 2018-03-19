using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZBabcock_ChapterThreeTutorials
{
    public partial class frmBirthDate : Form
    {
        public frmBirthDate()
        {
            InitializeComponent();
        }

        private void showDateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fullDate = dayOfWeekTextBox.Text + ", " + monthTextBox.Text + " " + dayOfMonthTextBox.Text + ", "
                                    + yearTextBox.Text;

                dateOutputLabel.Text = fullDate;
            }
            catch
            {

                MessageBox.Show("There was an error displaying your birth date information.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*
            This is the code for the Clear button, where it will turn the text value for all of the input fields and the 
            output field into a null value. For the record, I only really put this in a try...catch block so I could
            put that message box which will probably be never displayed, since I have no idea how a user could remotely
            delete any of those controls. If they do manage that, well, I suppose then they would.
          */
                dayOfWeekTextBox.Text = "";
                monthTextBox.Text = "";
                dayOfMonthTextBox.Text = "";
                yearTextBox.Text = "";
                dateOutputLabel.Text = "";
            }
            catch
            {
                MessageBox.Show("Not sure how that went wrong. It was probably your fault. How rude.");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
          //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }


    }
}
