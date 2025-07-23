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
    public partial class F_Entrada : Form
    {
        public F_Entrada()
        {
            InitializeComponent();
        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            string[] partes = cbxprodutoentrada.Text.Split('-');
            string idproduto = partes[0].Trim();
            partes = cbxresponsavelentrada.Text.Split('-');
            string idresponsavel = partes[0].Trim();
            string quantidade = tbxquantidadentrada.Text;
            string data = dtpentrada.Text;


            C_Entrada c_Entrada = new C_Entrada();
            c_Entrada.registrarEntrada(idproduto, idresponsavel, quantidade, data);


        }

        private void F_Entrada_Load(object sender, EventArgs e)
        {

            try
            {
                C_Entradaproduto c_entradapr = new C_Entradaproduto();
                SqlDataReader reader = c_entradapr.selecionarTodos();
                while (reader.Read())
                {
                    string id = reader["ID"].ToString();
                    string produto = reader["Produto"].ToString();
                    string idproduto = $"{id} - {produto}";
                    cbxprodutoentrada.Items.Add(idproduto);

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao carregar produto: " + ex.Message);
            }
        }
    }
}
