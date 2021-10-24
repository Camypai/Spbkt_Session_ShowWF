using System.ComponentModel;


namespace ShowWF
{
    partial class TwoDimArray
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
            this.backBtn  = new System.Windows.Forms.Button();
            this.arrayDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.arrayDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location                = new System.Drawing.Point(12, 12);
            this.backBtn.Name                    = "backBtn";
            this.backBtn.Size                    = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex                = 0;
            this.backBtn.Text                    = "Назад";
            this.backBtn.UseVisualStyleBackColor = true;
            // 
            // arrayDgv
            // 
            this.arrayDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.arrayDgv.Location                    = new System.Drawing.Point(12, 41);
            this.arrayDgv.Name                        = "arrayDgv";
            this.arrayDgv.Size                        = new System.Drawing.Size(776, 397);
            this.arrayDgv.TabIndex                    = 1;
            // 
            // TwoDimArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.arrayDgv);
            this.Controls.Add(this.backBtn);
            this.Name = "TwoDimArray";
            this.Text = "Двумерный массив";
            ((System.ComponentModel.ISupportInitialize)(this.arrayDgv)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView arrayDgv;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button backBtn;

        #endregion
    }
}