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
            {
                double fahr = double.Parse(txtInput.Text);
                double cels = (fahr - 32.0) / 1.8;

                lblOutput.Text = cels.ToString();
            }

            catch
            {
                MessageBox.Show("There seems to have been an error. As the kids say, 'GG no re'.");

            }
        }

        private void btnToFahrenheit_Click(object sender, EventArgs e)
        {
            try
            {
                double cels = double.Parse(txtInput.Text);
                double fahr = cels * 1.8 + 32;

                lblOutput.Text = fahr.ToString();
            }
            catch
            {
                MessageBox.Show("There seems to have been an error. As the kids say, 'GG no re'.");

            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBMI a = new frmBMI();
            a.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblOutput.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
