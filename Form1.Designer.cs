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
            this.button_ok = new System.Windows.Forms.Button();
            this.BtCancel = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEndereco = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCidade = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.tbEndereco = new System.Windows.Forms.TextBox();
            this.tbBairro = new System.Windows.Forms.TextBox();
            this.tbTelefone = new System.Windows.Forms.TextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.tbSexo = new System.Windows.Forms.TextBox();
            this.lbMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(120, 366);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(195, 52);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "CADASTRAR";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtCancel
            // 
            this.BtCancel.Location = new System.Drawing.Point(414, 366);
            this.BtCancel.Name = "BtCancel";
            this.BtCancel.Size = new System.Drawing.Size(195, 52);
            this.BtCancel.TabIndex = 8;
            this.BtCancel.Text = "CANCELAR";
            this.BtCancel.UseVisualStyleBackColor = true;
            this.BtCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(171, 51);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(261, 20);
            this.tbNome.TabIndex = 0;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(106, 54);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(38, 13);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome:";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(109, 90);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(35, 13);
            this.lbEmail.TabIndex = 4;
            this.lbEmail.Text = "Email:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(171, 87);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(261, 20);
            this.tbEmail.TabIndex = 1;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // lbEndereco
            // 
            this.lbEndereco.AutoSize = true;
            this.lbEndereco.Location = new System.Drawing.Point(106, 132);
            this.lbEndereco.Name = "lbEndereco";
            this.lbEndereco.Size = new System.Drawing.Size(56, 13);
            this.lbEndereco.TabIndex = 6;
            this.lbEndereco.Text = "Endereço:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(106, 218);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(52, 13);
            this.lbTelefone.TabIndex = 7;
            this.lbTelefone.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Location = new System.Drawing.Point(109, 174);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(37, 13);
            this.lbBairro.TabIndex = 9;
            this.lbBairro.Text = "Bairro:";
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(110, 263);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(43, 13);
            this.lbCidade.TabIndex = 10;
            this.lbCidade.Text = "Cidade:";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Location = new System.Drawing.Point(110, 308);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(34, 13);
            this.lbSexo.TabIndex = 11;
            this.lbSexo.Text = "Sexo:";
            // 
            // tbEndereco
            // 
            this.tbEndereco.Location = new System.Drawing.Point(172, 129);
            this.tbEndereco.Name = "tbEndereco";
            this.tbEndereco.Size = new System.Drawing.Size(260, 20);
            this.tbEndereco.TabIndex = 2;
            // 
            // tbBairro
            // 
            this.tbBairro.Location = new System.Drawing.Point(172, 171);
            this.tbBairro.Name = "tbBairro";
            this.tbBairro.Size = new System.Drawing.Size(260, 20);
            this.tbBairro.TabIndex = 3;
            // 
            // tbTelefone
            // 
            this.tbTelefone.Location = new System.Drawing.Point(172, 215);
            this.tbTelefone.Name = "tbTelefone";
            this.tbTelefone.Size = new System.Drawing.Size(260, 20);
            this.tbTelefone.TabIndex = 4;
            // 
            // tbCidade
            // 
            this.tbCidade.Location = new System.Drawing.Point(172, 260);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(260, 20);
            this.tbCidade.TabIndex = 5;
            // 
            // tbSexo
            // 
            this.tbSexo.Location = new System.Drawing.Point(172, 305);
            this.tbSexo.Name = "tbSexo";
            this.tbSexo.Size = new System.Drawing.Size(260, 20);
            this.tbSexo.TabIndex = 6;
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Location = new System.Drawing.Point(332, 428);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(0, 13);
            this.lbMsg.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbMsg);
            this.Controls.Add(this.tbSexo);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.tbTelefone);
            this.Controls.Add(this.tbBairro);
            this.Controls.Add(this.tbEndereco);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbEndereco);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.BtCancel);
            this.Controls.Add(this.button_ok);
            this.Name = "Form1";
            this.Text = "Meu primeiro formulário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button BtCancel;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEndereco;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.TextBox tbEndereco;
        private System.Windows.Forms.TextBox tbBairro;
        private System.Windows.Forms.TextBox tbTelefone;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.TextBox tbSexo;
        private System.Windows.Forms.Label lbMsg;
    }
}

