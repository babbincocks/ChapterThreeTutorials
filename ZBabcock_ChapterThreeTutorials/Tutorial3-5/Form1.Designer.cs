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
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbTwentyFiveCent = new System.Windows.Forms.PictureBox();
            this.pbTenCent = new System.Windows.Forms.PictureBox();
            this.pbFiftyCent = new System.Windows.Forms.PictureBox();
            this.pbFiveCent = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTwentyFiveCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiftyCent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveCent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(306, 183);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(120, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(110, 16);
            this.lblInstruction.TabIndex = 16;
            this.lblInstruction.Text = "Click the Coins";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Location = new System.Drawing.Point(306, 127);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 22);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(327, 111);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(31, 13);
            this.lblOutput.TabIndex = 14;
            this.lblOutput.Text = "Total";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(306, 212);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pbTwentyFiveCent
            // 
            this.pbTwentyFiveCent.Image = global::Tutorial3_5.Properties.Resources._25cents;
            this.pbTwentyFiveCent.Location = new System.Drawing.Point(14, 169);
            this.pbTwentyFiveCent.Name = "pbTwentyFiveCent";
            this.pbTwentyFiveCent.Size = new System.Drawing.Size(133, 135);
            this.pbTwentyFiveCent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTwentyFiveCent.TabIndex = 12;
            this.pbTwentyFiveCent.TabStop = false;
            // 
            // pbTenCent
            // 
            this.pbTenCent.Image = global::Tutorial3_5.Properties.Resources._10cents;
            this.pbTenCent.Location = new System.Drawing.Point(153, 28);
            this.pbTenCent.Name = "pbTenCent";
            this.pbTenCent.Size = new System.Drawing.Size(133, 135);
            this.pbTenCent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTenCent.TabIndex = 11;
            this.pbTenCent.TabStop = false;
            // 
            // pbFiftyCent
            // 
            this.pbFiftyCent.Image = global::Tutorial3_5.Properties.Resources._50cents;
            this.pbFiftyCent.Location = new System.Drawing.Point(153, 169);
            this.pbFiftyCent.Name = "pbFiftyCent";
            this.pbFiftyCent.Size = new System.Drawing.Size(133, 135);
            this.pbFiftyCent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFiftyCent.TabIndex = 10;
            this.pbFiftyCent.TabStop = false;
            // 
            // pbFiveCent
            // 
            this.pbFiveCent.Image = global::Tutorial3_5.Properties.Resources._5cents;
            this.pbFiveCent.InitialImage = null;
            this.pbFiveCent.Location = new System.Drawing.Point(14, 28);
            this.pbFiveCent.Name = "pbFiveCent";
            this.pbFiveCent.Size = new System.Drawing.Size(133, 135);
            this.pbFiveCent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFiveCent.TabIndex = 9;
            this.pbFiveCent.TabStop = false;
            this.pbFiveCent.Click += new System.EventHandler(this.pbFiveCent_Click);
            // 
            // frmChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 335);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbTwentyFiveCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTenCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiftyCent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveCent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbTwentyFiveCent;
        private System.Windows.Forms.PictureBox pbTenCent;
        private System.Windows.Forms.PictureBox pbFiftyCent;
        private System.Windows.Forms.PictureBox pbFiveCent;
    }
}

