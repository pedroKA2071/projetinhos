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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.BtnLer = new System.Windows.Forms.Button();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtel = new System.Windows.Forms.RadioButton();
            this.rbemail = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbcontato = new System.Windows.Forms.Label();
            this.LBNOMEE = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbemail = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbtel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(16, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(145, 58);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // BtnLer
            // 
            this.BtnLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLer.Location = new System.Drawing.Point(16, 368);
            this.BtnLer.Name = "BtnLer";
            this.BtnLer.Size = new System.Drawing.Size(145, 58);
            this.BtnLer.TabIndex = 1;
            this.BtnLer.Text = "Ler";
            this.BtnLer.UseVisualStyleBackColor = true;
            this.BtnLer.Click += new System.EventHandler(this.BtnLer_Click);
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txb1.Location = new System.Drawing.Point(12, 88);
            this.txb1.Multiline = true;
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(149, 24);
            this.txb1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(12, 234);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 24);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox2.Location = new System.Drawing.Point(12, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 24);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // rbtel
            // 
            this.rbtel.AutoSize = true;
            this.rbtel.Location = new System.Drawing.Point(186, 88);
            this.rbtel.Name = "rbtel";
            this.rbtel.Size = new System.Drawing.Size(67, 17);
            this.rbtel.TabIndex = 8;
            this.rbtel.TabStop = true;
            this.rbtel.Text = "Telefone";
            this.rbtel.UseVisualStyleBackColor = true;
            // 
            // rbemail
            // 
            this.rbemail.AutoSize = true;
            this.rbemail.Location = new System.Drawing.Point(186, 160);
            this.rbemail.Name = "rbemail";
            this.rbemail.Size = new System.Drawing.Size(50, 17);
            this.rbemail.TabIndex = 9;
            this.rbemail.TabStop = true;
            this.rbemail.Text = "Email";
            this.rbemail.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(186, 257);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // lbcontato
            // 
            this.lbcontato.AutoSize = true;
            this.lbcontato.Location = new System.Drawing.Point(186, 225);
            this.lbcontato.Name = "lbcontato";
            this.lbcontato.Size = new System.Drawing.Size(75, 13);
            this.lbcontato.TabIndex = 12;
            this.lbcontato.Text = "Nome Contato";
            // 
            // LBNOMEE
            // 
            this.LBNOMEE.AutoSize = true;
            this.LBNOMEE.Location = new System.Drawing.Point(167, 302);
            this.LBNOMEE.Name = "LBNOMEE";
            this.LBNOMEE.Size = new System.Drawing.Size(38, 13);
            this.LBNOMEE.TabIndex = 13;
            this.LBNOMEE.Text = "Nome:";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(232, 302);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(75, 13);
            this.lbNome.TabIndex = 14;
            this.lbNome.Text = "Nome Contato";
            this.lbNome.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Emai:";
            // 
            // lbemail
            // 
            this.lbemail.AutoSize = true;
            this.lbemail.Location = new System.Drawing.Point(232, 333);
            this.lbemail.Name = "lbemail";
            this.lbemail.Size = new System.Drawing.Size(75, 13);
            this.lbemail.TabIndex = 16;
            this.lbemail.Text = "Nome Contato";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Tel:";
            // 
            // lbtel
            // 
            this.lbtel.AutoSize = true;
            this.lbtel.Location = new System.Drawing.Point(232, 368);
            this.lbtel.Name = "lbtel";
            this.lbtel.Size = new System.Drawing.Size(75, 13);
            this.lbtel.TabIndex = 18;
            this.lbtel.Text = "Nome Contato";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.lbtel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbemail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.LBNOMEE);
            this.Controls.Add(this.lbcontato);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rbemail);
            this.Controls.Add(this.rbtel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.BtnLer);
            this.Controls.Add(this.btnSalvar);
            this.ForeColor = System.Drawing.Color.Black;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button BtnLer;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtel;
        private System.Windows.Forms.RadioButton rbemail;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbcontato;
        private System.Windows.Forms.Label LBNOMEE;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbemail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbtel;
    }
}

