using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Firebase_teste_
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "PAlWkjw4OXrO5rWOrNuvQLGrMf2eS0cRqwMaNbxL",
            BasePath = "https://teste-4db94-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null )
            {
                MessageBox.Show("Conexão esta estabilizada");
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                id = textBox1.Text,
                name = textBox2.Text,
                endereco = textBox3.Text,
                idade = textBox4.Text,


            };

            SetResponse response = await client.SetTaskAsync("Informacao/" + textBox1.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("data foi inserida "+result.id);


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Informacao/"+textBox1.Text);
            Data obj = response.ResultAs<Data>();

            textBox1.Text = obj.id;
            textBox2.Text = obj.name;
            textBox3.Text = obj.endereco;
            textBox4.Text = obj.idade;

            MessageBox.Show("Data foi recebido com sucesso");
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                id = textBox1.Text,
                name = textBox2.Text,
                endereco = textBox3.Text,
                idade = textBox4.Text,
            };

            FirebaseResponse response = await client.UpdateTaskAsync("Informacao/"+textBox1.Text,data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("data Modificada pelo Id" + result.id);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Informacao/" + textBox1.Text);
            MessageBox.Show("data deletada pelo id" + textBox1.Text);
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Informacao/");
            MessageBox.Show("todos os elementos do banco foram deletados / Informacao node foi deletada");
        }
    }
}
