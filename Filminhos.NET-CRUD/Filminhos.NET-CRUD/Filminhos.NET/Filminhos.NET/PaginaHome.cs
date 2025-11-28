//using Filminhos.NET;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filminhos.NET
{
    public partial class PaginaHome : Form
    {

        public void CarregarPoster(string link)
        {
            if (string.IsNullOrEmpty(link))
            {
                pbxPoster.Image = null;
                return;
            }
            try
            {
                pbxPoster.Load(link);
                pbxPoster.SizeMode = PictureBoxSizeMode.Zoom;
            }
            catch (WebException ex)
            {
                pbxPoster.Image = System.Drawing.Image.FromFile("..\\..\\..\\posterfixo.png");
                return;
            }
        }

        public void iniciarGrid()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = BD.GetAllItems();

            if (dataGridView1.Columns.Contains("link_poster"))
            {
                dataGridView1.Columns["link_poster"].Visible = false;
            }    

            if (dataGridView1.Columns.Contains("codigo"))
                dataGridView1.Columns["codigo"].Visible = true;
        }

        public void iniciarGrid(DataTable dt)
        {
            lblMsg.Text = " ";
            dataGridView1.DataSource = dt;

            if (dt == null || dt.Rows.Count == 0)
            {
                lblMsg.Text = "Nenhum item encontrado";
            }

            if (dataGridView1.Columns.Contains("link_poster"))
            {
                dataGridView1.Columns["link_poster"].Visible = false;
            }

            if (dataGridView1.Columns.Contains("codigo"))
                dataGridView1.Columns["codigo"].Visible = true;
        }

        public void IniciarCbxFiltro()
        {
            cbFiltroGenero.Items.Clear();

            List<string> generos = BD.getGeneros();

            cbFiltroGenero.Items.Add("Genêros");

            foreach (string genero in generos)
            {
                if (!string.IsNullOrEmpty(genero))
                {
                    cbFiltroGenero.Items.Add(genero);
                }
            }

            cbFiltroGenero.SelectedIndex = 0;
        }

        ConexaoBD BD = new ConexaoBD();


        public PaginaHome()
        {
            InitializeComponent();
            iniciarGrid();
            IniciarCbxFiltro();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                string link = row.Cells["link_poster"].Value.ToString();
                CarregarPoster(link);


            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = txbPesquisa.Text;
            int genero = cbFiltroGenero.SelectedIndex;

            //string cmd = "call SP_PESQUISAR_FILMES( '" + pesquisa + "', null)";
            DataTable Resultado = BD.pesquisar(pesquisa, genero);

            iniciarGrid(Resultado);


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            FormCadastroFilme form = new FormCadastroFilme();

            if (dataGridView1.SelectedRows.Count > 0)
            {
               DataGridViewRow linha = dataGridView1.SelectedRows[0];

                form.codigo = Convert.ToInt32(linha.Cells[0].Value);
                string nomeFilme = linha.Cells[1].Value.ToString();

                DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir " + nomeFilme + "?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (BD.ExcluirFilme(form.codigo))
                    {
                        MessageBox.Show("Filme excluído com sucesso!");
                        iniciarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao excluir.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um filme na tabela para excluir.");
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            FormCadastroFilme form = new FormCadastroFilme();
            form.lblTituloTela.Text = "Cadastrar Novo Filme";
            form.codigo = -1; // Garante que é novo

            // Abre a janela como um diálogo (trava a janela de trás)
            form.ShowDialog();

            // Quando a janela fechar, atualiza o grid para mostrar o novo filme
            iniciarGrid();
        }

        // Botão EDITAR FILME
        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se tem algo selecionado
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pega a linha selecionada
                DataGridViewRow linha = dataGridView1.SelectedRows[0];

                FormCadastroFilme form = new FormCadastroFilme();
                form.lblTituloTela.Text = "Editar Filme";

                // === PASSAGEM DE DADOS PARA O FORMULÁRIO ===
                // Recupera o ID (lembre-se de ter adicionado o ID na query do GetAllItems, mesmo oculto)
                form.codigo = Convert.ToInt32(linha.Cells["codigo"].Value);

                // Preenche os campos do formulário com os dados do grid
                form.txtTitulo.Text = linha.Cells["Titulo"].Value.ToString();
                form.txtAno.Text = linha.Cells["Ano de Lancamento"].Value.ToString();
                form.txtDuracao.Text = linha.Cells["Duração"].Value.ToString();
                form.numBilheteria.Text = linha.Cells["Bilheteria"].Value.ToString();
                form.numAvaliacao.Text = linha.Cells["Avaliação"].Value.ToString();

                // Nota: Para o gênero aparecer selecionado, você precisaria trazer o id_genero 
                // no Grid (oculto) e fazer: form.cbGenero.SelectedValue = linha.Cells["id_gen"].Value;

                form.ShowDialog();

                // Atualiza o grid ao voltar
                iniciarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um filme para editar.");
            }
        }
    }
}
