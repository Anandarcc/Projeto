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
    public partial class F_cadastropessoal : Form
    {
        public F_cadastropessoal()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome = tbxnome.Text;
            String cpf = tbxcpf.Text;
            String email = tbxemail.Text;
            String cargo = cbxcargo.Text;
            String contato = tbxcontato.Text;

            MessageBox.Show("Preencha os campos");

        }
    }
}
