namespace ProjetoCadastro
{
    partial class F_editarcadproduto
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
            this.tbxquantidade = new System.Windows.Forms.TextBox();
            this.tbxfornecedor = new System.Windows.Forms.TextBox();
            this.tbxvalor = new System.Windows.Forms.TextBox();
            this.tbxdata = new System.Windows.Forms.TextBox();
            this.tbxmarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxquantidade
            // 
            this.tbxquantidade.Location = new System.Drawing.Point(304, 257);
            this.tbxquantidade.Name = "tbxquantidade";
            this.tbxquantidade.Size = new System.Drawing.Size(213, 20);
            this.tbxquantidade.TabIndex = 20;
            // 
            // tbxfornecedor
            // 
            this.tbxfornecedor.Location = new System.Drawing.Point(304, 223);
            this.tbxfornecedor.Name = "tbxfornecedor";
            this.tbxfornecedor.Size = new System.Drawing.Size(213, 20);
            this.tbxfornecedor.TabIndex = 19;
            // 
            // tbxvalor
            // 
            this.tbxvalor.Location = new System.Drawing.Point(304, 181);
            this.tbxvalor.Name = "tbxvalor";
            this.tbxvalor.Size = new System.Drawing.Size(213, 20);
            this.tbxvalor.TabIndex = 18;
            // 
            // tbxdata
            // 
            this.tbxdata.Location = new System.Drawing.Point(304, 141);
            this.tbxdata.Name = "tbxdata";
            this.tbxdata.Size = new System.Drawing.Size(213, 20);
            this.tbxdata.TabIndex = 17;
            // 
            // tbxmarca
            // 
            this.tbxmarca.Location = new System.Drawing.Point(304, 102);
            this.tbxmarca.Name = "tbxmarca";
            this.tbxmarca.Size = new System.Drawing.Size(213, 20);
            this.tbxmarca.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fornecedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data de Compra:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Marca:";
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(377, 322);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 21;
            this.Editar.Text = "Salvar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // F_editarcadproduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editar);
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
            this.Name = "F_editarcadproduto";
            this.Text = "F_editarcadproduto";
            this.Load += new System.EventHandler(this.F_editarcadproduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxquantidade;
        private System.Windows.Forms.TextBox tbxfornecedor;
        private System.Windows.Forms.TextBox tbxvalor;
        private System.Windows.Forms.TextBox tbxdata;
        private System.Windows.Forms.TextBox tbxmarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Editar;
    }
}