using System.Windows.Forms;

namespace Filminhos.NET
{
    partial class PaginaHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMsg = new Label();
            btnPesquisar = new Button();
            cbFiltroGenero = new ComboBox();
            dataGridView1 = new DataGridView();
            txbPesquisa = new TextBox();
            pbxPoster = new PictureBox();
            label1 = new Label();
            btnNovo = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPoster).BeginInit();
            SuspendLayout();
            // 
            // lblMsg
            // 
            lblMsg.Location = new Point(618, 3);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(292, 21);
            lblMsg.TabIndex = 69;
            lblMsg.Text = "Mensagens";
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(807, 37);
            btnPesquisar.Margin = new Padding(3, 2, 3, 2);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(103, 22);
            btnPesquisar.TabIndex = 68;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // cbFiltroGenero
            // 
            cbFiltroGenero.FormattingEnabled = true;
            cbFiltroGenero.Location = new Point(291, 36);
            cbFiltroGenero.Margin = new Padding(3, 2, 3, 2);
            cbFiltroGenero.Name = "cbFiltroGenero";
            cbFiltroGenero.Size = new Size(104, 23);
            cbFiltroGenero.TabIndex = 50;
            cbFiltroGenero.Text = "Gênero";
            cbFiltroGenero.SelectedIndexChanged += btnPesquisar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = SystemColors.ActiveCaption;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaption;
            dataGridView1.Location = new Point(291, 76);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(722, 395);
            dataGridView1.TabIndex = 48;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txbPesquisa
            // 
            txbPesquisa.AllowDrop = true;
            txbPesquisa.Location = new Point(400, 37);
            txbPesquisa.Margin = new Padding(3, 2, 3, 2);
            txbPesquisa.Name = "txbPesquisa";
            txbPesquisa.PlaceholderText = "Pesquisa";
            txbPesquisa.Size = new Size(398, 23);
            txbPesquisa.TabIndex = 47;
            // 
            // pbxPoster
            // 
            pbxPoster.Location = new Point(10, 76);
            pbxPoster.Margin = new Padding(3, 2, 3, 2);
            pbxPoster.Name = "pbxPoster";
            pbxPoster.Size = new Size(268, 349);
            pbxPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxPoster.TabIndex = 70;
            pbxPoster.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Milker", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 436);
            label1.Name = "label1";
            label1.Size = new Size(240, 33);
            label1.TabIndex = 71;
            label1.Text = "FILMINHOS.NET";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(98, 35);
            btnNovo.Margin = new Padding(3, 2, 3, 2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(82, 22);
            btnNovo.TabIndex = 72;
            btnNovo.Text = "Novo filme";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(10, 35);
            btnEditar.Margin = new Padding(3, 2, 3, 2);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(82, 22);
            btnEditar.TabIndex = 73;
            btnEditar.Text = "Editar filme";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(186, 35);
            btnExcluir.Margin = new Padding(3, 2, 3, 2);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(82, 22);
            btnExcluir.TabIndex = 74;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(938, 37);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 75;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // PaginaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1026, 478);
            Controls.Add(btnFechar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnNovo);
            Controls.Add(label1);
            Controls.Add(pbxPoster);
            Controls.Add(lblMsg);
            Controls.Add(btnPesquisar);
            Controls.Add(cbFiltroGenero);
            Controls.Add(dataGridView1);
            Controls.Add(txbPesquisa);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PaginaHome";
            Text = "FILMINHOS.NET";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPoster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMsg;
        private Button btnPesquisar;
        private ComboBox cbFiltroGenero;
        private ComboBox cbLogin;
        private DataGridView dataGridView1;
        private TextBox txbPesquisa;
        private PictureBox pbxPoster;
        private Label label1;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnFechar;
    }
}
