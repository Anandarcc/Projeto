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
    public partial class F_buscar : Form
    {
        public F_buscar()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void F_buscar_Load(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            string command = "select Marca, Datadecompra, Valor, Fornecedor, Quantidade from dbo.T_Cadastros_Produtos";
            try
            {
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvlistaprodutos.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_editarcadproduto telaeditarcadp = new F_editarcadproduto();
            telaeditarcadp.Show();
        }
    }
}
