﻿using System;
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
    public partial class frmCalories : Form
    {
        public frmCalories()
        {
            InitializeComponent();
        }

        /*
         To start off, since I'll have multiple buttons manipulating a single variable (all of them adding calories to 
         the total) that needs to remain consistent, I created the variable (calories) outside any of the button 
         controls. Then I had all of the buttons increment this variable by their respective amounts displayed on their
         photos.
         */
        int calories = 0;

        private void pbApple_Click(object sender, EventArgs e)
        {//This one increments it by 80, and displays the new result to the output text box.
            calories = calories + 80;
            lblOutput.Text = calories.ToString();
        }

        private void pbBanana_Click(object sender, EventArgs e)
        {//This one increments it by 115, and displays the new result to the output text box.
            calories = calories + 115;
            lblOutput.Text = calories.ToString();
        }

        private void pbOrange_Click(object sender, EventArgs e)
        {//This one increments it by 90, and displays the new result to the output text box.
            calories = calories + 90;
            lblOutput.Text = calories.ToString();
        }

        private void pbPear_Click(object sender, EventArgs e)
        {//This one increments it by 120, and displays the new result to the output text box.
            calories = calories + 120;
            lblOutput.Text = calories.ToString();
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
            frmAutomobile a = new frmAutomobile();
            a.ShowDialog();
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//This button clears the output text box for the current total calories, and also resets the calories variable
            //back to 0.
            lblOutput.Text = "";
            calories = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //Here's the code for the Exit button. All it does is focuses on the scope of this form and tells it to close.
            this.Close();
        }
    }
}
