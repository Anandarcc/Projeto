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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            
            String email = tbxemail.Text;
            String senha = tbxsenha.Text;

            string strconn = ("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            SqlConnection conn = new SqlConnection(strconn);

            try
            {
            
                conn.Open();
                string sql = "SELECT Senha, Salt FROM T_cadPessoal" + " WHERE Email = @Email";//humilhação
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Email", email);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string senhaHashBanco = reader.GetString(0);
                        string saltBanco = reader.GetString(1);
                        saltBanco = saltBanco.Replace(" ", "");
                        string senhaHashDigitada = PasswordHelper.HashPassword(senha, saltBanco);

                        senhaHashBanco = senhaHashBanco.Replace(" ", "");
                        senhaHashDigitada = senhaHashDigitada.Replace(" ", "");

                        if(senhaHashDigitada == senhaHashBanco)
                        {
                            F_ControleEstoque telacontrole = new F_ControleEstoque();
                            telacontrole.ShowDialog();
                            this.Close();
                        
                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Email incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llkcadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_cadastropessoal telacadastroP = new F_cadastropessoal();
            telacadastroP.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
