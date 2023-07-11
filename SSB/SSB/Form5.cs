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
    public partial class Form5 : Form
    {
        public Form5()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precoVenda, precoPromocao, resultado;
            try
            {
                precoVenda = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                precoPromocao = Convert.ToDouble(textBox2.Text.Replace(".", ","));

                resultado = (-((precoPromocao / precoVenda) - 1)) * 100;
                resultado = Math.Round(resultado, 3);
                label3.Text = $"%{resultado}";
                label5.Text = "";
            }
            catch
            {
                label5.Text = "Ocorreu um Erro!!";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crie uma instância do formulário desejado
            form1.Show(); // Exiba o formulário
            Close();
        }
    }
}
