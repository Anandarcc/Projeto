using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public class C_CadastroProdutos
    {
        private string Produto;
        private string Marca;
        private string Datadecompra;
        private string Valor;
        private string Fornecedor;
        private string Quantidade;
        private C_Conexao c_conexao = new C_Conexao();


        public void cadastrodeprodutos(string p, string m, string dc, string v, string f, string q)
        {
            SqlConnection conn = c_conexao.abrirConexao();

            string sql = "INSERT INTO T_cad_deprodutos2" + " (Produto, Marca, Datadecompra, Valor, Fornecedor, Quantidade)" + " VALUES( @Produto, @Marca, @Datadecompra, @Valor, @Fornecedor,@Quantidade)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);

                comando.Parameters.Add(new SqlParameter("@Produto", p));
                comando.Parameters.Add(new SqlParameter("@Marca", m));
                comando.Parameters.Add(new SqlParameter("@Datadecompra", dc));
                comando.Parameters.Add(new SqlParameter("@Valor", Convert.ToDouble(v)));
                comando.Parameters.Add(new SqlParameter("@Fornecedor", f));
                comando.Parameters.Add(new SqlParameter("@Quantidade", Convert.ToInt32(q)));

                string verificacao = c_conexao.modificarDados(comando, conn);

                if (verificacao != "ok")
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

            public SqlDataAdapter selecionarTodos()
            {
                SqlConnection conn = c_conexao.abrirConexao();
                string command = "Select ID, Produto, Marca, Datadecompra, Valor, Fornecedor, Quantidade from dbo.T_cad_deprodutos2";
                SqlDataAdapter da = c_conexao.selecionarDados(command, conn);
                conn.Close();
                return da;

            }
             public SqlDataReader selecionarNomes()
            {
            SqlConnection conn = c_conexao.abrirConexao();
            string command = "SELECT Marca from dbo.T_cad_deprodutos2";
            SqlDataReader reader = c_conexao.selecionarDadosReader(command, conn);
            return reader;
            }
             
        }
    }

