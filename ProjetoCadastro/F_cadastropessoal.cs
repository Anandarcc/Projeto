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
            //conexão com banco de dados

            string strconn = ("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);

            //Comando sql
            string sql = "INSERT INTO T_Cadastro_Pessoal" + "(NomeCompleto, CPF, Email, CargoOcupado, Contato)" + "VALUES(@NomeCompleto, @CPF, @Email, @CargoOcupado,@Contato)";

            try
            {
                //Adiconar Parâmetros
                SqlCommand comando = new SqlCommand(sql, conn);
                comando.Parameters.Add(new SqlParameter("@NomeCompleto", tbxnome.Text));
                comando.Parameters.Add(new SqlParameter("@CPF", tbxcpf.Text)); 
                comando.Parameters.Add(new SqlParameter("@Email", tbxemail.Text));
                comando.Parameters.Add(new SqlParameter("@CargoOcupado", cbxcargo.Text));
                comando.Parameters.Add(new SqlParameter("@Contato", tbxcontato.Text));

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
    }
}
