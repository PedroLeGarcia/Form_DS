namespace FormClienteDES
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.telres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.logradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.incluir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.limpartudo = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.fotos = new System.Windows.Forms.PictureBox();
            this.carregarfoto = new System.Windows.Forms.Button();
            this.limparfoto = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nome);
            this.groupBox1.Controls.Add(this.tel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.telres);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cpf);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rg);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tel
            // 
            this.tel.Location = new System.Drawing.Point(257, 104);
            this.tel.Name = "tel";
            this.tel.Size = new System.Drawing.Size(155, 20);
            this.tel.TabIndex = 11;
            this.tel.Tag = "codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tel:";
            // 
            // telres
            // 
            this.telres.Location = new System.Drawing.Point(96, 104);
            this.telres.Name = "telres";
            this.telres.Size = new System.Drawing.Size(119, 20);
            this.telres.TabIndex = 9;
            this.telres.Tag = "codigo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tel. Residencial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(257, 78);
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(155, 20);
            this.cpf.TabIndex = 7;
            this.cpf.Tag = "codigo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "CPF:";
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(60, 78);
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(155, 20);
            this.rg.TabIndex = 5;
            this.rg.Tag = "codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RG:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "codigo";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton5);
            this.groupBox4.Controls.Add(this.radioButton6);
            this.groupBox4.Location = new System.Drawing.Point(13, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(421, 44);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sexo";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(96, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(67, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Feminino";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(17, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(73, 17);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Masculino";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cidade);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.bairro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBox9);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.logradouro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cep);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 84);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(546, 45);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(215, 20);
            this.cidade.TabIndex = 11;
            this.cidade.Tag = "codigo";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(497, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Cidade:";
            // 
            // bairro
            // 
            this.bairro.Location = new System.Drawing.Point(191, 45);
            this.bairro.Name = "bairro";
            this.bairro.Size = new System.Drawing.Size(297, 20);
            this.bairro.TabIndex = 9;
            this.bairro.Tag = "codigo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bairro:";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(60, 45);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(77, 20);
            this.textBox9.TabIndex = 7;
            this.textBox9.Tag = "codigo";
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Número:";
            // 
            // logradouro
            // 
            this.logradouro.Location = new System.Drawing.Point(298, 19);
            this.logradouro.Name = "logradouro";
            this.logradouro.Size = new System.Drawing.Size(463, 20);
            this.logradouro.TabIndex = 5;
            this.logradouro.Tag = "codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Logradouro:";
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(60, 19);
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(155, 20);
            this.cep.TabIndex = 3;
            this.cep.Tag = "codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "CEP:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.textBox13);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox12);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(13, 297);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 88);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Extras";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(658, 18);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Facebook";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(128, 45);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(524, 20);
            this.textBox13.TabIndex = 7;
            this.textBox13.Tag = "codigo";
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Twitter:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(60, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(592, 20);
            this.textBox12.TabIndex = 5;
            this.textBox12.Tag = "codigo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "E-mail:";
            // 
            // incluir
            // 
            this.incluir.Location = new System.Drawing.Point(13, 405);
            this.incluir.Name = "incluir";
            this.incluir.Size = new System.Drawing.Size(122, 33);
            this.incluir.TabIndex = 16;
            this.incluir.Text = "Incluir";
            this.incluir.UseVisualStyleBackColor = true;
            this.incluir.Click += new System.EventHandler(this.incluir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(270, 405);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(122, 33);
            this.consultar.TabIndex = 18;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            this.consultar.Click += new System.EventHandler(this.consultar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(398, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 33);
            this.button4.TabIndex = 19;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // limpartudo
            // 
            this.limpartudo.Location = new System.Drawing.Point(526, 405);
            this.limpartudo.Name = "limpartudo";
            this.limpartudo.Size = new System.Drawing.Size(122, 33);
            this.limpartudo.TabIndex = 20;
            this.limpartudo.Text = "Limpar";
            this.limpartudo.UseVisualStyleBackColor = true;
            this.limpartudo.Click += new System.EventHandler(this.limpartudo_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(654, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 33);
            this.button6.TabIndex = 21;
            this.button6.Text = "Sair";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // fotos
            // 
            this.fotos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.fotos.Location = new System.Drawing.Point(467, 16);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(296, 134);
            this.fotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotos.TabIndex = 22;
            this.fotos.TabStop = false;
            this.fotos.Click += new System.EventHandler(this.fotos_Click);
            // 
            // carregarfoto
            // 
            this.carregarfoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.carregarfoto.Location = new System.Drawing.Point(444, 156);
            this.carregarfoto.Name = "carregarfoto";
            this.carregarfoto.Size = new System.Drawing.Size(169, 44);
            this.carregarfoto.TabIndex = 23;
            this.carregarfoto.Text = "Carregar imagem";
            this.carregarfoto.UseVisualStyleBackColor = false;
            this.carregarfoto.Click += new System.EventHandler(this.carregarfoto_Click);
            // 
            // limparfoto
            // 
            this.limparfoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.limparfoto.Location = new System.Drawing.Point(619, 157);
            this.limparfoto.Name = "limparfoto";
            this.limparfoto.Size = new System.Drawing.Size(169, 44);
            this.limparfoto.TabIndex = 24;
            this.limparfoto.Text = "Limpar Imagem";
            this.limparfoto.UseVisualStyleBackColor = false;
            this.limparfoto.Click += new System.EventHandler(this.limparfoto_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(60, 52);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(352, 20);
            this.nome.TabIndex = 25;
            this.nome.Tag = "codigo";
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(658, 47);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(56, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Tuitter";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.limparfoto);
            this.Controls.Add(this.carregarfoto);
            this.Controls.Add(this.fotos);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.limpartudo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.incluir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox rg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox telres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox logradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button incluir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button limpartudo;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox fotos;
        private System.Windows.Forms.Button carregarfoto;
        private System.Windows.Forms.Button limparfoto;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

