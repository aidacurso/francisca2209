using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class Pedido : Form
    {
        public Pedido()
        {
            InitializeComponent();
        }

        private void iconCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadastrar = new CadastrarCliente();
            cadastrar.Show();
            this.Hide();
        }

        private void iconCardapio_Click(object sender, EventArgs e)
        {
            Cardapio cardapio = new Cardapio();
            cardapio.Show();
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
    }
}
