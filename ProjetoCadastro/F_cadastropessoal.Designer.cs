﻿namespace ProjetoCadastro
{
    partial class F_cadastropessoal
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxnome = new System.Windows.Forms.TextBox();
            this.tbxcpf = new System.Windows.Forms.TextBox();
            this.tbxemail = new System.Windows.Forms.TextBox();
            this.tbxcontato = new System.Windows.Forms.TextBox();
            this.btncadastrarpessoa = new System.Windows.Forms.Button();
            this.cbxcargo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxsenha = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo Ocupado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(129, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contato:";
            // 
            // tbxnome
            // 
            this.tbxnome.Location = new System.Drawing.Point(239, 34);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(293, 20);
            this.tbxnome.TabIndex = 5;
            // 
            // tbxcpf
            // 
            this.tbxcpf.Location = new System.Drawing.Point(239, 76);
            this.tbxcpf.Name = "tbxcpf";
            this.tbxcpf.Size = new System.Drawing.Size(293, 20);
            this.tbxcpf.TabIndex = 6;
            // 
            // tbxemail
            // 
            this.tbxemail.Location = new System.Drawing.Point(239, 118);
            this.tbxemail.Name = "tbxemail";
            this.tbxemail.Size = new System.Drawing.Size(293, 20);
            this.tbxemail.TabIndex = 7;
            // 
            // tbxcontato
            // 
            this.tbxcontato.Location = new System.Drawing.Point(239, 247);
            this.tbxcontato.Name = "tbxcontato";
            this.tbxcontato.Size = new System.Drawing.Size(293, 20);
            this.tbxcontato.TabIndex = 9;
            // 
            // btncadastrarpessoa
            // 
            this.btncadastrarpessoa.Location = new System.Drawing.Point(348, 318);
            this.btncadastrarpessoa.Name = "btncadastrarpessoa";
            this.btncadastrarpessoa.Size = new System.Drawing.Size(75, 23);
            this.btncadastrarpessoa.TabIndex = 11;
            this.btncadastrarpessoa.Text = "Cadastrar";
            this.btncadastrarpessoa.UseVisualStyleBackColor = true;
            this.btncadastrarpessoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxcargo
            // 
            this.cbxcargo.FormattingEnabled = true;
            this.cbxcargo.Items.AddRange(new object[] {
            "Estoquista",
            "Almoxarife"});
            this.cbxcargo.Location = new System.Drawing.Point(239, 204);
            this.cbxcargo.Name = "cbxcargo";
            this.cbxcargo.Size = new System.Drawing.Size(293, 21);
            this.cbxcargo.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Senha";
            // 
            // tbxsenha
            // 
            this.tbxsenha.Location = new System.Drawing.Point(239, 161);
            this.tbxsenha.Name = "tbxsenha";
            this.tbxsenha.Size = new System.Drawing.Size(293, 20);
            this.tbxsenha.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(345, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Editar cadastro";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // F_cadastropessoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.tbxsenha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncadastrarpessoa);
            this.Controls.Add(this.cbxcargo);
            this.Controls.Add(this.tbxcontato);
            this.Controls.Add(this.tbxemail);
            this.Controls.Add(this.tbxcpf);
            this.Controls.Add(this.tbxnome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_cadastropessoal";
            this.Text = "F_cadastropessoal";
            this.Load += new System.EventHandler(this.F_cadastropessoal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxnome;
        private System.Windows.Forms.TextBox tbxcpf;
        private System.Windows.Forms.TextBox tbxemail;
        private System.Windows.Forms.TextBox tbxcontato;
        private System.Windows.Forms.Button btncadastrarpessoa;
        private System.Windows.Forms.ComboBox cbxcargo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxsenha;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}