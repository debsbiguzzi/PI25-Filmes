//using Filminhos.NET;
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
    public partial class PaginaCadastro : Form
    {
        Classes.Sistema Cadastro = new Classes.Sistema();
        public PaginaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome, senha;
            nome = txbNome.Text;
            senha = txbSenha.Text;

            if (string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            else
            {
                bool flag = Cadastro.CadastrarUsuario(nome, senha);
                if (flag)
                {
                    PaginaLogin telaLogin = new PaginaLogin();
                    telaLogin.Show();
                    lblMsg.Text = "Usuário cadastrado com sucesso.";
                }
                else
                {
                    lblMsg.Text = "Erro ao cadastrar usuário.";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            PaginaLogin telaLogin = new PaginaLogin();
            telaLogin.Show();
            this.Close();
        }
    }
}
