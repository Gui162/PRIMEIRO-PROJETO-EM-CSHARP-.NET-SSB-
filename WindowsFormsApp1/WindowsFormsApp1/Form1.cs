using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string numerosString;

        public Form1()
        {
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

    }
}
