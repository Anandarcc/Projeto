using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public class C_Conexao
    {
        public SqlConnection abrirConexao()
        {
            string strconn = ("Data Source = SOB041996L4B1PC\\SQLEXPRESS;" + "Initial Catalog = Cadastro; Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
        public string modificarDados(SqlCommand c, SqlConnection conn)
        {
            try
            {
                conn.Open();
                c.ExecuteNonQuery();
                conn.Close();
                return "Ok";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Error";
            }
        }
    }
}
