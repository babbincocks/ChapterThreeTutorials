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
            
            this.Close();
        }


    }
}
