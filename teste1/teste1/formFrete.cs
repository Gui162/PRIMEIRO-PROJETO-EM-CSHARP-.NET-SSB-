using System.Runtime.Serialization;

namespace teste1
{
    public partial class formFrete : Form
    {
        public formFrete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, frete;
            n1 = Convert.ToDouble(textBox1.Text.Replace(".", ","));
            n2 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
            frete = (n1 * (n2 / 1000));
            frete = Math.Round(frete, 2);
            label3.Text = $"R$:{frete}";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}