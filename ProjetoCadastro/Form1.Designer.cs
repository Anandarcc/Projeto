namespace ProjetoCadastro
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxemail = new System.Windows.Forms.TextBox();
            this.tbxsenha = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.llkcadastro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // tbxemail
            // 
            this.tbxemail.Location = new System.Drawing.Point(266, 93);
            this.tbxemail.Name = "tbxemail";
            this.tbxemail.Size = new System.Drawing.Size(259, 20);
            this.tbxemail.TabIndex = 2;
            // 
            // tbxsenha
            // 
            this.tbxsenha.Location = new System.Drawing.Point(266, 134);
            this.tbxsenha.Name = "tbxsenha";
            this.tbxsenha.Size = new System.Drawing.Size(259, 20);
            this.tbxsenha.TabIndex = 3;
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(359, 204);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(75, 23);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Não possui cadastro?";
            // 
            // llkcadastro
            // 
            this.llkcadastro.AutoSize = true;
            this.llkcadastro.Location = new System.Drawing.Point(413, 312);
            this.llkcadastro.Name = "llkcadastro";
            this.llkcadastro.Size = new System.Drawing.Size(49, 13);
            this.llkcadastro.TabIndex = 6;
            this.llkcadastro.TabStop = true;
            this.llkcadastro.Text = "Cadastro";
            this.llkcadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llkcadastro_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.llkcadastro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.tbxsenha);
            this.Controls.Add(this.tbxemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxemail;
        private System.Windows.Forms.TextBox tbxsenha;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel llkcadastro;
    }
}

