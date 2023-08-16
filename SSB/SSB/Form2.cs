using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            double n1, n2, frete;
            try
            {
                n1 = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                n2 = Convert.ToDouble(textBox2.Text.Replace(".", ","));
                frete = (n1 * (n2 / 1000));
                frete = Math.Round(frete, 2);
                label3.Text = $"R$:{frete}";
                label4.Text = "";
            }
            catch
            {
                label4.Text = "Ocorreu um erro!";
            }
        }




            private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            Close();
        }

    }
}
