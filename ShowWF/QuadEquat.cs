using System;
using System.Windows.Forms;


namespace ShowWF
{
    public partial class QuadEquat : Form
    {
        public QuadEquat()
        {
            InitializeComponent();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(aTb.Text, out var a))
            {
                MessageBox.Show("Первый коэффициент может быть только целым числом", "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            
            if (!int.TryParse(bTb.Text, out var b))
            {
                MessageBox.Show("Второй коэффициент может быть только целым числом", "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            
            if (!int.TryParse(cTb.Text, out var c))
            {
                MessageBox.Show("Свободный коэффициент может быть только целым числом", "Ошибка", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }

            var d = (int)Math.Pow(b, 2) - 4 * a * c;

            if (d < 0)
            {
                MessageBox.Show("Нет действительный корней", "Внимание", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                aTb.Text = string.Empty;
                bTb.Text = string.Empty;
                cTb.Text = string.Empty;
                return;
            }

            if (d == 0)
            {
                var x = -(b / 2 * a);
                x1Lbl.Text = x.ToString();
                x2Lbl.Text = x.ToString();
                return;
            }

            var x1 = (-b + Math.Sqrt(d)) / 2 * a;
            var x2 = (-b - Math.Sqrt(d)) / 2 * a;
            
            x1Lbl.Text = $@"{x1:F}";
            x2Lbl.Text = $@"{x2:F}";
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}