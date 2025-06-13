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
    public partial class F_editarcadproduto : Form
    {
        public F_editarcadproduto()
        {
            InitializeComponent();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            SqlCommand command = new SqlCommand("UPDATE T_Cadastros_Produtos SET Marca = @Marca, ")
        }
    }
}
