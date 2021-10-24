using System;
using System.Linq;
using System.Windows.Forms;


namespace ShowWF
{
    public partial class Avg : Form
    {
        public Avg()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            var numbers = avgTb.Text.Split(',').Select(q => int.Parse(q.Trim())).ToList();

            MessageBox.Show($"Среднее арифметическое для указанной последовательности: {numbers.Average()}",
                            "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}