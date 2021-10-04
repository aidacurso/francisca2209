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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
            ExibirDados();
        }
        User User = new User();
        List<User> listUser = new List<User>();


        private void ExibirDados()
        {
            listUser = User.carregarUser(@"C:\Bd\BdUser.json");
        }
        private void linkLabelCadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastrarUser form3 = new CadastrarUser();
            form3.Show();
            this.Hide();
        }

        private void buttonLogar_Click(object sender, EventArgs e)
        {
            string login = textUsuario.Text;
            var elem = listUser.Where<User>(x => x.NomeUser == login).FirstOrDefault();
            int index = listUser.IndexOf(elem);

            if (index == -1)
            {
                MessageBox.Show("os dados inseridos estão incorretos");
            }
            else
            {
                if (listUser[index].SenhaUser == textSenha.Text)
                {
                    MessageBox.Show("login realizado com sucesso");
                    Home home = new Home();
                    home.Show();    
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("os dados inseridos estão incorretos");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
    }
}
