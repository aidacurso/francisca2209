using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace atvlanchonete2209
{
    public partial class CadastrarCliente : Form
    {
        Cliente cliente = new Cliente();
        List<Cliente> listCliente = new List<Cliente>();
        public CadastrarCliente()
        {
            InitializeComponent();
            ExibirDados();
        }
       
        public void CarregarDados()
        {
            cliente.IDCliente = int.Parse(textBoxCodigoCliente.Text);
            cliente.NomeCliente = textNomeCliente.Text;
            cliente.TelefoneCliente = (textBoxTelefoneCliente.Text);
            listCliente.Add(cliente);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listCliente;
        }
        private void ExibirDados()
        {
            listCliente = Cliente.carregarCliente(@"C:\Bd\BdCliente.json");
            dataGridView1.DataSource = listCliente;
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textBoxCodigoCliente.Text += 1;
            textNomeCliente.Text = null;
            textBoxTelefoneCliente.Text = null;
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCodigoCliente.Text);
            var elem = listCliente.Where<Cliente>(x => x.IDCliente == id).FirstOrDefault();
            int index = listCliente.IndexOf(elem);

            listCliente[index].NomeCliente = textNomeCliente.Text;
            listCliente[index].TelefoneCliente = (textBoxTelefoneCliente.Text);
            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCodigoCliente.Text);
            var elem = listCliente.Where<Cliente>(x => x.IDCliente == id).FirstOrDefault();
            listCliente.Remove(elem);


            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados removidos");
            }
            ExibirDados();
        }
        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxCodigoCliente.Text = gridViewRow.Cells[0].Value.ToString();
                textNomeCliente.Text = gridViewRow.Cells[1].Value.ToString();
                textBoxTelefoneCliente.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }
        private void iconPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();

        }

        private void iconCardapio_Click(object sender, EventArgs e)
        {
            Cardapio cardapio = new Cardapio();
            cardapio.Show();
            this.Hide();

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("cliente cadastrado com sucesso!");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void iconCadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUser cadastrarUser = new CadastrarUser();
            cadastrarUser.Show();
            this.Hide();
        }

        private void iconButtonAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDados();
            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdCliente.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textBoxCodigoCliente.Text += 1;
            textNomeCliente.Text = null;
            textBoxTelefoneCliente.Text = null;
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCodigoCliente.Text);
            var elem = listCliente.Where<Cliente>(x => x.IDCliente == id).FirstOrDefault();
            int index = listCliente.IndexOf(elem);

            listCliente[index].NomeCliente = textNomeCliente.Text;
            listCliente[index].TelefoneCliente = (textBoxTelefoneCliente.Text);
            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }

        private void iconButtonExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxCodigoCliente.Text);
            var elem = listCliente.Where<Cliente>(x => x.IDCliente == id).FirstOrDefault();
            listCliente.Remove(elem);


            if (cliente.SalvarDadosCliente(listCliente, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados removidos");
            }
            ExibirDados();
        }
    }
}
