namespace Filminhos.NET
{
    partial class FormCadastroFilme
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
        public void InitializeComponent()
        {
            numBilheteria = new TextBox();
            txtDuracao = new TextBox();
            txtAno = new TextBox();
            numAvaliacao = new TextBox();
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbGenero = new ComboBox();
            label6 = new Label();
            btnSalvar = new Button();
            lblTituloTela = new Label();
            SuspendLayout();
            // 
            // numBilheteria
            // 
            numBilheteria.Location = new Point(318, 178);
            numBilheteria.Margin = new Padding(3, 2, 3, 2);
            numBilheteria.Name = "numBilheteria";
            numBilheteria.Size = new Size(110, 23);
            numBilheteria.TabIndex = 0;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(318, 104);
            txtDuracao.Margin = new Padding(3, 2, 3, 2);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(110, 23);
            txtDuracao.TabIndex = 1;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(318, 140);
            txtAno.Margin = new Padding(3, 2, 3, 2);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(110, 23);
            txtAno.TabIndex = 2;
            // 
            // numAvaliacao
            // 
            numAvaliacao.Location = new Point(318, 212);
            numAvaliacao.Margin = new Padding(3, 2, 3, 2);
            numAvaliacao.Name = "numAvaliacao";
            numAvaliacao.Size = new Size(110, 23);
            numAvaliacao.TabIndex = 3;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(318, 70);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(110, 23);
            txtTitulo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(269, 72);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(234, 217);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Alavaliação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(260, 253);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Gênero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(253, 106);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Duração:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 181);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "Bilheteria:";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(318, 250);
            cbGenero.Margin = new Padding(3, 2, 3, 2);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(133, 23);
            cbGenero.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(188, 142);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 11;
            label6.Text = "Ano de lançamento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(607, 307);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTituloTela
            // 
            lblTituloTela.Location = new Point(260, 14);
            lblTituloTela.Name = "lblTituloTela";
            lblTituloTela.Size = new Size(243, 38);
            lblTituloTela.TabIndex = 13;
            // 
            // FormCadastroFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(lblTituloTela);
            Controls.Add(btnSalvar);
            Controls.Add(label6);
            Controls.Add(cbGenero);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Controls.Add(numAvaliacao);
            Controls.Add(txtAno);
            Controls.Add(txtDuracao);
            Controls.Add(numBilheteria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroFilme";
            Text = "FormCadastroFilme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox numBilheteria;
        public TextBox txtDuracao;
        public TextBox txtAno;
        public TextBox numAvaliacao;
        public TextBox txtTitulo;
        public Label label1;
        public Label label2;
        public Label label3;
        public Label label4;
        public Label label5;
        public ComboBox cbGenero;
        public Label label6;
        public Button btnSalvar;
        public Label lblTituloTela;
    }
}