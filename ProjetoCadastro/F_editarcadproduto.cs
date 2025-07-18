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
    public partial class F_editarcadproduto : Form
    {
        int ID;
        DataGridView dgvlistaprodutos;
        string produto;
        string marca;
        string data;
        string valor;
        string fornecedor;
        string quantidade;
        public F_editarcadproduto(int id, string p, string m, string d, string v,string fr,string q)
        {
            ID = id;
            produto = p;
            marca = m;
            data = d;
            valor = v;
            fornecedor = fr;
            quantidade = q;
           
            InitializeComponent();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
         
            SqlCommand command = new SqlCommand($"UPDATE T_cad_deprodutos2 SET @Produto = Produto, Marca = @Marca, Datadecompra = @Datadecompra, Valor = @Valor, Fornecedor = @Fornecedor, Quantidade = @Quantidade WHERE ID = {ID}",conn); 
            try
            {
                command.Parameters.Add(new SqlParameter("@Produto", tbxprodutoed.Text));
                command.Parameters.Add(new SqlParameter("@Marca", tbxmarca.Text));
                command.Parameters.Add(new SqlParameter("@Datadecompra", tbxdata.Text));
                command.Parameters.Add(new SqlParameter("@Valor", tbxvalor.Text));
                command.Parameters.Add(new SqlParameter("@Fornecedor", tbxfornecedor.Text));
                command.Parameters.Add(new SqlParameter("@Quantidade", tbxquantidade.Text));

                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Alteração realizada com sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void F_editarcadproduto_Load(object sender, EventArgs e)
        {
            tbxprodutoed.Text = produto;
            tbxmarca.Text = marca;
            tbxdata.Text = data;
            tbxvalor.Text = valor;
            tbxfornecedor.Text = fornecedor;
            tbxquantidade.Text = quantidade;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           
        }

        private void lklexcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           /*SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; Initial Catalog=Cadastro; Integrated Security=true");
            SqlCommand command = new SqlCommand("DELETE FROM T_Cadastros_Produtos WHERE ID = @ID", conn);
            ID = Convert.ToInt32(dgvlistaprodutos.CurrentRow.Cells[1].Value);
            try
            {
                command.Parameters.Add(new SqlParameter("@ID", ID));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro deletado com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }
    }
}
