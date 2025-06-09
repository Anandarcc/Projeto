using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            String email = tbxemail.Text;
            String senha = tbxsenha.Text;

            if (email == "adm@gmail.com" && senha == "2207")
            {
                F_cadastrodeprodutos telaprodutos = new F_cadastrodeprodutos();
                telaprodutos.Show();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos");
            }
        }

        private void llkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_cadastropessoal telacadastroP = new F_cadastropessoal();
            telacadastroP.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
