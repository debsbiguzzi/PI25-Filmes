namespace Filminhos.NET
{
    partial class PaginaLogin
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
            btnCadastrar = new Button();
            btnEntrar = new Button();
            label3 = new Label();
            txbUsuario = new TextBox();
            label2 = new Label();
            txbSenha = new TextBox();
            label1 = new Label();
            btnFechar = new Button();
            lblMsg = new Label();
            SuspendLayout();
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(453, 295);
            btnCadastrar.Margin = new Padding(3, 2, 3, 2);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(93, 22);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Me Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(232, 201);
            btnEntrar.Margin = new Padding(3, 2, 3, 2);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(82, 22);
            btnEntrar.TabIndex = 3;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(218, 159);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 26;
            label3.Text = "Senha";
            // 
            // txbUsuario
            // 
            txbUsuario.Location = new Point(218, 132);
            txbUsuario.Margin = new Padding(3, 2, 3, 2);
            txbUsuario.Name = "txbUsuario";
            txbUsuario.Size = new Size(110, 23);
            txbUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 115);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 24;
            label2.Text = "Usuário / Email";
            // 
            // txbSenha
            // 
            txbSenha.Location = new Point(218, 176);
            txbSenha.Margin = new Padding(3, 2, 3, 2);
            txbSenha.Name = "txbSenha";
            txbSenha.Size = new Size(110, 23);
            txbSenha.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(118, 66);
            label1.Name = "label1";
            label1.Size = new Size(325, 26);
            label1.TabIndex = 22;
            label1.Text = "Bem Vindo ao Filminhos.NET";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(12, 295);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 27;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Location = new Point(197, 263);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(0, 15);
            lblMsg.TabIndex = 28;
            // 
            // PaginaLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 328);
            Controls.Add(lblMsg);
            Controls.Add(btnFechar);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(label3);
            Controls.Add(txbUsuario);
            Controls.Add(label2);
            Controls.Add(txbSenha);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaLogin";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCadastrar;
        private Label lblMsg;
        private Button btnEntrar;
        private Label label3;
        private TextBox txbUsuario;
        private Label label2;
        private TextBox txbSenha;
        private Label label1;
        private Button btnFechar;
    }
}