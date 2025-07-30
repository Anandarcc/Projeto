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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxprodutob = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dgvlistaprodutos = new System.Windows.Forms.DataGridView();
            this.lkleditar = new System.Windows.Forms.LinkLabel();
            this.lklexcluir = new System.Windows.Forms.LinkLabel();
            this.btncadastrarproduto = new System.Windows.Forms.Button();
            this.lklentrada = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistaprodutos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // tbxprodutob
            // 
            this.tbxprodutob.Location = new System.Drawing.Point(81, 27);
            this.tbxprodutob.Name = "tbxprodutob";
            this.tbxprodutob.Size = new System.Drawing.Size(171, 20);
            this.tbxprodutob.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(258, 25);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(78, 23);
            this.btnbuscar.TabIndex = 2;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvlistaprodutos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Centaur", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvlistaprodutos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvlistaprodutos.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvlistaprodutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistaprodutos.Location = new System.Drawing.Point(24, 70);
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
            this.lkleditar.BackColor = System.Drawing.Color.Transparent;
            this.lkleditar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkleditar.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lkleditar.LinkColor = System.Drawing.Color.DarkMagenta;
            this.lkleditar.Location = new System.Drawing.Point(339, 423);
            this.lkleditar.Name = "lkleditar";
            this.lkleditar.Size = new System.Drawing.Size(45, 18);
            this.lkleditar.TabIndex = 4;
            this.lkleditar.TabStop = true;
            this.lkleditar.Text = "Editar";
            this.lkleditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lklexcluir
            // 
            this.lklexcluir.AutoSize = true;
            this.lklexcluir.BackColor = System.Drawing.Color.Transparent;
            this.lklexcluir.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklexcluir.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklexcluir.LinkColor = System.Drawing.Color.DarkMagenta;
            this.lklexcluir.Location = new System.Drawing.Point(390, 423);
            this.lklexcluir.Name = "lklexcluir";
            this.lklexcluir.Size = new System.Drawing.Size(50, 18);
            this.lklexcluir.TabIndex = 23;
            this.lklexcluir.TabStop = true;
            this.lklexcluir.Text = "Excluir";
            this.lklexcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklexcluir_LinkClicked_1);
            // 
            // btncadastrarproduto
            // 
            this.btncadastrarproduto.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrarproduto.Location = new System.Drawing.Point(342, 25);
            this.btncadastrarproduto.Name = "btncadastrarproduto";
            this.btncadastrarproduto.Size = new System.Drawing.Size(141, 23);
            this.btncadastrarproduto.TabIndex = 24;
            this.btncadastrarproduto.Text = "Cadastrar Produto";
            this.btncadastrarproduto.UseVisualStyleBackColor = true;
            this.btncadastrarproduto.Click += new System.EventHandler(this.button1_Click);
            // 
            // lklentrada
            // 
            this.lklentrada.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.lklentrada.AutoSize = true;
            this.lklentrada.BackColor = System.Drawing.Color.Transparent;
            this.lklentrada.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklentrada.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lklentrada.LinkColor = System.Drawing.Color.DarkMagenta;
            this.lklentrada.Location = new System.Drawing.Point(733, 169);
            this.lklentrada.Name = "lklentrada";
            this.lklentrada.Size = new System.Drawing.Size(56, 18);
            this.lklentrada.TabIndex = 25;
            this.lklentrada.TabStop = true;
            this.lklentrada.Text = "Entrada";
            this.lklentrada.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.DarkRed;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DarkMagenta;
            this.linkLabel1.Location = new System.Drawing.Point(733, 192);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(41, 18);
            this.linkLabel1.TabIndex = 26;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Saída";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_2);
            // 
            // F_ControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}