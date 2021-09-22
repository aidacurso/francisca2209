using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace atvlanchonete2209
{
    public partial class CadastrarUser : Form
    {
        public CadastrarUser()
        {
            InitializeComponent();
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
    }
}
