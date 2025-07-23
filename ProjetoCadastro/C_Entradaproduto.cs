using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro
{
    public class C_Entradaproduto
    {
        C_Conexao c_conexao = new C_Conexao();

        public SqlDataReader selecionarTodos()
        {
            SqlConnection conn = c_conexao.abrirConexao();
            string command = "SELECT * from dbo.T_entrada";
            SqlDataReader reader = c_conexao.selecionarDadosReader(command, conn);
            return reader; 
        }
    }
}
