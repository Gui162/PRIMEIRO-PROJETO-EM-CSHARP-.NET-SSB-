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
    public partial class Form1 : Form
    {
        public Form1()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(540, 290);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(); // Crie uma instância do formulário desejado
            form2.Show(); // Exiba o formulário
            Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); // Crie uma instância do formulário desejado
            form3.Show(); // Exiba o formulário
            Hide();
        }

    }
}
