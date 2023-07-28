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
using WindowsInput;
using System.Timers;


namespace SSB
{
    public partial class Form6 : Form
    {

        // DECLARAÇÃO DE VARIAVEIS :
        InputSimulator inputSimulator = new InputSimulator();
        List<string> listapreco = new List<string>();



        public Form6()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // TRANSFORMANDO A STRING POR LINHAS E ADICIONANDO A LISTA
            string numeros = textBox1.Text;
            string[] linhas = numeros.Split('\n');

            foreach (string line in linhas)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    listapreco.Add(line.Trim());
                }
            }

            dormir();
            automacao();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crie uma instância do formulário desejado
            form1.Show(); // Exiba o formulário
            Close();
        }


        // AUTOMAÇÃO
        public void automacao()
        {
            foreach (string preco in listapreco)
            {
                inputSimulator.Keyboard.TextEntry(preco);
                Thread.Sleep(100);
                inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.DOWN);
                Thread.Sleep(150);
            }
        }

        // TIMER PARA INICIAR
        public void dormir()
        {
            label1.Text = "Vai começar em 10s";
            Thread.Sleep(10000);
            label1.Text = "Começou";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            }
        }
    }

