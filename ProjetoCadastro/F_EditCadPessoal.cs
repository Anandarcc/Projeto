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

    public partial class F_EditCadPessoal : Form
    {
        /*int ID;
        string NomeCompleto;
        string CPF;
        string Email;
        string Senha;
        string Contato;*/
       

        public F_EditCadPessoal(/*int id, string nc, string cpf, string e, string s,string c*/)
        {
            /*ID = id;
            NomeCompleto = nc;
            CPF = cpf;
            Email = e;
            Senha = s;
            Contato = c;
            InitializeComponent();*/
        }

        private void btnsalvarcadp_Click(object sender, EventArgs e)
        {
           /*SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            
            SqlCommand command = new SqlCommand($"UPDATE T_cadPessoal SET @NomeCompleto = NomeCompleto, CPF = @CPF, Email = @Email, Senha = @Senha, Contato = @Contato WHERE ID = {ID}", conn);
            try
            {
                command.Parameters.Add(new SqlParameter("@NomeCompleto", tbxnomeed.Text));
                command.Parameters.Add(new SqlParameter("@CPF", tbxcpfed.Text));
                command.Parameters.Add(new SqlParameter("@Email", tbxemailed.Text));
                command.Parameters.Add(new SqlParameter("@Senha", tbxsenhaed.Text));
                command.Parameters.Add(new SqlParameter("@Contato", tbxcontatoed.Text));

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alteração realizada com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
