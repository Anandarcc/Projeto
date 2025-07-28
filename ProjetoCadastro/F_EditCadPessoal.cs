using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{

    public partial class F_EditCadPessoal : Form
    {
        int ID;
        string NomeCompleto;
        string CPF;
        string Email;
        string Senha;
        string Contato;
       

        public F_EditCadPessoal( /*int id, string nc, string cpf, string e, string s,string c*/)
        {
            /*ID = id;
            NomeCompleto = nc;
            CPF = cpf;
            Email = e;
            Senha = s;
            Contato = c;*/
            InitializeComponent();
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

        private void lkleditarcadp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /*int id = Convert.ToInt32(dgvcadastropessoal.CurrentRow.Cells[0].Value.ToString());
            string nomecompleto = dgvcadastropessoal.CurrentRow.Cells[1].Value.ToString();
            string cpf = dgvcadastropessoal.CurrentRow.Cells[2].Value.ToString();
            string email = dgvcadastropessoal.CurrentRow.Cells[3].Value.ToString();
            string senha = dgvcadastropessoal.CurrentRow.Cells[4].Value.ToString();
            string contato = dgvcadastropessoal.CurrentRow.Cells[5].Value.ToString();

            F_EditCadPessoal telaeditarcadpessoal = new F_EditCadPessoal(id, nomecompleto,cpf, email,senha,contato);
            telaeditarcadpessoal.Show();*/
        }

        private void lklexcluircadp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /* SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; Initial Catalog=Cadastro; Integrated Security=true");
            SqlCommand command = new SqlCommand("DELETE FROM T_cadPessoal WHERE ID = @ID", conn);
            int id = Convert.ToInt32(dgvcadastropessoal.CurrentRow.Cells[0].Value.ToString());
            try
            {
                command.Parameters.Add(new SqlParameter("@ID", id));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Cadastro deletado com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
            tbxnomeed.Text = dgvcadastropessoal.CurrentRow.Cells[1].Value.ToString();
            tbxcpfed.Text = dgvcadastropessoal.CurrentRow.Cells[2].Value.ToString();
            tbxemailed.Text = dgvcadastropessoal.CurrentRow.Cells[3].Value.ToString();
            tbxsenhaed.Text = dgvcadastropessoal.CurrentRow.Cells[4].Value.ToString();
            tbxcontatoed.Text = dgvcadastropessoal.CurrentRow.Cells[5].Value.ToString();

       
        }

        private void F_EditCadPessoal_Load(object sender, EventArgs e)
        {
            C_Cadpessoal c_cadastropessoal = new C_Cadpessoal();
            try
            {
                SqlDataAdapter da = c_cadastropessoal.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvcadastropessoal.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           /* SqlConnection sql = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            string command = "select Marca, Datadecompra, Valor, Fornecedor, Quantidade from dbo.T_Cadastros_Produtos";
            try
            {
                sql.Open();
                SqlDataAdapter da = c_cadastroprodutos.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvlistaprodutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}
