using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SSB
{
    public partial class Form3 : Form
    {
        private string numerosString;
        public Form3()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string numeros = textBox1.Text;
            string[] linhas = numeros.Split('\n');

            List<string> listacomvirgula = new List<string>();
            foreach (string line in linhas)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    listacomvirgula.Add(line.Trim());
                }
            }
            numerosString = string.Join(",", listacomvirgula);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numerosString))
            {
                Clipboard.SetText(numerosString);
                label1.Text = "Texto copiado!!";
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
