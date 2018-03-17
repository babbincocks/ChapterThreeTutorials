namespace ProgrammingProjects
{
    partial class frmPaintJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.txtBasePaint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGallonNumber = new System.Windows.Forms.Label();
            this.txtWallSpace = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLaborHours = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPaintCost = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblLaborCost = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Paint Price (per gallon)";
            // 
            // txtBasePaint
            // 
            this.txtBasePaint.Location = new System.Drawing.Point(21, 151);
            this.txtBasePaint.Name = "txtBasePaint";
            this.txtBasePaint.Size = new System.Drawing.Size(130, 20);
            this.txtBasePaint.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "# of Paint Gallons Needed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Wall Space (in sq. ft.)";
            // 
            // lblGallonNumber
            // 
            this.lblGallonNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGallonNumber.Location = new System.Drawing.Point(237, 48);
            this.lblGallonNumber.Name = "lblGallonNumber";
            this.lblGallonNumber.Size = new System.Drawing.Size(130, 20);
            this.lblGallonNumber.TabIndex = 25;
            this.lblGallonNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWallSpace
            // 
            this.txtWallSpace.Location = new System.Drawing.Point(21, 69);
            this.txtWallSpace.Name = "txtWallSpace";
            this.txtWallSpace.Size = new System.Drawing.Size(130, 20);
            this.txtWallSpace.TabIndex = 24;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(328, 286);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 43);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(223, 286);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 43);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 286);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(86, 43);
            this.btnNext.TabIndex = 21;
            this.btnNext.Text = "Next Problem";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(116, 286);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(86, 43);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Hours of Labor";
            // 
            // lblLaborHours
            // 
            this.lblLaborHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborHours.Location = new System.Drawing.Point(237, 91);
            this.lblLaborHours.Name = "lblLaborHours";
            this.lblLaborHours.Size = new System.Drawing.Size(130, 20);
            this.lblLaborHours.TabIndex = 30;
            this.lblLaborHours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cost for Paint";
            // 
            // lblPaintCost
            // 
            this.lblPaintCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaintCost.Location = new System.Drawing.Point(237, 135);
            this.lblPaintCost.Name = "lblPaintCost";
            this.lblPaintCost.Size = new System.Drawing.Size(130, 20);
            this.lblPaintCost.TabIndex = 32;
            this.lblPaintCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Cost for Labor";
            // 
            // lblLaborCost
            // 
            this.lblLaborCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLaborCost.Location = new System.Drawing.Point(237, 178);
            this.lblLaborCost.Name = "lblLaborCost";
            this.lblLaborCost.Size = new System.Drawing.Size(130, 20);
            this.lblLaborCost.TabIndex = 34;
            this.lblLaborCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Total Cost for Job";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCost.Location = new System.Drawing.Point(237, 225);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(130, 20);
            this.lblTotalCost.TabIndex = 36;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPaintJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 341);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLaborCost);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPaintCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblLaborHours);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBasePaint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGallonNumber);
            this.Controls.Add(this.txtWallSpace);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmPaintJob";
            this.Text = "Paint Job Estimator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBasePaint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGallonNumber;
        private System.Windows.Forms.TextBox txtWallSpace;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLaborHours;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPaintCost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblLaborCost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalCost;
    }
}