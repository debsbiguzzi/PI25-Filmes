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
        // Define se o usuario é admin ou nao
        private readonly bool isAdmin;

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
            catch (WebException)
            {
                pbxPoster.Image = System.Drawing.Image.FromFile("..\\..\\..\\posterfixo.png");
                return;
            }
        }

        //Inicia a tabela com todos os filmes (view)
        public void iniciarGrid()
        {
            //Auto generate columns true para criar colunas automaticamente
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = BD.GetAllItems();

            //Nao mostra a coluna link_poster
            if (dataGridView1.Columns.Contains("link_poster"))
            {
                dataGridView1.Columns["link_poster"].Visible = false;
            }

            //Mostra a coluna codigo (id do filme)
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

        //Inicia o combobox de filtro de genero
        //Pega do banco de dados a tabela de generos e adiciona no combobox
        public void IniciarCbxFiltro()
        {
            cbFiltroGenero.Items.Clear();

            List<string> generos = BD.getGeneros();

            cbFiltroGenero.Items.Add("Generos");

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

        //Construtor da pagina home (aceita parametro isAdmin para definir se o usuario é admin ou nao)
        public PaginaHome(bool isAdmin = false)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            // Configura UI baseado no tipo de usuário
            ConfigureAdminControls();

            iniciarGrid();
            IniciarCbxFiltro();
        }

        private void ConfigureAdminControls()
        {
            //Abilitar botões para apenas adimin ter acesso a eles
            btnExcluir.Enabled = isAdmin;
            btnNovo.Enabled = isAdmin;
            btnEditar.Enabled = isAdmin;
        }

        //Ao clicar em uma celula da tabela, carrega o poster do filme
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

            DataTable Resultado = BD.pesquisar(pesquisa, genero);

            iniciarGrid(Resultado);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um filme na tabela para excluir.");
                return;
            }

            var linha = dataGridView1.SelectedRows[0];

            //Caso a pessoa selecione uma linha em branco
            if (linha.IsNewRow || linha.DataBoundItem == null)
            {
                MessageBox.Show("Selecione uma linha válida para excluir.");
                return;
            }

            object codigoObj = null;

            // Tenta pegar o código pela coluna "codigo", se não existir, tenta pela primeira coluna
            if (dataGridView1.Columns.Contains("codigo"))
                codigoObj = linha.Cells["codigo"].Value;
            else if (linha.Cells.Count > 0)
                codigoObj = linha.Cells[0].Value;

            if (codigoObj == null || !int.TryParse(codigoObj.ToString(), out int codigo))
            {
                MessageBox.Show("Não foi possível determinar o código do filme.");
                return;
            }

            // Pega o título do filme para a mensagem de confirmação
            object tituloObj = dataGridView1.Columns.Contains("Titulo") ? linha.Cells["Titulo"].Value : (linha.Cells.Count > 1 ? linha.Cells[1].Value : null);

            string nomeFilme = tituloObj?.ToString() ?? "(sem título)";

            var confirm = MessageBox.Show($"Tem certeza que deseja excluir {nomeFilme}?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            if (BD.ExcluirFilme(codigo))
            {
                MessageBox.Show("Filme excluído com sucesso!");
                iniciarGrid();
            }
            else
            {
                MessageBox.Show("Erro ao excluir.");
            }
        }


        private void btnNovo_Click(object sender, EventArgs e)
        {

            FormCadastroFilme form = new FormCadastroFilme();
            form.lblTituloTela.Text = "Cadastrar Novo Filme";
            form.codigo = -1; // Garante que é novo

            form.ShowDialog();

            // Quando a janela fechar, atualiza o grid para mostrar o novo filme
            iniciarGrid();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica se tem algo selecionado
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Pega a linha selecionada
                DataGridViewRow linha = dataGridView1.SelectedRows[0];

                FormCadastroFilme form = new FormCadastroFilme();
                form.lblTituloTela.Text = "Editar Filme";

                form.codigo = Convert.ToInt32(linha.Cells["codigo"].Value);

                // Preenche os campos do formulario com os dados do grid
                form.txtTitulo.Text = linha.Cells["Titulo"].Value.ToString();
                form.txtAno.Text = linha.Cells["Ano de Lancamento"].Value.ToString();
                form.txtDuracao.Text = linha.Cells["Duração"].Value.ToString();
                form.numBilheteria.Text = linha.Cells["Bilheteria"].Value.ToString();
                form.numAvaliacao.Text = linha.Cells["Avaliação"].Value.ToString();

                form.ShowDialog();

                // Atualiza o grid ao voltar
                iniciarGrid();
            }
            else
            {
                MessageBox.Show("Selecione um filme para editar.");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
