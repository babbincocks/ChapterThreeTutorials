using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3_2
{
    public partial class frmFuelEco : Form
    {
        public frmFuelEco()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double miles = double.Parse(milesTextBox.Text);
                double gallons = double.Parse(gallonsTextBox.Text);
                double mpg = miles / gallons;

                mpgLabel.Text = mpg.ToString();
            }
            catch
            {
                MessageBox.Show("It seems the information you entered was invalid. You put in numbers, right?");

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
