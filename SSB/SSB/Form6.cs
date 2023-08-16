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
        public int repeticao;


        public Form6()
        {
            // POSICAO DA TELA
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);

            // EVENTO DOS PLACE HOLDERS

            textBox1.Enter += textBox1_Enter; // PARA FAZER A ENTRADA DO PLACE HOLDER NO CAMPO DE CODIGO
            textBox1.Leave += textBox1_Leave; // PARA FAZER A SAIDA DO PLACE HOLDER NO CAMPO DE CODIGO
            textBox2.Enter += textBox2_Enter; // PARA FAZER A ENTRADA DO PLACE HOLDER NO CAMPO DE CODIGO
            textBox2.Leave += textBox2_Leave; // PARA FAZER A SAIDA DO PLACE HOLDER NO CAMPO DE CODIGO

            InitializeComponent();

        }


        // BOTAO QUE COMEÇA TUDO
        private async void button1_Click(object sender, EventArgs e)
        {
            label3.Text = ""; // APAGANDO MSG DE ERRO "VALOR REP INCORRETO"
            button1.Text = "COMEÇAR";

            await Task.Delay(100);
            label1.Text = "10s";
            await Task.Delay(1000);
            label1.Text = "9s";
            await Task.Delay(1000);
            label1.Text = "8s";
            await Task.Delay(1000);
            label1.Text = "7s";
            await Task.Delay(1000);
            label1.Text = "6s";
            await Task.Delay(1000);
            label1.Text = "5s";
            await Task.Delay(1000);
            label1.Text = "4s";
            await Task.Delay(1000);
            label1.Text = "3s";
            await Task.Delay(1000);
            label1.Text = "2s";
            await Task.Delay(1000);
            label1.Text = "1s";
            await Task.Delay(1000);
            label1.Text = "";

            lista();
            await Task.Delay(100);
            automacao();
        }



        // BOTAO DE VOLTAR
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); // Crie uma instância do formulário desejado
            form1.Show(); // Exiba o formulário
            Close();
        }

        // TRANSFORMANDO A STRING POR LINHAS E ADICIONANDO A LISTA
        public void lista()
        {

            string numeros = textBox1.Text;
            string[] linhas = numeros.Split('\n');
            listapreco.Clear();
            foreach (string line in linhas)
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    listapreco.Add(line.Trim());
                }
            }

        }

        // AUTOMAÇÃO
        public void automacao()
        {

            foreach (string preco in listapreco)
            {
                if (string.IsNullOrEmpty(textBox2.Text))
                {
                    repeticao = 1; // Define um valor padrão, se o TextBox estiver vazio
                }
                else
                {
                    if (int.TryParse(textBox2.Text, out int valorRepeticao))
                    {
                        repeticao = valorRepeticao; // Atribui o valor numérico do TextBox à variável
                    }
                    else
                    {
                        label3.Text = "Valor de Repetição Incorreto!!";
                        button1.Text = "Tentar novamente";
                        repeticao = -11; // Define um valor padrão, se o TextBox estiver vazio
                    }
                }

                while (repeticao > 0)
                {
                    inputSimulator.Keyboard.TextEntry(preco);
                    Thread.Sleep(100);
                    inputSimulator.Keyboard.KeyDown(WindowsInput.Native.VirtualKeyCode.DOWN);
                    Thread.Sleep(150);
                    repeticao = repeticao -1;
                }

            };

 
        }

        // TIMER PARA INICIAR
        public async void dormir()
        {
            label1.Text = "Vai começar em 10s";
            await Task.Delay(9900);
            label1.Text = "Começou";
        }




        // BOTAO DE AJUDA REFERENTE AO VIDEO DE AUTOMAÇÃO
        private void button3_Click(object sender, EventArgs e)
        {
            string target = "http://www.microsoft.com";
            System.Diagnostics.Process.Start(target);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string target = "https://www.youtube.com/watch?v=TLZb_7p7unU";
            System.Diagnostics.Process.Start(target);
        }



        // FAZENDO OS PLACE HOLDER  (TEM COISA NA INICIALIZAÇÃO TAMBEM)

        //---------------------------PLACE HOLDER CAMPO CODIGO -----------------------------------------

        //  VERIFICA A HORA QUE VC CLICOU E RETIRA O TEXTO QUE TINHA E MUDA A COR PARA PADRAO
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Digite os codigos aqui")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Volta à cor padrão do texto
            }
        }

        //  VERIFICA A HORA QUE VC SAI DO CAMPO E VALIDA SE O CAMPO ESTIVER VAZIO
        //  PARA COLOCAR O TEXTO E MUDAR A COR PARA CINZA
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Digite os codigos aqui";
                textBox1.ForeColor = SystemColors.GrayText; // Altera a cor do texto para cinza claro
            }
        }
        //-----------------------------------------------------------------------------------------------

        //---------------------------PLACE HOLDER CAMPO CODIGO -----------------------------------------

        //  VERIFICA A HORA QUE VC CLICOU E RETIRA O TEXTO QUE TINHA E MUDA A COR PARA PADRAO
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "QTD REPETICAO")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Volta à cor padrão do texto
            }
        }

        //  VERIFICA A HORA QUE VC SAI DO CAMPO E VALIDA SE O CAMPO ESTIVER VAZIO
        //  PARA COLOCAR O TEXTO E MUDAR A COR PARA CINZA
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.Text = "QTD REPETICAO";
                textBox2.ForeColor = SystemColors.GrayText; // Altera a cor do texto para cinza claro
            }
        }
        //-----------------------------------------------------------------------------------------------


    }
}

