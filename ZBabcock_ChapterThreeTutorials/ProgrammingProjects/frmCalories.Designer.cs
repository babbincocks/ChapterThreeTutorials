namespace ProgrammingProjects
{
    partial class frmCalories
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbPear = new System.Windows.Forms.PictureBox();
            this.pbOrange = new System.Windows.Forms.PictureBox();
            this.pbBanana = new System.Windows.Forms.PictureBox();
            this.pbApple = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(303, 44);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(101, 23);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Calories";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(303, 212);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 23);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next Problem";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(303, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(303, 270);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbPear
            // 
            this.pbPear.Image = global::ProgrammingProjects.Properties.Resources.PearCalories;
            this.pbPear.Location = new System.Drawing.Point(144, 175);
            this.pbPear.Name = "pbPear";
            this.pbPear.Size = new System.Drawing.Size(126, 156);
            this.pbPear.TabIndex = 3;
            this.pbPear.TabStop = false;
            this.pbPear.Click += new System.EventHandler(this.pbPear_Click);
            // 
            // pbOrange
            // 
            this.pbOrange.Image = global::ProgrammingProjects.Properties.Resources.OrangeCalories;
            this.pbOrange.Location = new System.Drawing.Point(12, 175);
            this.pbOrange.Name = "pbOrange";
            this.pbOrange.Size = new System.Drawing.Size(126, 156);
            this.pbOrange.TabIndex = 2;
            this.pbOrange.TabStop = false;
            this.pbOrange.Click += new System.EventHandler(this.pbOrange_Click);
            // 
            // pbBanana
            // 
            this.pbBanana.Image = global::ProgrammingProjects.Properties.Resources.BananaCalories;
            this.pbBanana.Location = new System.Drawing.Point(144, 13);
            this.pbBanana.Name = "pbBanana";
            this.pbBanana.Size = new System.Drawing.Size(126, 156);
            this.pbBanana.TabIndex = 1;
            this.pbBanana.TabStop = false;
            this.pbBanana.Click += new System.EventHandler(this.pbBanana_Click);
            // 
            // pbApple
            // 
            this.pbApple.Image = global::ProgrammingProjects.Properties.Resources.AppleCalories;
            this.pbApple.Location = new System.Drawing.Point(12, 13);
            this.pbApple.Name = "pbApple";
            this.pbApple.Size = new System.Drawing.Size(126, 156);
            this.pbApple.TabIndex = 0;
            this.pbApple.TabStop = false;
            this.pbApple.Click += new System.EventHandler(this.pbApple_Click);
            // 
            // frmCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 343);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbPear);
            this.Controls.Add(this.pbOrange);
            this.Controls.Add(this.pbBanana);
            this.Controls.Add(this.pbApple);
            this.Name = "frmCalories";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.pbPear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBanana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbApple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbApple;
        private System.Windows.Forms.PictureBox pbBanana;
        private System.Windows.Forms.PictureBox pbOrange;
        private System.Windows.Forms.PictureBox pbPear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}