namespace ProgrammingProjects
{
    partial class frmTravelDistance
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
            this.lbl12DistanceText = new System.Windows.Forms.Label();
            this.lbl8DistanceText = new System.Windows.Forms.Label();
            this.lbl5DistanceText = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbl12Distance = new System.Windows.Forms.Label();
            this.lbl8Distance = new System.Windows.Forms.Label();
            this.lbl5Distance = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl12DistanceText
            // 
            this.lbl12DistanceText.AutoSize = true;
            this.lbl12DistanceText.Location = new System.Drawing.Point(343, 129);
            this.lbl12DistanceText.Name = "lbl12DistanceText";
            this.lbl12DistanceText.Size = new System.Drawing.Size(95, 13);
            this.lbl12DistanceText.TabIndex = 23;
            this.lbl12DistanceText.Text = "12 Hours Distance";
            // 
            // lbl8DistanceText
            // 
            this.lbl8DistanceText.AutoSize = true;
            this.lbl8DistanceText.Location = new System.Drawing.Point(349, 84);
            this.lbl8DistanceText.Name = "lbl8DistanceText";
            this.lbl8DistanceText.Size = new System.Drawing.Size(89, 13);
            this.lbl8DistanceText.TabIndex = 22;
            this.lbl8DistanceText.Text = "8 Hours Distance";
            // 
            // lbl5DistanceText
            // 
            this.lbl5DistanceText.AutoSize = true;
            this.lbl5DistanceText.Location = new System.Drawing.Point(349, 34);
            this.lbl5DistanceText.Name = "lbl5DistanceText";
            this.lbl5DistanceText.Size = new System.Drawing.Size(89, 13);
            this.lbl5DistanceText.TabIndex = 21;
            this.lbl5DistanceText.Text = "5 Hours Distance";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(11, 34);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(67, 13);
            this.lblInstruction.TabIndex = 20;
            this.lblInstruction.Text = "Speed (mph)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(351, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 22);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(241, 214);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(87, 23);
            this.btnNext.TabIndex = 18;
            this.btnNext.Text = "Next Problem";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(128, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 22);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lbl12Distance
            // 
            this.lbl12Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl12Distance.Location = new System.Drawing.Point(230, 129);
            this.lbl12Distance.Name = "lbl12Distance";
            this.lbl12Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl12Distance.TabIndex = 16;
            this.lbl12Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl8Distance
            // 
            this.lbl8Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl8Distance.Location = new System.Drawing.Point(230, 81);
            this.lbl8Distance.Name = "lbl8Distance";
            this.lbl8Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl8Distance.TabIndex = 15;
            this.lbl8Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl5Distance
            // 
            this.lbl5Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl5Distance.Location = new System.Drawing.Point(230, 31);
            this.lbl5Distance.Name = "lbl5Distance";
            this.lbl5Distance.Size = new System.Drawing.Size(103, 19);
            this.lbl5Distance.TabIndex = 14;
            this.lbl5Distance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(82, 31);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(100, 20);
            this.txtSpeed.TabIndex = 13;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(14, 214);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(87, 23);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // frmTravelDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.lbl12DistanceText);
            this.Controls.Add(this.lbl8DistanceText);
            this.Controls.Add(this.lbl5DistanceText);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbl12Distance);
            this.Controls.Add(this.lbl8Distance);
            this.Controls.Add(this.lbl5Distance);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmTravelDistance";
            this.Text = "frmTravelDistance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl12DistanceText;
        private System.Windows.Forms.Label lbl8DistanceText;
        private System.Windows.Forms.Label lbl5DistanceText;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lbl12Distance;
        private System.Windows.Forms.Label lbl8Distance;
        private System.Windows.Forms.Label lbl5Distance;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnCalc;
    }
}