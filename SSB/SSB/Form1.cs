using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;   //abertura de janela com theed
using System.Security.AccessControl;

namespace SSB
{
    public partial class Form1 : Form
    {
        /*Thread t1;*/      //abertura de janela com theed
        public Form1()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Close();      //abertura de janela com theed
            t1 = new Thread(abrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();*/
            Form2 form2 = new Form2(); // Crie uma instância do formulário desejado
            form2.Show(); // Exiba o formulário
            Hide();

        }

        /*private void abrirJanela(object obj)   //abertura de janela com theed
        {
            Application.Run(new Form2());
        }*/


        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Crie uma instância do formulário desejado
            form3.Show(); // Exiba o formulário
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(); // Crie uma instância do formulário desejado
            form4.Show(); // Exiba o formulário
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // Crie uma instância do formulário desejado
            form5.Show(); // Exiba o formulário
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(); // Crie uma instância do formulário desejado
            form6.Show(); // Exiba o formulário
            Hide();
        }
    }
}
