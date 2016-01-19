using Secretaria.Tabelas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria.Formularios
{
    public partial class PrimeiroAcesso : Form
    {
        public PrimeiroAcesso()
        {
            InitializeComponent();
        }

        private LoginSenha ls = new LoginSenha();
        private Administrador a = new Administrador();
        private Funcionario f = new Funcionario();

        private void PrimeiroAcesso_Load(object sender, EventArgs e)
        {
            DataTable tabelaFuncionario = f.RetornarTabela();
            MessageBox.Show("Como é seu primeiro acesso nós recomendamos que você\ncrie o usuario administrador do sistema.\nSão no maximo 2 passos.\nObrigado", "Ola, Seja Bem vindo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (tabelaFuncionario.Rows.Count > 0)
            {
                MessageBox.Show("Parece que ja existe um cadastro de Funcionario.\nPedimos que você informe seu nome", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbl1Passo.Text = "1º Passo - Informe seu nome";
                group1Cadastro.Visible = false;

                DataTableReader dtr = tabelaFuncionario.CreateDataReader();
                while (dtr.Read())
                {
                    comboNomes.Items.Add(dtr["Nome"]);
                }
            }
            else
            {
                group2Nome.Visible = false;
            }
            group3UsuarioSenha.Enabled = false;
            txtSenha.MaxLength = 14;
            txtSenha.PasswordChar = '*';
            
        }

        private int idCadastroFuncionario;
        private void btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja realizar o cadastro de administrador?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    f.Nome = txtNome.Text;
                    f.Departamento = txtDepartamento.Text;
                    f.DataNascimento = dateNascimento.Value.Date;
                    f.Cpf = maskCpf.Text;
                    f.Rg = maskRg.Text;
                    f.Telefone = maskTelefone.Text;
                    f.Celular = MaskCelular.Text;
                    f.Endereco = txtEndereco.Text;
                    f.Bairro = txtBairro.Text;
                    f.Cidade = txtCidade.Text;
                    f.NumeroImovel = int.Parse(txtNImovel.Text);
                    f.Inserir(f);

                    a.Nome = f.Nome;
                    a.FuncionarioId = Convert.ToInt32(f.RetornarTabela().Rows[0]["ID"]);
                    a.Inserir(a);
                    idCadastroFuncionario = Convert.ToInt32(f.RetornarTabela().Rows[0]["ID"]);
                }catch(Exception errorCadastroFuncionario){
                    MessageBox.Show("Erro: ja existe alguem com o mesmo nome ou com o mesmo cadastro.\nMais iformações: " + errorCadastroFuncionario.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                //MessageBox.Show("Aguarde só um estante.\nCadastrando o administrador.", "Aguarde", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                lbl1Passo.ForeColor = Color.Green;
                lbl2Passo.Font = new Font(lbl2Passo.Font, FontStyle.Bold);

                group1Cadastro.Enabled = false;
                group3UsuarioSenha.Enabled = true;

            }
        }

        private void txtNImovel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private int idCadastroFuncionarioNome;
        private void btnNome_Click(object sender, EventArgs e)
        {
            DataTable tabelaAdm = a.RetornarTabela();
            DataTableReader dtrA = tabelaAdm.CreateDataReader();
            while(dtrA.Read()){
                if (!(comboNomes.SelectedItem.ToString().Equals(dtrA["Nome"].ToString())))
                {
                    DataTable tabelaFuncionario = f.RetornarTabela();
                    DataTableReader dtrF = tabelaFuncionario.CreateDataReader();
                    while (dtrF.Read())
                    {
                        if (comboNomes.SelectedItem.ToString().Equals(dtrF["Nome"].ToString()))
                        {
                            try
                            {
                                a.Nome = dtrF["Nome"].ToString();
                                a.FuncionarioId = (int)dtrF["ID"];
                                a.Inserir(a);
                                idCadastroFuncionarioNome = (int)dtrF["ID"];
                            }catch(Exception errorFuncionarioNome){
                                MessageBox.Show("ERRO: Ja existe um usuario cadastrado com as mesmas informações.\nMais informações: " + errorFuncionarioNome.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario ja cadastrado como administrador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable tabelaFuncionario = f.RetornarTabela();
                    DataTableReader dtrF = tabelaFuncionario.CreateDataReader();
                    while (dtrF.Read())
                    {
                        if (comboNomes.SelectedItem.ToString().Equals(dtrF["Nome"].ToString()))
                        {
                            idCadastroFuncionarioNome = (int)dtrF["ID"];
                        }
                    }
                }
            }

            lbl1Passo.ForeColor = Color.Green;
            lbl2Passo.Font = new Font(lbl2Passo.Font, FontStyle.Bold);

            group2Nome.Enabled = false;
            group3UsuarioSenha.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ls.Usuario = txtUsuario.Text;
            ls.Senha = txtSenha.Text;
            ls.FuncionarioId = idCadastroFuncionario > 0 ? idCadastroFuncionario : idCadastroFuncionarioNome;
            try
            {
                ls.Inserir(ls);
                lbl2Passo.ForeColor = Color.Green;
                MessageBox.Show("Usuario adicionado com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }catch(Exception errorUsuario){
                MessageBox.Show("ERRO: Ja existe um usuario com o mesmo nome,\nou o usuario ja esta atribuido a este usuario.\nMais informações: " + errorUsuario.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
