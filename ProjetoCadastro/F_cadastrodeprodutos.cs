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
            //conexão com banco de dados

            string strconn = ("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);

            //Comando sql
            string sql = "INSERT INTO T_Cadastros_Produtos (Marca, Datadecompra, Valor, Fornecedor, Quantidade) VALUES(@Marca, @Datadecompra, @Valor, @Fornecedor,@Quantidade)";

            try
            {
                //Adiconar Parâmetros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@Marca", tbxmarca.Text));
                comando.Parameters.Add(new SqlParameter("@Datadecompra", tbxdata.Text));
                comando.Parameters.Add(new SqlParameter("@Valor", tbxvalor.Text));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", tbxfornecedor.Text));
                comando.Parameters.Add(new SqlParameter("@Quantidade", tbxquantidade.Text));

                //abrir conexão
                conn.Open();
                //Executar comando Sql
                comando.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastro realizado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Não foi possível cadastrar!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //fechar conexão
                conn.Close();
            }
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
