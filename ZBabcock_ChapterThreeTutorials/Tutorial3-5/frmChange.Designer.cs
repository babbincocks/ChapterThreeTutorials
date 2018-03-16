namespace Tutorial3_5
{
    partial class frmChange
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
            this.pbFiveCent = new System.Windows.Forms.PictureBox();
            this.pbFiftyCent = new System.Windows.Forms.PictureBox();
            this.pbTenCent = new System.Windows.Forms.PictureBox();
            this.pbTwentyFiveCent = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiftyCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwentyFiveCent)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFiveCent
            // 
            this.pbFiveCent.InitialImage = null;
            this.pbFiveCent.Location = new System.Drawing.Point(18, 27);
            this.pbFiveCent.Name = "pbFiveCent";
            this.pbFiveCent.Size = new System.Drawing.Size(133, 135);
            this.pbFiveCent.TabIndex = 0;
            this.pbFiveCent.TabStop = false;
            this.pbFiveCent.Click += new System.EventHandler(this.pbFiveCent_Click);
            // 
            // pbFiftyCent
            // 
            this.pbFiftyCent.Location = new System.Drawing.Point(157, 168);
            this.pbFiftyCent.Name = "pbFiftyCent";
            this.pbFiftyCent.Size = new System.Drawing.Size(133, 135);
            this.pbFiftyCent.TabIndex = 1;
            this.pbFiftyCent.TabStop = false;
            this.pbFiftyCent.Click += new System.EventHandler(this.pbFiftyCent_Click);
            // 
            // pbTenCent
            // 
            this.pbTenCent.Location = new System.Drawing.Point(157, 27);
            this.pbTenCent.Name = "pbTenCent";
            this.pbTenCent.Size = new System.Drawing.Size(133, 135);
            this.pbTenCent.TabIndex = 2;
            this.pbTenCent.TabStop = false;
            this.pbTenCent.Click += new System.EventHandler(this.pbTenCent_Click);
            // 
            // pbTwentyFiveCent
            // 
            this.pbTwentyFiveCent.Location = new System.Drawing.Point(18, 168);
            this.pbTwentyFiveCent.Name = "pbTwentyFiveCent";
            this.pbTwentyFiveCent.Size = new System.Drawing.Size(133, 135);
            this.pbTwentyFiveCent.TabIndex = 3;
            this.pbTwentyFiveCent.TabStop = false;
            this.pbTwentyFiveCent.Click += new System.EventHandler(this.pbTwentyFiveCent_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(310, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(331, 110);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(31, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(310, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 22);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(124, 8);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(110, 16);
            this.lblInstruction.TabIndex = 7;
            this.lblInstruction.Text = "Click the Coins";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(310, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 323);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbTwentyFiveCent);
            this.Controls.Add(this.pbTenCent);
            this.Controls.Add(this.pbFiftyCent);
            this.Controls.Add(this.pbFiveCent);
            this.Name = "frmChange";
            this.Text = "Change Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiftyCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwentyFiveCent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFiveCent;
        private System.Windows.Forms.PictureBox pbFiftyCent;
        private System.Windows.Forms.PictureBox pbTenCent;
        private System.Windows.Forms.PictureBox pbTwentyFiveCent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnClear;
    }
}

