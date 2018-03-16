namespace Tutorial3_4
{
    partial class frmAVG
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
            this.lblFirstTest = new System.Windows.Forms.Label();
            this.lblSecondTest = new System.Windows.Forms.Label();
            this.lblThirdTest = new System.Windows.Forms.Label();
            this.lblAVGScore = new System.Windows.Forms.Label();
            this.lblAVGResult = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest3 = new System.Windows.Forms.TextBox();
            this.btnCalcAVG = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstTest
            // 
            this.lblFirstTest.AutoSize = true;
            this.lblFirstTest.Location = new System.Drawing.Point(107, 47);
            this.lblFirstTest.Name = "lblFirstTest";
            this.lblFirstTest.Size = new System.Drawing.Size(40, 13);
            this.lblFirstTest.TabIndex = 0;
            this.lblFirstTest.Text = "Test 1:";
            // 
            // lblSecondTest
            // 
            this.lblSecondTest.AutoSize = true;
            this.lblSecondTest.Location = new System.Drawing.Point(107, 77);
            this.lblSecondTest.Name = "lblSecondTest";
            this.lblSecondTest.Size = new System.Drawing.Size(40, 13);
            this.lblSecondTest.TabIndex = 1;
            this.lblSecondTest.Text = "Test 2:";
            // 
            // lblThirdTest
            // 
            this.lblThirdTest.AutoSize = true;
            this.lblThirdTest.Location = new System.Drawing.Point(107, 108);
            this.lblThirdTest.Name = "lblThirdTest";
            this.lblThirdTest.Size = new System.Drawing.Size(40, 13);
            this.lblThirdTest.TabIndex = 2;
            this.lblThirdTest.Text = "Test 3:";
            // 
            // lblAVGScore
            // 
            this.lblAVGScore.AutoSize = true;
            this.lblAVGScore.Location = new System.Drawing.Point(42, 137);
            this.lblAVGScore.Name = "lblAVGScore";
            this.lblAVGScore.Size = new System.Drawing.Size(105, 13);
            this.lblAVGScore.TabIndex = 3;
            this.lblAVGScore.Text = "Average Test Score:";
            // 
            // lblAVGResult
            // 
            this.lblAVGResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAVGResult.Location = new System.Drawing.Point(193, 137);
            this.lblAVGResult.Name = "lblAVGResult";
            this.lblAVGResult.Size = new System.Drawing.Size(100, 20);
            this.lblAVGResult.TabIndex = 4;
            this.lblAVGResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(193, 41);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(100, 20);
            this.txtTest1.TabIndex = 5;
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(193, 74);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(100, 20);
            this.txtTest2.TabIndex = 6;
            // 
            // txtTest3
            // 
            this.txtTest3.Location = new System.Drawing.Point(193, 105);
            this.txtTest3.Name = "txtTest3";
            this.txtTest3.Size = new System.Drawing.Size(100, 20);
            this.txtTest3.TabIndex = 7;
            // 
            // btnCalcAVG
            // 
            this.btnCalcAVG.Location = new System.Drawing.Point(57, 192);
            this.btnCalcAVG.Name = "btnCalcAVG";
            this.btnCalcAVG.Size = new System.Drawing.Size(75, 36);
            this.btnCalcAVG.TabIndex = 8;
            this.btnCalcAVG.Text = "Calculate Average";
            this.btnCalcAVG.UseVisualStyleBackColor = true;
            this.btnCalcAVG.Click += new System.EventHandler(this.btnCalcAVG_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 192);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 36);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(261, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmAVG
            // 
            this.AcceptButton = this.btnCalcAVG;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalcAVG);
            this.Controls.Add(this.txtTest3);
            this.Controls.Add(this.txtTest2);
            this.Controls.Add(this.txtTest1);
            this.Controls.Add(this.lblAVGResult);
            this.Controls.Add(this.lblAVGScore);
            this.Controls.Add(this.lblThirdTest);
            this.Controls.Add(this.lblSecondTest);
            this.Controls.Add(this.lblFirstTest);
            this.Name = "frmAVG";
            this.Text = "Test Average";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstTest;
        private System.Windows.Forms.Label lblSecondTest;
        private System.Windows.Forms.Label lblThirdTest;
        private System.Windows.Forms.Label lblAVGScore;
        private System.Windows.Forms.Label lblAVGResult;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest3;
        private System.Windows.Forms.Button btnCalcAVG;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

