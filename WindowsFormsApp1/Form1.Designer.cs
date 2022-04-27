namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Divisao = new System.Windows.Forms.Button();
            this.Multiplicacao = new System.Windows.Forms.Button();
            this.Raiz = new System.Windows.Forms.Button();
            this.Potencializacao = new System.Windows.Forms.Button();
            this.Soma = new System.Windows.Forms.Button();
            this.Subtracao = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Divisao
            // 
            this.Divisao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Divisao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Divisao.BackgroundImage")));
            this.Divisao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Divisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divisao.FlatAppearance.BorderSize = 0;
            this.Divisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Divisao.ForeColor = System.Drawing.Color.Transparent;
            this.Divisao.Location = new System.Drawing.Point(12, 220);
            this.Divisao.Name = "Divisao";
            this.Divisao.Size = new System.Drawing.Size(93, 73);
            this.Divisao.TabIndex = 2;
            this.Divisao.UseVisualStyleBackColor = false;
            this.Divisao.Click += new System.EventHandler(this.Divisao_Click);
            // 
            // Multiplicacao
            // 
            this.Multiplicacao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Multiplicacao.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._3740;
            this.Multiplicacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Multiplicacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multiplicacao.FlatAppearance.BorderSize = 0;
            this.Multiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacao.ForeColor = System.Drawing.Color.Transparent;
            this.Multiplicacao.Location = new System.Drawing.Point(262, 140);
            this.Multiplicacao.Name = "Multiplicacao";
            this.Multiplicacao.Size = new System.Drawing.Size(93, 73);
            this.Multiplicacao.TabIndex = 3;
            this.Multiplicacao.UseVisualStyleBackColor = false;
            this.Multiplicacao.Click += new System.EventHandler(this.Multiplicacao_Click);
            // 
            // Raiz
            // 
            this.Raiz.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Raiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Raiz.BackgroundImage")));
            this.Raiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raiz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Raiz.FlatAppearance.BorderSize = 0;
            this.Raiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Raiz.ForeColor = System.Drawing.Color.Transparent;
            this.Raiz.Location = new System.Drawing.Point(134, 220);
            this.Raiz.Name = "Raiz";
            this.Raiz.Size = new System.Drawing.Size(93, 73);
            this.Raiz.TabIndex = 4;
            this.Raiz.UseVisualStyleBackColor = false;
            this.Raiz.Click += new System.EventHandler(this.Raiz_Click);
            // 
            // Potencializacao
            // 
            this.Potencializacao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Potencializacao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Potencializacao.BackgroundImage")));
            this.Potencializacao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Potencializacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Potencializacao.FlatAppearance.BorderSize = 0;
            this.Potencializacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Potencializacao.ForeColor = System.Drawing.Color.Transparent;
            this.Potencializacao.Location = new System.Drawing.Point(262, 220);
            this.Potencializacao.Name = "Potencializacao";
            this.Potencializacao.Size = new System.Drawing.Size(93, 73);
            this.Potencializacao.TabIndex = 5;
            this.Potencializacao.UseVisualStyleBackColor = false;
            this.Potencializacao.Click += new System.EventHandler(this.Potencializacao_Click);
            // 
            // Soma
            // 
            this.Soma.AccessibleDescription = "Acessar Soma";
            this.Soma.AccessibleName = "Soma";
            this.Soma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Soma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Soma.BackgroundImage")));
            this.Soma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Soma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Soma.FlatAppearance.BorderSize = 0;
            this.Soma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soma.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soma.ForeColor = System.Drawing.Color.Transparent;
            this.Soma.Location = new System.Drawing.Point(12, 140);
            this.Soma.Name = "Soma";
            this.Soma.Size = new System.Drawing.Size(93, 73);
            this.Soma.TabIndex = 6;
            this.Soma.UseVisualStyleBackColor = false;
            this.Soma.Click += new System.EventHandler(this.Soma_Click);
            // 
            // Subtracao
            // 
            this.Subtracao.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Subtracao.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Subtracao.BackgroundImage")));
            this.Subtracao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Subtracao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Subtracao.FlatAppearance.BorderSize = 0;
            this.Subtracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtracao.ForeColor = System.Drawing.Color.Transparent;
            this.Subtracao.Location = new System.Drawing.Point(134, 141);
            this.Subtracao.Name = "Subtracao";
            this.Subtracao.Size = new System.Drawing.Size(93, 73);
            this.Subtracao.TabIndex = 7;
            this.Subtracao.UseVisualStyleBackColor = false;
            this.Subtracao.Click += new System.EventHandler(this.Subtracao_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(205, 81);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Primeiro Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Segundo Numero";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 55);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(367, 464);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Subtracao);
            this.Controls.Add(this.Soma);
            this.Controls.Add(this.Potencializacao);
            this.Controls.Add(this.Raiz);
            this.Controls.Add(this.Multiplicacao);
            this.Controls.Add(this.Divisao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Divisao;
        private System.Windows.Forms.Button Multiplicacao;
        private System.Windows.Forms.Button Raiz;
        private System.Windows.Forms.Button Potencializacao;
        private System.Windows.Forms.Button Soma;
        private System.Windows.Forms.Button Subtracao;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

