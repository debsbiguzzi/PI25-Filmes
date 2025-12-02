using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Filminhos.NET
{
    public partial class FormCadastroFilme : Form
    {

        // Variável para guardar o ID se for edição. Se for -1, é novo cadastro.
        public int codigo = -1;

        ConexaoBD bd = new ConexaoBD();

        public FormCadastroFilme()
        {
            InitializeComponent();
            CarregarGeneros();
        }
        private void CarregarGeneros()
        {
            DataTable dt = bd.GetGenerosParaCombo();
            if (dt != null)
            {
                cbGenero.DataSource = dt;
                cbGenero.DisplayMember = "genero"; // O que o usuário vê
                cbGenero.ValueMember = "codigo";   // O valor real (ID)
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O título é obrigatório!");
                return;
            }

            bool sucesso = false;

            string titulo = txtTitulo.Text;
            int ano = int.Parse(txtAno.Text);
            string duracao = txtDuracao.Text;
            string bilheteria = numBilheteria.Text;
            decimal avaliacao = Convert.ToDecimal(numAvaliacao.Text);
            string classificacao = txtClassif.Text;

            // Pega o ID do gênero selecionado na Combo
            int idGenero = Convert.ToInt32(cbGenero.SelectedValue);

            if (codigo == -1)
            {
                // === MODO CRIAR ===
                sucesso = bd.InserirFilme(titulo, ano, duracao, classificacao, bilheteria, avaliacao, idGenero);
            }
            else
            {
                // === MODO ATUALIZAR ===
                sucesso = bd.AtualizarFilme(codigo, titulo, ano, duracao, classificacao, bilheteria, avaliacao);
            }

            if (sucesso)
            {
                MessageBox.Show("Salvo com sucesso!");
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Erro ao salvar no banco de dados.");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}