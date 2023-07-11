﻿using System;
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
            try
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    MessageBox.Show("Connection Success");
                }
            }
            catch
            {
                MessageBox.Show("Connection Fail");
            }

            LoadEntrega();
        }
        public void LoadEntrega()
        {
            try
            {
                FirebaseResponse response = client.Get("entrega");
                if (response != null && response.Body != "null")
                {
                    List<Agendamentos> getEntregas = JsonConvert.DeserializeObject<List<Agendamentos>>(response.Body);

                    dataGridView1.Rows.Clear();

                    // Crie a coluna de botão
                    DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                    buttonColumn.HeaderText = "  "; // Texto exibido no cabeçalho da coluna
                    buttonColumn.Name = "Editar"; // Nome da coluna
                    buttonColumn.Text = "Editar"; // Texto exibido nos botões da célula
                    buttonColumn.UseColumnTextForButtonValue = true; // Define o texto da célula como o texto do botão

                    // Adicione a coluna ao DataGridView
                    dataGridView1.Columns.Add(buttonColumn);

                    // Manipule o evento de clique do botão

                    foreach (var get in getEntregas)
                    {
                        if (get != null)
                        {
                            dataGridView1.Rows.Add(
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
                    Console.WriteLine("Não foi possível obter as entregas.");
                }
            }
            catch (JsonSerializationException ex)
            {
                Console.WriteLine("Exceção de serialização/desserialização JSON:");
                Console.WriteLine("Mensagem de erro: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);

                if (ex.InnerException is JsonReaderException readerException)
                {
                    Console.WriteLine("Exceção do leitor JSON:");
                    Console.WriteLine("Mensagem de erro: " + readerException.Message);
                    Console.WriteLine("Localização do erro: " + readerException.Path);
                    Console.WriteLine("StackTrace: " + readerException.StackTrace);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            Agendamentos agenda = new Agendamentos()
            {
                ID = id.Text,
                Fornecedor = forncedor.Text,
                Data = data.Text,
                Observacao = observacao.Text,
            };

            FirebaseResponse response = client.Set("entrega/" + id.Text, agenda);
            MessageBox.Show("Agendamento criado");
        }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifique se o clique ocorreu na última coluna
            if (e.ColumnIndex == dataGridView1.Columns.Count - 1 && e.RowIndex >= 0)
            {
                // Obtém o valor da célula na coluna desejada
                string valorCelula = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                // Exibe o valor da célula em um MessageBox
                MessageBox.Show(valorCelula, "Conteúdo da célula");

            }
        }
    }
}
