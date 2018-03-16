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
    public partial class frmDirectory : Form
    {
        public frmDirectory()
        {
            InitializeComponent();
        }

        private void btnNameFormat_Click(object sender, EventArgs e)
        {
            
            frmNameFormat a = new frmNameFormat();
            a.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTipTaxTotal_Click(object sender, EventArgs e)
        {
            frmTipTaxTotal a = new frmTipTaxTotal();
            a.Show();
        }

        private void btnTravelDistance_Click(object sender, EventArgs e)
        {
            frmTravelDistance a = new frmTravelDistance();
            a.Show();
        }

        private void btnSalesTaxTotal_Click(object sender, EventArgs e)
        {
            frmSalesTaxTotal a = new frmSalesTaxTotal();
            a.Show();
        }

        private void btnTempConvert_Click(object sender, EventArgs e)
        {
            frmTempConverter a = new frmTempConverter();
            a.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            frmBMI a = new frmBMI();
            a.Show();
        }

        private void btnSentenceBuild_Click(object sender, EventArgs e)
        {
            frmSentenceBuild a = new frmSentenceBuild();
            a.Show();
        }
    }
}
