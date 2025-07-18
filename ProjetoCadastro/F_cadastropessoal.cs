using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            C_Cadpessoal telacadpessoal = new C_Cadpessoal();
            telacadpessoal.cadastropessoal(tbxnome.Text, tbxcpf.Text, tbxemail.Text, tbxsenha.Text, cbxcargo.Text, tbxcontato.Text);

        }

        private void F_cadastropessoal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*F_EditCadPessoal telaeditcadpessoal = new F_EditCadPessoal();
            telaeditcadpessoal.Show();*/
        }
    }
}
