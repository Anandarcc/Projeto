﻿using System;
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
    public partial class F_ControleEstoque : Form
    {
        public F_ControleEstoque()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            SqlConnection sql = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            string buscarnome = tbxprodutob.Text; 
            string command = $"select Produto, Marca, Datadecompra, Valor, Fornecedor, Quantidade from dbo.T_cad_deprodutos2 WHERE Produto LIKE '%{buscarnome}%'";
            try
            {
                sql.Open();
                SqlDataAdapter da = new SqlDataAdapter(command, sql);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvlistaprodutos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void F_buscar_Load(object sender, EventArgs e)
        {
            C_CadastroProdutos c_cadastroprodutos = new C_CadastroProdutos();
           /* SqlConnection sql = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; " + "Initial Catalog=Cadastro; Integrated Security=true");
            string command = "select Marca, Datadecompra, Valor, Fornecedor, Quantidade from dbo.T_Cadastros_Produtos";*/
            try
            {
                /*sql.Open();*/
                SqlDataAdapter da = c_cadastroprodutos.selecionarTodos();
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvlistaprodutos.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Listar Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            int id = Convert.ToInt32(dgvlistaprodutos.CurrentRow.Cells[0].Value.ToString());
            string produto = dgvlistaprodutos.CurrentRow.Cells[1].Value.ToString();
            string marca = dgvlistaprodutos.CurrentRow.Cells[2].Value.ToString();
            string data = dgvlistaprodutos.CurrentRow.Cells[3].Value.ToString();
            string valor = dgvlistaprodutos.CurrentRow.Cells[4].Value.ToString();
            string fornecedor = dgvlistaprodutos.CurrentRow.Cells[5].Value.ToString();
            string quantidade = dgvlistaprodutos.CurrentRow.Cells[6].Value.ToString();

             F_editarcadproduto telaeditarcadp = new F_editarcadproduto(id, produto, marca,data, valor, fornecedor,quantidade);
             telaeditarcadp.Show();

        }

        private void btnselecionar_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvlistaprodutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lklexcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void lklexcluir_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
           SqlConnection conn = new SqlConnection("Data Source=SOB041996L4B1PC\\SQLEXPRESS; Initial Catalog=Cadastro; Integrated Security=true");
            SqlCommand command = new SqlCommand("DELETE FROM T_cad_deprodutos2 WHERE Produto = @Produto", conn);
            string Produto = dgvlistaprodutos.CurrentRow.Cells[1].Value.ToString();
            try
            {
                command.Parameters.Add(new SqlParameter("@Produto", Produto));
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Registro deletado com sucesso!", "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_cadastrodeprodutos telacadproduto = new F_cadastrodeprodutos();
            telacadproduto.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Entrada telaentrada = new F_Entrada();
            telaentrada.Show();
        }
    }
}
