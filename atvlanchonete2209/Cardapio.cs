using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class Cardapio : Form
    {
        public Cardapio()
        {
            InitializeComponent();
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



        private void labelCardapio_Click(object sender, EventArgs e)
        {

        }

        private void iconcardap_Click(object sender, EventArgs e)
        {

        }

        private void iconCardapio_Click(object sender, EventArgs e)
        {

        }
    }
}
