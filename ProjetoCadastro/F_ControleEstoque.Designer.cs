namespace ProjetoCadastro
{
    partial class F_ControleEstoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxprodutob = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvlistaprodutos = new System.Windows.Forms.DataGridView();
            this.lkleditar = new System.Windows.Forms.LinkLabel();
            this.lklexcluir = new System.Windows.Forms.LinkLabel();
            this.btncadastrarproduto = new System.Windows.Forms.Button();
            this.lklentrada = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // tbxprodutob
            // 
            this.tbxprodutob.Location = new System.Drawing.Point(71, 27);
            this.tbxprodutob.Name = "tbxprodutob";
            this.tbxprodutob.Size = new System.Drawing.Size(171, 20);
            this.tbxprodutob.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(258, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvlistaprodutos
            // 
            this.dgvlistaprodutos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvlistaprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaprodutos.Location = new System.Drawing.Point(24, 65);
            this.dgvlistaprodutos.Name = "dgvlistaprodutos";
            this.dgvlistaprodutos.ReadOnly = true;
            this.dgvlistaprodutos.RowHeadersVisible = false;
            this.dgvlistaprodutos.Size = new System.Drawing.Size(685, 350);
            this.dgvlistaprodutos.TabIndex = 3;
            this.dgvlistaprodutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistaprodutos_CellContentClick);
            // 
            // lkleditar
            // 
            this.lkleditar.AutoSize = true;
            this.lkleditar.Location = new System.Drawing.Point(339, 428);
            this.lkleditar.Name = "lkleditar";
            this.lkleditar.Size = new System.Drawing.Size(34, 13);
            this.lkleditar.TabIndex = 4;
            this.lkleditar.TabStop = true;
            this.lkleditar.Text = "Editar";
            this.lkleditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lklexcluir
            // 
            this.lklexcluir.AutoSize = true;
            this.lklexcluir.Location = new System.Drawing.Point(392, 428);
            this.lklexcluir.Name = "lklexcluir";
            this.lklexcluir.Size = new System.Drawing.Size(38, 13);
            this.lklexcluir.TabIndex = 23;
            this.lklexcluir.TabStop = true;
            this.lklexcluir.Text = "Excluir";
            this.lklexcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklexcluir_LinkClicked_1);
            // 
            // btncadastrarproduto
            // 
            this.btncadastrarproduto.Location = new System.Drawing.Point(342, 25);
            this.btncadastrarproduto.Name = "btncadastrarproduto";
            this.btncadastrarproduto.Size = new System.Drawing.Size(118, 23);
            this.btncadastrarproduto.TabIndex = 24;
            this.btncadastrarproduto.Text = "Cadastrar Produto";
            this.btncadastrarproduto.UseVisualStyleBackColor = true;
            this.btncadastrarproduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lklentrada
            // 
            this.lklentrada.AutoSize = true;
            this.lklentrada.Location = new System.Drawing.Point(733, 169);
            this.lklentrada.Name = "lklentrada";
            this.lklentrada.Size = new System.Drawing.Size(44, 13);
            this.lklentrada.TabIndex = 25;
            this.lklentrada.TabStop = true;
            this.lklentrada.Text = "Entrada";
            this.lklentrada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // F_ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lklentrada);
            this.Controls.Add(this.btncadastrarproduto);
            this.Controls.Add(this.lklexcluir);
            this.Controls.Add(this.lkleditar);
            this.Controls.Add(this.dgvlistaprodutos);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbxprodutob);
            this.Controls.Add(this.label1);
            this.Name = "F_ControleEstoque";
            this.Text = "F_buscar";
            this.Load += new System.EventHandler(this.F_buscar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaprodutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxprodutob;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dgvlistaprodutos;
        private System.Windows.Forms.LinkLabel lkleditar;
        private System.Windows.Forms.LinkLabel lklexcluir;
        private System.Windows.Forms.Button btncadastrarproduto;
        private System.Windows.Forms.LinkLabel lklentrada;
    }
}