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
    public partial class Cardapio : Form
    {
        Produtos produto = new Produtos();
        List<Produtos> listProd = new List<Produtos>();
        public Cardapio()
        {
            InitializeComponent();
            ExibirDados();
        }

        public void CarregarDados()
        {
            produto.IDProduto = int.Parse(textBoxIDProduto.Text);
            produto.NomeProdutos = textBoxNomeProduto.Text;
            produto.PrecoProdutos = double.Parse(textBoxPrecoProduto.Text);
            listProd.Add(produto);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listProd;
        }
        private void ExibirDados()
        {
            listProd = Produtos.carregarProdutos(@"C:\Bd\BdProdutos.json");
            dataGridView1.DataSource = listProd;
        }

      
    
        private void Editar(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow gridViewRow = dataGridView1.Rows[e.RowIndex];
                textBoxIDProduto.Text = gridViewRow.Cells[0].Value.ToString();
                textBoxNomeProduto.Text = gridViewRow.Cells[1].Value.ToString();
                textBoxPrecoProduto.Text = gridViewRow.Cells[2].Value.ToString();
            }
        }
        private void iconCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
            this.Hide();
        }

        private void iconPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();

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
            if (produto.SalvarDadosProdutos(listProd, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textBoxIDProduto.Text += 1;
            textBoxNomeProduto.Text = null;
            textBoxPrecoProduto.Text = null;
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxIDProduto.Text);
            var elem = listProd.Where<Produtos>(x => x.IDProduto == id).FirstOrDefault();
            int index = listProd.IndexOf(elem);

            listProd[index].NomeProdutos = textBoxNomeProduto.Text;
            listProd[index].PrecoProdutos = double.Parse(textBoxPrecoProduto.Text);
            if (produto.SalvarDadosProdutos(listProd, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }

        private void iconButtonExcluir_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxIDProduto.Text);
            var elem = listProd.Where<Produtos>(x => x.IDProduto == id).FirstOrDefault();
            listProd.Remove(elem);


            if (produto.SalvarDadosProdutos(listProd, @"C:\Bd\BdProdutos.json"))
            {
                MessageBox.Show("Dados removidos");
            }
            ExibirDados();
        }
    }
}
