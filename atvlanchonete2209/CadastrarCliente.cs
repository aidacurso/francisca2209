using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class CadastrarCliente : Form
    {
        public CadastrarCliente()
        {
            InitializeComponent();
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
    }
}
