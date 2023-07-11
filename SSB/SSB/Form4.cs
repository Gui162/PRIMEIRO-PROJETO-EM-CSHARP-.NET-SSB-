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
    public partial class Form4 : Form
    {
        public Form4()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precoVenda, qtdMetros;

            double resultado;
            try
            {
                precoVenda = Convert.ToDouble(textBox1.Text.Replace(".", ","));
                qtdMetros = Convert.ToDouble(textBox2.Text.Replace(".", ","));

                if (qtdMetros >= 0 && qtdMetros <= 5.99)
                {
                    resultado = precoVenda * 0.5;
                }
                else if (qtdMetros >= 6 && qtdMetros <= 9.99)
                {
                    resultado = precoVenda * 0.6;
                }
                else if (qtdMetros >= 10 && qtdMetros <= 19.99)
                {
                    resultado = precoVenda * 0.7;
                }
                else if (qtdMetros >= 20 && qtdMetros <= 29.99)
                {
                    resultado = precoVenda * 0.8;
                }
                else if (qtdMetros >= 30 && qtdMetros <= 35.99)
                {
                    resultado = precoVenda * 0.85;
                }
                else if (qtdMetros >= 36 && qtdMetros <= 39.99)
                {
                    resultado = precoVenda * 0.95;
                }
                else
                {
                    resultado = precoVenda; // Valor padrão caso nenhuma condição seja satisfeita
                }
                resultado = Math.Round(resultado, 2);
                label3.Text = $"R$:{resultado}";
                label6.Text = "";
            }
            catch
            {
                label6.Text = "Ocorreu um erro!!";
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
