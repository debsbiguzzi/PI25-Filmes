using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

namespace Filminhos.NET
{
    public partial class PaginaLogin : Form
    {
        private Classes.Sistema Login = new Classes.Sistema();
        public PaginaLogin()
        {
            InitializeComponent();
            Env.Load();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string senha, nome;
            string adminUser = Env.GetString("ADMIN_USER");
            string adminPass = Env.GetString("ADMIN_PASS");
            nome = txbUsuario.Text;
            senha = txbSenha.Text;
            
            //Admin via .env
            if (nome == adminUser && senha == adminPass)
            {
                PaginaHome telaPrincipal = new PaginaHome(isAdmin: true);
                telaPrincipal.Show();
                this.Hide();
                return;
            }

            //Usuario normal via DB
            if (Login.Consultar(nome, senha))
            {
                PaginaHome telaPrincipal = new PaginaHome(isAdmin: false);
                telaPrincipal.Show();
                this.Hide();
            }
            else
            {
                lblMsg.Text = "Nome de usuário ou senha invalidos";
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            PaginaCadastro telaCadastro = new PaginaCadastro();

            telaCadastro.Show();
            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
