namespace Filminhos.NET
{
    partial class PaginaCadastro
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
            btnVoltar = new Button();
            txbNome = new TextBox();
            label4 = new Label();
            lblMsg = new Label();
            btnCadastrar = new Button();
            label3 = new Label();
            txbSenha = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(37, 301);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(82, 22);
            btnVoltar.TabIndex = 31;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // txbNome
            // 
            txbNome.Location = new Point(434, 116);
            txbNome.Margin = new Padding(3, 2, 3, 2);
            txbNome.Name = "txbNome";
            txbNome.Size = new Size(110, 23);
            txbNome.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 99);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 29;
            label4.Text = "Nome de usuário";
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(434, 207);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(16, 15);
            lblMsg.TabIndex = 28;
            lblMsg.Text = "...";
            lblMsg.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(448, 183);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(82, 22);
            btnCadastrar.TabIndex = 27;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(434, 141);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 26;
            label3.Text = "Senha";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(434, 158);
            txbSenha.Margin = new Padding(3, 2, 3, 2);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(110, 23);
            txbSenha.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 16);
            label1.Name = "label1";
            label1.Size = new Size(325, 26);
            label1.TabIndex = 22;
            label1.Text = "Bem Vindo ao Filminhos.NET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PaginaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 412);
            Controls.Add(btnVoltar);
            Controls.Add(txbNome);
            Controls.Add(label4);
            Controls.Add(lblMsg);
            Controls.Add(btnCadastrar);
            Controls.Add(label3);
            Controls.Add(txbSenha);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaCadastro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVoltar;
        private TextBox txbNome;
        private Label label4;
        private Label lblMsg;
        private Button btnCadastrar;
        private Label label3;
        private TextBox txbUsuario;
        private Label label2;
        private TextBox txbSenha;
        private Label label1;
    }
}