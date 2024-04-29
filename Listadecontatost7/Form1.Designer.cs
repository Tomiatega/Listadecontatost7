namespace Listadecontatost7
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
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.listBoxcontato = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttoncontato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(105, 91);
            this.textBoxSobrenome.Multiline = true;
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(214, 56);
            this.textBoxSobrenome.TabIndex = 0;
            this.textBoxSobrenome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(105, 12);
            this.textBoxNome.Multiline = true;
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(214, 52);
            this.textBoxNome.TabIndex = 1;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(105, 182);
            this.textBoxTelefone.Multiline = true;
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(214, 53);
            this.textBoxTelefone.TabIndex = 2;
            // 
            // listBoxcontato
            // 
            this.listBoxcontato.FormattingEnabled = true;
            this.listBoxcontato.Location = new System.Drawing.Point(571, 24);
            this.listBoxcontato.Name = "listBoxcontato";
            this.listBoxcontato.Size = new System.Drawing.Size(217, 342);
            this.listBoxcontato.TabIndex = 3;
            this.listBoxcontato.SelectedIndexChanged += new System.EventHandler(this.listBoxcontato_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sobrenome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone";
            // 
            // buttoncontato
            // 
            this.buttoncontato.Location = new System.Drawing.Point(105, 277);
            this.buttoncontato.Name = "buttoncontato";
            this.buttoncontato.Size = new System.Drawing.Size(214, 108);
            this.buttoncontato.TabIndex = 7;
            this.buttoncontato.Text = "incluircontato";
            this.buttoncontato.UseVisualStyleBackColor = true;
            this.buttoncontato.Click += new System.EventHandler(this.buttoncontato_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncontato);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxcontato);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxSobrenome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.ListBox listBoxcontato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoncontato;
    }
}

