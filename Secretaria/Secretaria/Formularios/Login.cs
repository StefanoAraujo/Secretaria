using Secretaria.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtSenha.MaxLength = 14;
            txtSenha.PasswordChar = '*';
        }

        LoginSenha ls = new LoginSenha();
        private bool u = false;
        private bool s = false;
        private int tentativas = 3;
        public string usuario;
        public string senha;

        private void Verificar()
        {
            if (ls.VerificarSeExisteUsuario(txtUsuario.Text))
            {
                u = true;
                usuario = txtUsuario.Text;
            }
            else
            {
                MessageBox.Show("Usuário não existe", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (ls.VerificarSeExisteSenha(txtUsuario.Text, txtSenha.Text))
            {
                s = true;
                senha = txtSenha.Text;
            }
            else
            {
                MessageBox.Show("Senha Incorreta", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tentativas -= 1;
            lblTentativas.Text = Convert.ToString(tentativas);
            lblTentativa.Visible = true;

            if (tentativas < 0)
            {
                Application.Exit();
            }


            if (u == true && s == true)
            {
                Home h = new Home(this);
                h.Show();
                this.Hide();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Verificar();
        }
    }
}
