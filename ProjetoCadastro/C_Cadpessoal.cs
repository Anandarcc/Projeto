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
    public class C_Cadpessoal
    {
        private string ID;
        private string NomeCompleto;
        private string CPF;
        private string Email;
        private string Senha;
        private string CargoOcupado;
        private string Salt;
        private C_Conexao c_conexao = new C_Conexao();

        public void cadastropessoal(string nc, string c, string e, string s, string co, string ct)
        {
            SqlConnection conn = c_conexao.abrirConexao();

            string sql = "INSERT INTO T_cadPessoal" + " (NomeCompleto, CPF, Email, Senha, CargoOcupado, Contato, Salt)" + " VALUES(@NomeCompleto, @CPF, @Email, @Senha, @CargoOcupado, @Contato,@Salt)";

            try
            {
                SqlCommand comando = new SqlCommand(sql, conn);

                string salt = PasswordHelper.GenerateSalt();
                string senhaHash = PasswordHelper.HashPassword(s, salt);


                comando.Parameters.Add(new SqlParameter("@NomeCompleto", nc));
                comando.Parameters.Add(new SqlParameter("@CPF", c));
                comando.Parameters.Add(new SqlParameter("@Email", e));
                comando.Parameters.Add(new SqlParameter("@Senha", senhaHash));
                comando.Parameters.Add(new SqlParameter("@CargoOcupado", co));
                comando.Parameters.Add(new SqlParameter("@Contato", ct));
                comando.Parameters.Add(new SqlParameter("@Salt", salt));


                string verificacao = c_conexao.modificarDados(comando, conn);

                if (verificacao != "OK")
                {
                    MessageBox.Show("Cadastro realizado com sucesso", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível realizar o cadastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar o cadastro", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
            public void editarCadastro(string nc, string e,string s,string c, string cpfAntiga, string cpfAtualizada)
        {
            SqlConnection conn = c_conexao.abrirConexao();
            SqlCommand command = new SqlCommand($"UPDATE T_CadPessoal SET NomeCompleto = @NomeCompleto, Email = @Email, Senha = @Senha, Contato = @Contato WHERE CPF = '{cpfAntiga}'", conn);

            try
            {

                command.Parameters.Add(new SqlParameter("@NomeCompleto", nc));
                command.Parameters.Add(new SqlParameter("@Email", e));
                command.Parameters.Add(new SqlParameter("@Senha", s));
                command.Parameters.Add(new SqlParameter("@Contato", c));
                command.Parameters.Add(new SqlParameter("@CPF", cpfAtualizada));

                string verificacao = c_conexao.modificarDados(command, conn);
                if (verificacao == "Ok")
                {
                    MessageBox.Show("Cadastro alterado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o cadastro!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       /*public void editarPerfil(string nomec, string cpf, string email, string senha, string contato)
        {
           /*SqlConnection conn = c_conexao.abrirConexao();
            SqlCommand command = new SqlCommand($"UPDATE T_CadPessoal SET NomeCompleto = @NomeCompleto, Email = @Email, Senha = @Senha, Contato = @Contato WHERE CPF = '{cpf}'", conn);

            try
            {

                command.Parameters.Add(new SqlParameter("@NomeCompleto", nomec));
                command.Parameters.Add(new SqlParameter("@Email", email));
                command.Parameters.Add(new SqlParameter("@Senha", senha));
                command.Parameters.Add(new SqlParameter("@Contato", contato));
                command.Parameters.Add(new SqlParameter("@CPF", cpf));

                string verificacao = c_conexao.modificarDados(command, conn);
                if (verificacao == "Ok")
                {
                    MessageBox.Show("Cadastro alterado com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar o cadastro!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }*/
    }
}
