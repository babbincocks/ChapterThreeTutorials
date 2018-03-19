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
        //As there were so many forms to work with, I created a directory that makes it easier and faster for the user 
        //to get to the problem that is desired, with each problem getting a button.
        private void btnNameFormat_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Name Formatter.
            frmNameFormat a = new frmNameFormat();
            a.Show();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
          //Since this is the main form, it will also close any other open forms as well.
            this.Close();
        }

        private void btnTipTaxTotal_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Tip, Tax, and Total.
            frmTipTaxTotal a = new frmTipTaxTotal();
            a.Show();
        }

        private void btnTravelDistance_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Distance Traveled.
            frmTravelDistance a = new frmTravelDistance();
            a.Show();
        }

        private void btnSalesTaxTotal_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Sales Tax and Total.
            frmSalesTaxTotal a = new frmSalesTaxTotal();
            a.Show();
        }

        private void btnTempConvert_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Celsius and Fahrenheit Temperature Converter.
            frmTempConverter a = new frmTempConverter();
            a.Show();
        }

        private void btnBMI_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the BMI form.
            frmBMI a = new frmBMI();
            a.Show();
        }

        private void btnSentenceBuild_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Sentence Builder.
            frmSentenceBuild a = new frmSentenceBuild();
            a.Show();
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the How Much Insurance? form.
            frmInsurance a = new frmInsurance();
            a.Show();
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Cookie Calories form.
            frmCookies a = new frmCookies();
            a.Show();
        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Calorie Counter form.
            frmCalories a = new frmCalories();
            a.Show();
        }

        private void btnAutomobile_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Automobile Costs form.
            frmAutomobile a = new frmAutomobile();
            a.Show();
        }

        private void btnPaintJob_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Paint Job Estimator.
            frmPaintJob a = new frmPaintJob();
            a.Show();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Property Tax form.
            frmPropertyTax a = new frmPropertyTax();
            a.Show();
        }

        private void btnStadium_Click(object sender, EventArgs e)
        {
            //This one opens a new form of the Stadium Seating form.
            frmStadiumSeating a = new frmStadiumSeating();
            a.Show();
        }
    }
}
