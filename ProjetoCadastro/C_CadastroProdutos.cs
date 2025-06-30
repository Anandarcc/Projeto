using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public class C_CadastroProdutos
    {
        private string ID;
        private string Marca;
        private string Datadecompra;
        private string Valor;
        private string Fornecedor;
        private string Quantidade;
        private C_Conexao c_conexao = new C_Conexao();


        public void cadastrodeprodutos( string m, string dc,string v, string f, string q)
        {
            SqlConnection conn = c_conexao.abrirConexao();

            string sql = "INSERT INTO T_Cadastros_Produtos" + " (Marca, Datadecompra, Valor, Fornecedor, Quantidade)" + " VALUES( @Marca, @Datadecompra, @Valor, @Fornecedor,@Quantidade)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
              
                comando.Parameters.Add(new SqlParameter("@Marca", m));
                comando.Parameters.Add(new SqlParameter("@Datadecompra", dc));
                comando.Parameters.Add(new SqlParameter("@Valor", Convert.ToDouble(v)));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", f));
                comando.Parameters.Add(new SqlParameter("@Quantidade", Convert.ToInt32(q)));

                string verificacao = c_conexao.modificarDados(comando, conn);

                if(verificacao != "ok")
                {
                    MessageBox.Show("Produto cadastrado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar cadastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar cadastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
