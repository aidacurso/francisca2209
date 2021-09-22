using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarUser form3 = new CadastrarUser();
            form3.Show();
            this.Hide();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
           // if ( se tiver no json)
            //MessageBox.Show("login feito com sucesso");
            //else (se n tiver)
           // MessageBox.Show("credenciais erradas");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();

        }
    }
}
