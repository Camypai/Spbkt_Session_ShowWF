using System;
using System.Drawing;
using System.Windows.Forms;


namespace ShowWF
{
    public partial class Seasons : Form
    {
        public Seasons()
        {
            InitializeComponent();
        }

        private void seasonCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(seasonCmb.SelectedText);
            switch (seasonCmb.SelectedIndex)
            {
                case 0:
                    seasonPb.Image = Image.FromFile("seasons/winter.jpeg");
                    break;
                case 1:
                    seasonPb.Image = Image.FromFile("seasons/spring.jpeg");
                    break;
                case 2:
                    seasonPb.Image = Image.FromFile("seasons/summer.jpeg");
                    break;
                case 3:
                    seasonPb.Image = Image.FromFile("seasons/autumn.jpeg");
                    break;
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}