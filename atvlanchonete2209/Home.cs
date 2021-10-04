using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
           
        }

       

        private void iconEntrar_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.Show();
            this.Hide(); 
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

        private void iconCardapio_Click(object sender, EventArgs e)
        {
            Cardapio cardapio = new Cardapio();
            cardapio.Show();
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
