using System;
using System.ComponentModel;


namespace ShowWF
{
    partial class Avg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.backBtn = new System.Windows.Forms.Button();
            this.avgTb   = new System.Windows.Forms.TextBox();
            this.label1  = new System.Windows.Forms.Label();
            this.calcBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location                =  new System.Drawing.Point(12, 12);
            this.backBtn.Name                    =  "backBtn";
            this.backBtn.Size                    =  new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                =  0;
            this.backBtn.Text                    =  "Назад";
            this.backBtn.UseVisualStyleBackColor =  true;
            this.backBtn.Click                   += new System.EventHandler(this.backBtn_Click);
            // 
            // avgTb
            // 
            this.avgTb.Location = new System.Drawing.Point(226, 129);
            this.avgTb.Name     = "avgTb";
            this.avgTb.Size     = new System.Drawing.Size(259, 20);
            this.avgTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 132);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text     = "Введите числа через запятую";
            // 
            // calcBtn
            // 
            this.calcBtn.Location                = new System.Drawing.Point(534, 127);
            this.calcBtn.Name                    = "calcBtn";
            this.calcBtn.Size                    = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex                = 3;
            this.calcBtn.Text                    = "Посчитать";
            this.calcBtn.UseVisualStyleBackColor = true;
            // 
            // Avg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgTb);
            this.Controls.Add(this.backBtn);
            this.Name = "Avg";
            this.Text = "Определение среднего арифметического";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox avgTb;

        private System.Windows.Forms.Button calcBtn;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label answerLbl;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}