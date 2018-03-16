namespace ProgrammingProjects
{
    partial class frmSalesTaxTotal
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
            this.lblTotalText = new System.Windows.Forms.Label();
            this.lblCountyText = new System.Windows.Forms.Label();
            this.lblStateText = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.txtPurchase = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblTaxText = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTotalText
            // 
            this.lblTotalText.AutoSize = true;
            this.lblTotalText.Location = new System.Drawing.Point(344, 167);
            this.lblTotalText.Name = "lblTotalText";
            this.lblTotalText.Size = new System.Drawing.Size(55, 13);
            this.lblTotalText.TabIndex = 23;
            this.lblTotalText.Text = "Sale Total";
            // 
            // lblCountyText
            // 
            this.lblCountyText.AutoSize = true;
            this.lblCountyText.Location = new System.Drawing.Point(344, 76);
            this.lblCountyText.Name = "lblCountyText";
            this.lblCountyText.Size = new System.Drawing.Size(61, 13);
            this.lblCountyText.TabIndex = 22;
            this.lblCountyText.Text = "County Tax";
            // 
            // lblStateText
            // 
            this.lblStateText.AutoSize = true;
            this.lblStateText.Location = new System.Drawing.Point(344, 30);
            this.lblStateText.Name = "lblStateText";
            this.lblStateText.Size = new System.Drawing.Size(53, 13);
            this.lblStateText.TabIndex = 21;
            this.lblStateText.Text = "State Tax";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(11, 31);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(91, 13);
            this.lblInstruction.TabIndex = 20;
            this.lblInstruction.Text = "Purchase Amount";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(313, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 22);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(215, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next Problem";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(116, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 22);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(225, 164);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(103, 19);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCounty
            // 
            this.lblCounty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCounty.Location = new System.Drawing.Point(225, 73);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(103, 19);
            this.lblCounty.TabIndex = 15;
            this.lblCounty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblState
            // 
            this.lblState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblState.Location = new System.Drawing.Point(225, 28);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(103, 19);
            this.lblState.TabIndex = 14;
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPurchase
            // 
            this.txtPurchase.Location = new System.Drawing.Point(105, 28);
            this.txtPurchase.Name = "txtPurchase";
            this.txtPurchase.Size = new System.Drawing.Size(100, 20);
            this.txtPurchase.TabIndex = 13;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(18, 211);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(87, 23);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblTaxText
            // 
            this.lblTaxText.AutoSize = true;
            this.lblTaxText.Location = new System.Drawing.Point(344, 123);
            this.lblTaxText.Name = "lblTaxText";
            this.lblTaxText.Size = new System.Drawing.Size(52, 13);
            this.lblTaxText.TabIndex = 25;
            this.lblTaxText.Text = "Total Tax";
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Location = new System.Drawing.Point(225, 120);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(103, 19);
            this.lblTax.TabIndex = 24;
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSalesTaxTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.lblTaxText);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotalText);
            this.Controls.Add(this.lblCountyText);
            this.Controls.Add(this.lblStateText);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCounty);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtPurchase);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmSalesTaxTotal";
            this.Text = "frmSalesTaxTotal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalText;
        private System.Windows.Forms.Label lblCountyText;
        private System.Windows.Forms.Label lblStateText;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtPurchase;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblTaxText;
        private System.Windows.Forms.Label lblTax;
    }
}