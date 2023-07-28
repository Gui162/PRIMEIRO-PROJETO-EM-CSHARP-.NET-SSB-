using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FireSharp.Exceptions;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "qkLZIhfkFZWjUtXSjI61VBjTtb5D1aIQFOHIiXmG",
            BasePath = "https://agendamento-a7fb2-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();

            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    MessageBox.Show("Connection Success");
                }
                else
                {
                    MessageBox.Show("Failed to create Firebase client.");
                }
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadEntrega();
        }


        // FUNCAO DE CARREGAR ENTREGA DATAGRID
        public void LoadEntrega()
        {
            try
            {
                FirebaseResponse response = client.Get("entrega");
                if (response != null && response.Body != "null")
                {
                    JArray jsonArray = JArray.Parse(response.Body);
                    Agendamentos datalist = jsonArray.ToObject<Agendamentos>();

                    dataGridView1.Rows.Clear();

                    /// CRIA A COLUNA DO BOTAO ETITAR
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "  "; // Texto exibido no cabeçalho da coluna
                    buttonColumn.Name = "Mais"; // Nome da coluna
                    buttonColumn.Text = "Mais"; // Texto exibido nos botões da célula
                    buttonColumn.UseColumnTextForButtonValue = true; // Define o texto da célula como o texto do botão
                    dataGridView1.Columns.Insert(0, buttonColumn);

                    // Restante do código...

                    // Manipule o evento de clique do botão
                    foreach (var get in datalist)
                    {
                        if (get != null)
                        {
                            dataGridView1.Rows.Add(
                                get.nada,
                                get.ID,
                                get.Fornecedor,
                                get.Data,
                                get.Observacao
                            );
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Não foi possível obter as entregas.");
                    dataGridView1.Rows.Clear();
                }
            }
            catch (JsonSerializationException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Não foi possível obter as entregas.");
            }

        }

        // BOTAO DE SALVAR
        private void save_Click(object sender, EventArgs e)
        {
            Agendamentos agenda = new Agendamentos()
            {
                nada = "mais",
                ID = id.Text,
                Fornecedor = forncedor.Text,
                Data = data.Text,
                Observacao = observacao.Text,
            };

            FirebaseResponse response = client.Set("entrega/" + id.Text, agenda);
            MessageBox.Show("Agendamento criado");
        }

        // BOTAO DE REMOVER
        private void remove_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = client.Delete("entrega/" + id.Text);
            MessageBox.Show("Agendamento deletado");
            id.Text = string.Empty;
        }

        private void load_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            LoadEntrega();
        }



        // DETECTA DO CLICK NO BOTAO EDITAR

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o clique ocorreu na primeira coluna
            if (e.ColumnIndex == 0)
            {
                // Obtém o valor da célula na coluna desejada
                string valorCelula = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Exibe o valor da célula em um MessageBox
                //MessageBox.Show(valorCelula, "Conteúdo da célula");

                Form2 form2 = new Form2(); // Crie uma instância do formulário desejado
                form2.Show(); // Exiba o formulário

            }

            // ACAO BOTÃO EXCLUIR

            else if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["Excluir"].Index)
            {
                // Obtenha o valor da célula da linha clicada
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string value = row.Cells["Column1"].Value.ToString(); // Supondo que a coluna de ID tenha o nome "ID"

                // Exemplo de confirmação de exclusão usando MessageBox
                DialogResult result = MessageBox.Show("Deseja excluir Agendamento com ID " + value + "?", "Confirmação de Exclusão", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Lógica de exclusão aqui
                    // ...
                    // Atualize a exibição do DataGridView, removendo a linha excluída
                    FirebaseResponse response = client.Delete("entrega/" + value);
                    MessageBox.Show("Agendamento deletado");
                    value = string.Empty;
                    MessageBox.Show("foi excluido" +value);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}
