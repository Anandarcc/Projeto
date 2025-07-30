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
    public partial class F_Saida : Form
    {
        public F_Saida()
        {
            InitializeComponent();
        }

        private void F_Saida_Load(object sender, EventArgs e)
        {
            try
            {
                C_SaidaProdutos c_saidapr = new C_SaidaProdutos();
                SqlDataReader reader = c_saidapr.selecionarTodos();
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string produto = reader["Produto"].ToString();
                    string idproduto = $"{id} - {produto}";
                    cbxprodutosaida.Items.Add(idproduto);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produto: " + ex.Message);
            }

            try
            {
                C_Cadpessoal c_cadpessoal = new C_Cadpessoal();
                SqlDataReader reader = c_cadpessoal.selecionarTodosReader();
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string nome = reader["NomeCompleto"].ToString();
                    string idresponsavel = $"{id} - {nome}";
                    cbxresponsavelsaida.Items.Add(idresponsavel);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar nomes: " + ex.Message);
            }
        }

        private void btnregistrarsaida_Click(object sender, EventArgs e)
        {
            string[] partes = cbxprodutosaida.Text.Split('-');
            string idproduto = partes[0].Trim();
            partes = cbxresponsavelsaida.Text.Split('-');
            string idresponsavel = partes[0].Trim();
            string quantidade = tbxquantsaida.Text;
            string data = dtpdatasaida.Text;


            C_Saida c_Saida = new C_Saida();
            c_Saida.registrarSaida(idproduto, idresponsavel, quantidade, data);
        }
    }
}
