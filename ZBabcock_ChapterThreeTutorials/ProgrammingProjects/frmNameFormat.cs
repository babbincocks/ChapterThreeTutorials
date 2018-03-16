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
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = title + " " + first + " " + middle + " " + last;

                lblNameDisplay.Text = name;

        }

        private void btnFML_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string name = first + " " + middle + " " + last;

            lblNameDisplay.Text = name;
        }

        private void btnFL_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string last = txtLast.Text;
            string name = first + " " + last;

                lblNameDisplay.Text = name;
        }

        private void btnLFMP_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first + " " + middle + ", " + title;

                lblNameDisplay.Text = name;
        }

        private void btnLFM_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first + " " + middle;

                lblNameDisplay.Text = name;
        }

        private void btnLF_Click(object sender, EventArgs e)
        {
            string first = txtFirst.Text;
            string middle = txtMiddle.Text;
            string last = txtLast.Text;
            string title = txtPrefix.Text;
            string name = last + ", " + first;

                lblNameDisplay.Text = name;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Text = "";
            txtMiddle.Text = "";
            txtLast.Text = "";
            txtPrefix.Text = "";
            lblNameDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNextProblem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTipTaxTotal a = new frmTipTaxTotal();
            a.ShowDialog();
            this.Close();
            
        }
    }
}
