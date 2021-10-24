using System.ComponentModel;


namespace ShowWF
{
    partial class OneDimArray
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
            this.backBtn       = new System.Windows.Forms.Button();
            this.numbersLb     = new System.Windows.Forms.ListBox();
            this.label1        = new System.Windows.Forms.Label();
            this.label2        = new System.Windows.Forms.Label();
            this.label3        = new System.Windows.Forms.Label();
            this.positiveLbl   = new System.Windows.Forms.Label();
            this.negativeLbl   = new System.Windows.Forms.Label();
            this.zeroLbl       = new System.Windows.Forms.Label();
            this.calcBtn       = new System.Windows.Forms.Button();
            this.fillRandomBtn = new System.Windows.Forms.Button();
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
            // numbersLb
            // 
            this.numbersLb.FormattingEnabled = true;
            this.numbersLb.Location          = new System.Drawing.Point(12, 112);
            this.numbersLb.Name              = "numbersLb";
            this.numbersLb.Size              = new System.Drawing.Size(776, 212);
            this.numbersLb.TabIndex          = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 327);
            this.label1.Name     = "label1";
            this.label1.Size     = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 2;
            this.label1.Text     = "Положительных чител:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 350);
            this.label2.Name     = "label2";
            this.label2.Size     = new System.Drawing.Size(136, 23);
            this.label2.TabIndex = 3;
            this.label2.Text     = "Отрицательных чисел:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 373);
            this.label3.Name     = "label3";
            this.label3.Size     = new System.Drawing.Size(136, 23);
            this.label3.TabIndex = 4;
            this.label3.Text     = "Нулевых чисел:";
            // 
            // positiveLbl
            // 
            this.positiveLbl.Location = new System.Drawing.Point(154, 327);
            this.positiveLbl.Name     = "positiveLbl";
            this.positiveLbl.Size     = new System.Drawing.Size(100, 23);
            this.positiveLbl.TabIndex = 5;
            this.positiveLbl.Text     = "?";
            // 
            // negativeLbl
            // 
            this.negativeLbl.Location = new System.Drawing.Point(154, 350);
            this.negativeLbl.Name     = "negativeLbl";
            this.negativeLbl.Size     = new System.Drawing.Size(100, 23);
            this.negativeLbl.TabIndex = 6;
            this.negativeLbl.Text     = "?";
            // 
            // zeroLbl
            // 
            this.zeroLbl.Location = new System.Drawing.Point(154, 373);
            this.zeroLbl.Name     = "zeroLbl";
            this.zeroLbl.Size     = new System.Drawing.Size(100, 23);
            this.zeroLbl.TabIndex = 7;
            this.zeroLbl.Text     = "?";
            // 
            // calcBtn
            // 
            this.calcBtn.Location                =  new System.Drawing.Point(590, 330);
            this.calcBtn.Name                    =  "calcBtn";
            this.calcBtn.Size                    =  new System.Drawing.Size(198, 66);
            this.calcBtn.TabIndex                =  8;
            this.calcBtn.Text                    =  "Посчитать";
            this.calcBtn.UseVisualStyleBackColor =  true;
            this.calcBtn.Click                   += new System.EventHandler(this.calcBtn_Click);
            // 
            // fillRandomBtn
            // 
            this.fillRandomBtn.Location                =  new System.Drawing.Point(386, 330);
            this.fillRandomBtn.Name                    =  "fillRandomBtn";
            this.fillRandomBtn.Size                    =  new System.Drawing.Size(198, 66);
            this.fillRandomBtn.TabIndex                =  9;
            this.fillRandomBtn.Text                    =  "Заполнить массив случайными числами";
            this.fillRandomBtn.UseVisualStyleBackColor =  true;
            this.fillRandomBtn.Click                   += new System.EventHandler(this.fillRandomBtn_Click);
            // 
            // OneDimArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fillRandomBtn);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.zeroLbl);
            this.Controls.Add(this.negativeLbl);
            this.Controls.Add(this.positiveLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numbersLb);
            this.Controls.Add(this.backBtn);
            this.Name = "OneDimArray";
            this.Text = "Одномерный массив";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button fillRandomBtn;

        private System.Windows.Forms.ListBox numbersLb;
        private System.Windows.Forms.Label   label1;
        private System.Windows.Forms.Label   label2;
        private System.Windows.Forms.Label   label3;
        private System.Windows.Forms.Label   positiveLbl;
        private System.Windows.Forms.Label   negativeLbl;
        private System.Windows.Forms.Label   zeroLbl;
        private System.Windows.Forms.Button  calcBtn;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}