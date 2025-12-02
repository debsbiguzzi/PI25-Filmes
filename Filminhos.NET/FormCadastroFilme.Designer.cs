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
            txtClassif = new TextBox();
            lblClassif = new Label();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // numBilheteria
            // 
            numBilheteria.Location = new Point(85, 182);
            numBilheteria.Margin = new Padding(3, 2, 3, 2);
            numBilheteria.Name = "numBilheteria";
            numBilheteria.Size = new Size(133, 23);
            numBilheteria.TabIndex = 4;
            // 
            // txtDuracao
            // 
            txtDuracao.Location = new Point(85, 131);
            txtDuracao.Margin = new Padding(3, 2, 3, 2);
            txtDuracao.Name = "txtDuracao";
            txtDuracao.Size = new Size(133, 23);
            txtDuracao.TabIndex = 2;
            // 
            // txtAno
            // 
            txtAno.Location = new Point(437, 76);
            txtAno.Margin = new Padding(3, 2, 3, 2);
            txtAno.Name = "txtAno";
            txtAno.Size = new Size(133, 23);
            txtAno.TabIndex = 1;
            // 
            // numAvaliacao
            // 
            numAvaliacao.Location = new Point(437, 182);
            numAvaliacao.Margin = new Padding(3, 2, 3, 2);
            numAvaliacao.Name = "numAvaliacao";
            numAvaliacao.Size = new Size(133, 23);
            numAvaliacao.TabIndex = 5;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(85, 79);
            txtTitulo.Margin = new Padding(3, 2, 3, 2);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(133, 23);
            txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.Location = new Point(39, 82);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 5;
            label1.Text = "Título:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 182);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Avaliação:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 250);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 7;
            label3.Text = "Gênero:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 131);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 8;
            label4.Text = "Duração:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 185);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 9;
            label5.Text = "Bilheteria:";
            // 
            // cbGenero
            // 
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(251, 247);
            cbGenero.Margin = new Padding(3, 2, 3, 2);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(133, 23);
            cbGenero.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 79);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 11;
            label6.Text = "Ano de lançamento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(488, 305);
            btnSalvar.Margin = new Padding(3, 2, 3, 2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(82, 22);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblTituloTela
            // 
            lblTituloTela.Location = new Point(175, 9);
            lblTituloTela.Name = "lblTituloTela";
            lblTituloTela.Size = new Size(243, 38);
            lblTituloTela.TabIndex = 13;
            // 
            // txtClassif
            // 
            txtClassif.Location = new Point(437, 128);
            txtClassif.Margin = new Padding(3, 2, 3, 2);
            txtClassif.Name = "txtClassif";
            txtClassif.Size = new Size(133, 23);
            txtClassif.TabIndex = 3;
            // 
            // lblClassif
            // 
            lblClassif.AutoSize = true;
            lblClassif.Font = new Font("Segoe UI", 9F);
            lblClassif.Location = new Point(353, 128);
            lblClassif.Name = "lblClassif";
            lblClassif.Size = new Size(78, 15);
            lblClassif.TabIndex = 15;
            lblClassif.Text = "Classificação:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 303);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // FormCadastroFilme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 338);
            Controls.Add(btnCancelar);
            Controls.Add(lblClassif);
            Controls.Add(txtClassif);
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
            Text = "CADASTRO";
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
        public TextBox txtClassif;
        public Label lblClassif;
        private Button btnCancelar;
    }
}