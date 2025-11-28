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

        // Instância da conexão (ajustada para estar em Classes.cs)
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
                cbGenero.ValueMember = "codigo";       // O valor real (ID)
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação simples
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("O título é obrigatório!");
                return;
            }

            bool sucesso = false;

            // Converte valores (tratando erros de conversão com try/catch ou TryParse se preferir)
            string titulo = txtTitulo.Text;
            int ano = int.Parse(txtAno.Text); // Ou int.Parse(txtAno.Text)
            string duracao = txtDuracao.Text;
            string bilheteria = numBilheteria.Text;
            decimal avaliacao = Convert.ToDecimal(numAvaliacao.Text);
            string classificacao = "Livre"; // Exemplo, crie um ComboBox para isso também se quiser

            // Pega o ID do gênero selecionado na Combo
            int idGenero = Convert.ToInt32(cbGenero.SelectedValue);

            if (codigo == -1)
            {
                // === MODO CRIAR ===
                // Nota: Certifique-se que criou o método InserirFilme na classe ConexaoBD como mandei antes
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
                this.Close(); // Fecha a janela
            }
            else
            {
                MessageBox.Show("Erro ao salvar no banco de dados.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}