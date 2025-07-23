using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public class C_Entrada
    {
        private C_Conexao c_conexao = new C_Conexao();
        
        public void registrarEntrada(string idPr, string idPe, string q, string d)
        {
            int idProd = Convert.ToInt32(idPr);
            int idPessoal = Convert.ToInt32(idPe);
            int quantidade = Convert.ToInt32(q);
            string data = d;


            SqlConnection conn = c_conexao.abrirConexao();

            string sql = "INSERT INTO T_entrada" + "(idPessoa, idProduto, quantidade, data)" + "VALUES(@idPessoa, @idProduto, @quantidade, @data)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@idProd", idPr));
                comando.Parameters.Add(new SqlParameter("@idPessoal", idPessoal));
                comando.Parameters.Add(new SqlParameter("@quantidade", q));
                comando.Parameters.Add(new SqlParameter("@data", d));

                string verificacao = c_conexao.modificarDados(comando, conn);

                if(verificacao == "Ok")
                {
                    MessageBox.Show("Entrada registrada", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Entrada não registrada", "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Registrar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }
    }
}
