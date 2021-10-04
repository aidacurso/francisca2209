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
    

    public partial class CadastrarUser : Form
    {
        User user = new User();
        List<User> listUser = new List<User>();
        public CadastrarUser()
        {
            InitializeComponent();
            ExibirDados();
        }
        public void CarregarDadosUser()
        {
            user.NomeUser = textUsuario.Text;
            user.SenhaUser = textSenha.Text;
            listUser.Add(user);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listUser;
        }
        private void ExibirDados()
        {
            listUser = User.carregarUser(@"C:\Bd\BdUser.json");
            dataGridView1.DataSource = listUser;
        }


        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDadosUser();
            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textUsuario.Text += 1;
            textSenha.Text = null;

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            string id = (textUsuario.Text);
            var elem = listUser.Where<User>(x => x.NomeUser == id).FirstOrDefault();
            int index = listUser.IndexOf(elem);


            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }
        private void BtnRemover_Click(object sender, EventArgs e)
        {
            string id = textUsuario.Text;
            var elem = listUser.Where<User>(x => x.NomeUser == id).FirstOrDefault();
            listUser.Remove(elem);


            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
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
                textUsuario.Text = gridViewRow.Cells[0].Value.ToString();
                textSenha.Text = gridViewRow.Cells[1].Value.ToString();
            }
        }

 
        private void iconEntrar_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.Show();
            this.Hide();
        }


        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void iconPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();
        }

        private void iconCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrarCliente = new CadastrarCliente();
            cadastrarCliente.Show();
            this.Hide();
        }

        private void iconCardapio_Click(object sender, EventArgs e)
        {
            Cardapio cardapio = new Cardapio();
            cardapio.Show();
            this.Hide();
        }

        private void iconButtonAdicionar_Click(object sender, EventArgs e)
        {
            CarregarDadosUser();
            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
            {
                MessageBox.Show("Dados cadastrados com sucesso!");
            }
            textUsuario.Text += 1;
            textSenha.Text = null;
        }

        private void iconButtonEditar_Click(object sender, EventArgs e)
        {
            string id = (textUsuario.Text);
            var elem = listUser.Where<User>(x => x.NomeUser == id).FirstOrDefault();
            int index = listUser.IndexOf(elem);

            listUser[index].NomeUser = textUsuario.Text;
            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
            {
                MessageBox.Show("Dados salvos");
            }
            ExibirDados();
        }

        private void iconButtonExcluir_Click(object sender, EventArgs e)
        {
           string id = textUsuario.Text;
            var elem = listUser.Where<User>(x => x.NomeUser == id).FirstOrDefault();
            listUser.Remove(elem);


            if (user.SalvarDadosUser(listUser, @"C:\Bd\BdUser.json"))
            {
                MessageBox.Show("Dados removidos");
            }
            ExibirDados();
        }
    }
}
