using System;


namespace ShowWF
{
    partial class Main
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
            this.avgBtn         = new System.Windows.Forms.Button();
            this.oneDimArrayBtn = new System.Windows.Forms.Button();
            this.quadEquatBtn   = new System.Windows.Forms.Button();
            this.twoDimArrayBtn = new System.Windows.Forms.Button();
            this.seasonsBtn     = new System.Windows.Forms.Button();
            this.dbBtn          = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // avgBtn
            // 
            this.avgBtn.Location                =  new System.Drawing.Point(67, 53);
            this.avgBtn.Name                    =  "avgBtn";
            this.avgBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.avgBtn.TabIndex                =  6;
            this.avgBtn.Text                    =  "Среднее арифметическое";
            this.avgBtn.UseVisualStyleBackColor =  true;
            this.avgBtn.Click                   += new EventHandler(avgBtn_Click);
            // 
            // oneDimArrayBtn
            // 
            this.oneDimArrayBtn.Location                =  new System.Drawing.Point(319, 53);
            this.oneDimArrayBtn.Name                    =  "oneDimArrayBtn";
            this.oneDimArrayBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.oneDimArrayBtn.TabIndex                =  1;
            this.oneDimArrayBtn.Text                    =  "Одномерный массив";
            this.oneDimArrayBtn.UseVisualStyleBackColor =  true;
            this.oneDimArrayBtn.Click                   += new System.EventHandler(this.oneDimArrayBtn_Click);
            // 
            // quadEquatBtn
            // 
            this.quadEquatBtn.Location                =  new System.Drawing.Point(563, 53);
            this.quadEquatBtn.Name                    =  "quadEquatBtn";
            this.quadEquatBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.quadEquatBtn.TabIndex                =  2;
            this.quadEquatBtn.Text                    =  "Решение квадратного уравнения";
            this.quadEquatBtn.UseVisualStyleBackColor =  true;
            this.quadEquatBtn.Click                   += new System.EventHandler(this.quadEquatBtn_Click);
            // 
            // twoDimArrayBtn
            // 
            this.twoDimArrayBtn.Location                =  new System.Drawing.Point(67, 231);
            this.twoDimArrayBtn.Name                    =  "twoDimArrayBtn";
            this.twoDimArrayBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.twoDimArrayBtn.TabIndex                =  3;
            this.twoDimArrayBtn.Text                    =  "Двумерный массив";
            this.twoDimArrayBtn.UseVisualStyleBackColor =  true;
            this.twoDimArrayBtn.Click                   += new System.EventHandler(this.twoDimArrayBtn_Click);
            // 
            // seasonsBtn
            // 
            this.seasonsBtn.Location                =  new System.Drawing.Point(319, 231);
            this.seasonsBtn.Name                    =  "seasonsBtn";
            this.seasonsBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.seasonsBtn.TabIndex                =  4;
            this.seasonsBtn.Text                    =  "Времена года";
            this.seasonsBtn.UseVisualStyleBackColor =  true;
            this.seasonsBtn.Click                   += new System.EventHandler(this.seasonsBtn_Click);
            // 
            // dbBtn
            // 
            this.dbBtn.Location                =  new System.Drawing.Point(563, 231);
            this.dbBtn.Name                    =  "dbBtn";
            this.dbBtn.Size                    =  new System.Drawing.Size(170, 61);
            this.dbBtn.TabIndex                =  5;
            this.dbBtn.Text                    =  "Привязка к БД";
            this.dbBtn.UseVisualStyleBackColor =  true;
            this.dbBtn.Click                   += new System.EventHandler(this.dbBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.avgBtn);
            this.Controls.Add(this.dbBtn);
            this.Controls.Add(this.seasonsBtn);
            this.Controls.Add(this.twoDimArrayBtn);
            this.Controls.Add(this.quadEquatBtn);
            this.Controls.Add(this.oneDimArrayBtn);
            this.Name =  "Main";
            this.Text =  "Помощник";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button twoDimArrayBtn;

        private System.Windows.Forms.Button seasonsBtn;

        private System.Windows.Forms.Button twoDimBtn;

        private System.Windows.Forms.Button oneDimArrayBtn;

        private System.Windows.Forms.Button quadEquatBtn;

        private System.Windows.Forms.Button dbBtn;

        private System.Windows.Forms.Button avgBtn;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;

        #endregion
    }
}