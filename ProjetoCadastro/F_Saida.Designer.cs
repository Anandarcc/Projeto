namespace ProjetoCadastro
{
    partial class F_Saida
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
            this.components = new System.ComponentModel.Container();
<<<<<<< HEAD
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "F_Saida";
        }

        #endregion
=======
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.dtpdatasaida = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxquantsaida = new System.Windows.Forms.TextBox();
            this.cbxprodutosaida = new System.Windows.Forms.ComboBox();
            this.cbxresponsavelsaida = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnregistrarsaida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data";
            // 
            // dtpdatasaida
            // 
            this.dtpdatasaida.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdatasaida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdatasaida.Location = new System.Drawing.Point(263, 208);
            this.dtpdatasaida.Name = "dtpdatasaida";
            this.dtpdatasaida.Size = new System.Drawing.Size(246, 20);
            this.dtpdatasaida.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Responsável";
            // 
            // tbxquantsaida
            // 
            this.tbxquantsaida.Location = new System.Drawing.Point(263, 175);
            this.tbxquantsaida.Name = "tbxquantsaida";
            this.tbxquantsaida.Size = new System.Drawing.Size(246, 20);
            this.tbxquantsaida.TabIndex = 6;
            // 
            // cbxprodutosaida
            // 
            this.cbxprodutosaida.FormattingEnabled = true;
            this.cbxprodutosaida.Location = new System.Drawing.Point(263, 142);
            this.cbxprodutosaida.Name = "cbxprodutosaida";
            this.cbxprodutosaida.Size = new System.Drawing.Size(246, 21);
            this.cbxprodutosaida.TabIndex = 7;
            // 
            // cbxresponsavelsaida
            // 
            this.cbxresponsavelsaida.FormattingEnabled = true;
            this.cbxresponsavelsaida.Location = new System.Drawing.Point(263, 246);
            this.cbxresponsavelsaida.Name = "cbxresponsavelsaida";
            this.cbxresponsavelsaida.Size = new System.Drawing.Size(246, 21);
            this.cbxresponsavelsaida.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Saída de produtos";
            // 
            // btnregistrarsaida
            // 
            this.btnregistrarsaida.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarsaida.Location = new System.Drawing.Point(324, 294);
            this.btnregistrarsaida.Name = "btnregistrarsaida";
            this.btnregistrarsaida.Size = new System.Drawing.Size(116, 32);
            this.btnregistrarsaida.TabIndex = 10;
            this.btnregistrarsaida.Text = "Registrar Saída";
            this.btnregistrarsaida.UseVisualStyleBackColor = true;
            this.btnregistrarsaida.Click += new System.EventHandler(this.btnregistrarsaida_Click);
            // 
            // F_Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregistrarsaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxresponsavelsaida);
            this.Controls.Add(this.cbxprodutosaida);
            this.Controls.Add(this.tbxquantsaida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpdatasaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_Saida";
            this.Text = "F_Saida";
            this.Load += new System.EventHandler(this.F_Saida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpdatasaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxquantsaida;
        private System.Windows.Forms.ComboBox cbxprodutosaida;
        private System.Windows.Forms.ComboBox cbxresponsavelsaida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnregistrarsaida;
>>>>>>> 4d890ccc8914a8c5051f375863c8f5394e46d3c6
    }
}