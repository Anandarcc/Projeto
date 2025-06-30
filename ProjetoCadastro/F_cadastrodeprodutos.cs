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
    public partial class F_cadastrodeprodutos : Form
    {
        public F_cadastrodeprodutos()
        {
            InitializeComponent();
        }

        private void btncadastrarpr_Click(object sender, EventArgs e)
        {
            C_CadastroProdutos telacadp = new C_CadastroProdutos();
            telacadp.cadastrodeprodutos(tbxmarca.Text, tbxdata.Text, tbxvalor.Text, tbxfornecedor.Text, tbxquantidade.Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_buscar telabuscar = new F_buscar();
            telabuscar.Show();
        }

        private void F_cadastrodeprodutos_Load(object sender, EventArgs e)
        {

        }
    }
}
