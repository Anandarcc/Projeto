namespace ProjetoCadastro
{
    partial class F_EditCadPessoal
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
            this.tbxsenhaed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxcontatoed = new System.Windows.Forms.TextBox();
            this.tbxemailed = new System.Windows.Forms.TextBox();
            this.tbxcpfed = new System.Windows.Forms.TextBox();
            this.tbxnomeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsalvarcadp = new System.Windows.Forms.Button();
            this.dgvcadastropessoal = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnselecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcadastropessoal)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxsenhaed
            // 
            this.tbxsenhaed.Location = new System.Drawing.Point(520, 263);
            this.tbxsenhaed.Name = "tbxsenhaed";
            this.tbxsenhaed.Size = new System.Drawing.Size(293, 20);
            this.tbxsenhaed.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Senha";
            // 
            // tbxcontatoed
            // 
            this.tbxcontatoed.Location = new System.Drawing.Point(520, 300);
            this.tbxcontatoed.Name = "tbxcontatoed";
            this.tbxcontatoed.Size = new System.Drawing.Size(293, 20);
            this.tbxcontatoed.TabIndex = 22;
            // 
            // tbxemailed
            // 
            this.tbxemailed.Location = new System.Drawing.Point(520, 226);
            this.tbxemailed.Name = "tbxemailed";
            this.tbxemailed.Size = new System.Drawing.Size(293, 20);
            this.tbxemailed.TabIndex = 21;
            // 
            // tbxcpfed
            // 
            this.tbxcpfed.Location = new System.Drawing.Point(520, 195);
            this.tbxcpfed.Name = "tbxcpfed";
            this.tbxcpfed.Size = new System.Drawing.Size(293, 20);
            this.tbxcpfed.TabIndex = 20;
            // 
            // tbxnomeed
            // 
            this.tbxnomeed.Location = new System.Drawing.Point(520, 164);
            this.tbxnomeed.Name = "tbxnomeed";
            this.tbxnomeed.Size = new System.Drawing.Size(293, 20);
            this.tbxnomeed.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(391, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Contato:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(390, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(390, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nome Completo:";
            // 
            // btnsalvarcadp
            // 
            this.btnsalvarcadp.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalvarcadp.Location = new System.Drawing.Point(635, 356);
            this.btnsalvarcadp.Name = "btnsalvarcadp";
            this.btnsalvarcadp.Size = new System.Drawing.Size(86, 28);
            this.btnsalvarcadp.TabIndex = 26;
            this.btnsalvarcadp.Text = "Salvar";
            this.btnsalvarcadp.UseVisualStyleBackColor = true;
            this.btnsalvarcadp.Click += new System.EventHandler(this.btnsalvarcadp_Click);
            // 
            // dgvcadastropessoal
            // 
            this.dgvcadastropessoal.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvcadastropessoal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcadastropessoal.Location = new System.Drawing.Point(28, 24);
            this.dgvcadastropessoal.Name = "dgvcadastropessoal";
            this.dgvcadastropessoal.Size = new System.Drawing.Size(345, 397);
            this.dgvcadastropessoal.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(597, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 26);
            this.label4.TabIndex = 30;
            this.label4.Text = "Editar cadastro";
            // 
            // btnselecionar
            // 
            this.btnselecionar.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnselecionar.Location = new System.Drawing.Point(178, 441);
            this.btnselecionar.Name = "btnselecionar";
            this.btnselecionar.Size = new System.Drawing.Size(84, 29);
            this.btnselecionar.TabIndex = 31;
            this.btnselecionar.Text = "Selecionar";
            this.btnselecionar.UseVisualStyleBackColor = true;
            this.btnselecionar.Click += new System.EventHandler(this.btnselecionar_Click);
            // 
            // F_EditCadPessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(865, 492);
            this.Controls.Add(this.btnselecionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvcadastropessoal);
            this.Controls.Add(this.btnsalvarcadp);
            this.Controls.Add(this.tbxsenhaed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxcontatoed);
            this.Controls.Add(this.tbxemailed);
            this.Controls.Add(this.tbxcpfed);
            this.Controls.Add(this.tbxnomeed);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_EditCadPessoal";
            this.Text = "F_EditCadPessoal";
            this.Load += new System.EventHandler(this.F_EditCadPessoal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcadastropessoal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxsenhaed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxcontatoed;
        private System.Windows.Forms.TextBox tbxemailed;
        private System.Windows.Forms.TextBox tbxcpfed;
        private System.Windows.Forms.TextBox tbxnomeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsalvarcadp;
        private System.Windows.Forms.DataGridView dgvcadastropessoal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnselecionar;
    }
}