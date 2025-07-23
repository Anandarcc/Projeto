namespace ProjetoCadastro
{
    partial class F_Entrada
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
            this.cbxprodutoentrada = new System.Windows.Forms.ComboBox();
            this.cbxresponsavelentrada = new System.Windows.Forms.ComboBox();
            this.tbxquantidadentrada = new System.Windows.Forms.TextBox();
            this.btnregistro = new System.Windows.Forms.Button();
            this.dtpentrada = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Entrada de Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Responsável:";
            // 
            // cbxprodutoentrada
            // 
            this.cbxprodutoentrada.FormattingEnabled = true;
            this.cbxprodutoentrada.Location = new System.Drawing.Point(178, 98);
            this.cbxprodutoentrada.Name = "cbxprodutoentrada";
            this.cbxprodutoentrada.Size = new System.Drawing.Size(337, 21);
            this.cbxprodutoentrada.TabIndex = 5;
            // 
            // cbxresponsavelentrada
            // 
            this.cbxresponsavelentrada.FormattingEnabled = true;
            this.cbxresponsavelentrada.Location = new System.Drawing.Point(178, 241);
            this.cbxresponsavelentrada.Name = "cbxresponsavelentrada";
            this.cbxresponsavelentrada.Size = new System.Drawing.Size(337, 21);
            this.cbxresponsavelentrada.TabIndex = 6;
            // 
            // tbxquantidadentrada
            // 
            this.tbxquantidadentrada.Location = new System.Drawing.Point(178, 142);
            this.tbxquantidadentrada.Name = "tbxquantidadentrada";
            this.tbxquantidadentrada.Size = new System.Drawing.Size(337, 20);
            this.tbxquantidadentrada.TabIndex = 7;
            // 
            // btnregistro
            // 
            this.btnregistro.Location = new System.Drawing.Point(300, 316);
            this.btnregistro.Name = "btnregistro";
            this.btnregistro.Size = new System.Drawing.Size(75, 23);
            this.btnregistro.TabIndex = 9;
            this.btnregistro.Text = "Registrar";
            this.btnregistro.UseVisualStyleBackColor = true;
            this.btnregistro.Click += new System.EventHandler(this.btnregistro_Click);
            // 
            // dtpentrada
            // 
            this.dtpentrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpentrada.Location = new System.Drawing.Point(178, 194);
            this.dtpentrada.Name = "dtpentrada";
            this.dtpentrada.Size = new System.Drawing.Size(337, 20);
            this.dtpentrada.TabIndex = 10;
            // 
            // F_Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpentrada);
            this.Controls.Add(this.btnregistro);
            this.Controls.Add(this.tbxquantidadentrada);
            this.Controls.Add(this.cbxresponsavelentrada);
            this.Controls.Add(this.cbxprodutoentrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Entrada";
            this.Text = "F_Entrada";
            this.Load += new System.EventHandler(this.F_Entrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxprodutoentrada;
        private System.Windows.Forms.ComboBox cbxresponsavelentrada;
        private System.Windows.Forms.TextBox tbxquantidadentrada;
        private System.Windows.Forms.Button btnregistro;
        private System.Windows.Forms.DateTimePicker dtpentrada;
    }
}