namespace ProjetoCadastro
{
    partial class F_cadastrodeprodutos
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
            this.btncadastrarpr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxmarca = new System.Windows.Forms.TextBox();
            this.tbxdata = new System.Windows.Forms.TextBox();
            this.tbxvalor = new System.Windows.Forms.TextBox();
            this.tbxfornecedor = new System.Windows.Forms.TextBox();
            this.tbxquantidade = new System.Windows.Forms.TextBox();
            this.tbxproduto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncadastrarpr
            // 
            this.btncadastrarpr.Location = new System.Drawing.Point(321, 328);
            this.btncadastrarpr.Name = "btncadastrarpr";
            this.btncadastrarpr.Size = new System.Drawing.Size(123, 23);
            this.btncadastrarpr.TabIndex = 0;
            this.btncadastrarpr.Text = "Cadastrar Produto";
            this.btncadastrarpr.UseVisualStyleBackColor = true;
            this.btncadastrarpr.Click += new System.EventHandler(this.btncadastrarpr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fornecedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade:";
            // 
            // tbxmarca
            // 
            this.tbxmarca.Location = new System.Drawing.Point(279, 99);
            this.tbxmarca.Name = "tbxmarca";
            this.tbxmarca.Size = new System.Drawing.Size(213, 20);
            this.tbxmarca.TabIndex = 6;
            // 
            // tbxdata
            // 
            this.tbxdata.Location = new System.Drawing.Point(279, 141);
            this.tbxdata.Name = "tbxdata";
            this.tbxdata.Size = new System.Drawing.Size(213, 20);
            this.tbxdata.TabIndex = 7;
            // 
            // tbxvalor
            // 
            this.tbxvalor.Location = new System.Drawing.Point(279, 183);
            this.tbxvalor.Name = "tbxvalor";
            this.tbxvalor.Size = new System.Drawing.Size(213, 20);
            this.tbxvalor.TabIndex = 8;
            // 
            // tbxfornecedor
            // 
            this.tbxfornecedor.Location = new System.Drawing.Point(279, 227);
            this.tbxfornecedor.Name = "tbxfornecedor";
            this.tbxfornecedor.Size = new System.Drawing.Size(213, 20);
            this.tbxfornecedor.TabIndex = 9;
            // 
            // tbxquantidade
            // 
            this.tbxquantidade.Location = new System.Drawing.Point(279, 270);
            this.tbxquantidade.Name = "tbxquantidade";
            this.tbxquantidade.Size = new System.Drawing.Size(213, 20);
            this.tbxquantidade.TabIndex = 10;
            // 
            // tbxproduto
            // 
            this.tbxproduto.Location = new System.Drawing.Point(279, 57);
            this.tbxproduto.Name = "tbxproduto";
            this.tbxproduto.Size = new System.Drawing.Size(213, 20);
            this.tbxproduto.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Produto";
            // 
            // F_cadastrodeprodutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxproduto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxquantidade);
            this.Controls.Add(this.tbxfornecedor);
            this.Controls.Add(this.tbxvalor);
            this.Controls.Add(this.tbxdata);
            this.Controls.Add(this.tbxmarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncadastrarpr);
            this.Name = "F_cadastrodeprodutos";
            this.Text = "F_cadastrodeprodutos";
            this.Load += new System.EventHandler(this.F_cadastrodeprodutos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncadastrarpr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxmarca;
        private System.Windows.Forms.TextBox tbxdata;
        private System.Windows.Forms.TextBox tbxvalor;
        private System.Windows.Forms.TextBox tbxfornecedor;
        private System.Windows.Forms.TextBox tbxquantidade;
        private System.Windows.Forms.TextBox tbxproduto;
        private System.Windows.Forms.Label label6;
    }
}