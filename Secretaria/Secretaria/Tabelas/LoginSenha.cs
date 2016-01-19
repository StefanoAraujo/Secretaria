using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class LoginSenha : Tabela<LoginSenha>
    {
        private string tabela = "login_senha";
        private Utils u = new Utils();

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string usuario;

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private string senha;

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        private int funcionarioId;

        public int FuncionarioId
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }
        

        public void Editar(int id, LoginSenha valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Usuario);
            valores.Add(valor.Senha);
            valores.Add(Convert.ToString(valor.FuncionarioId));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(LoginSenha valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Usuario);
            valores.Add(valor.Senha);
            valores.Add(Convert.ToString(valor.FuncionarioId));
            u.Inserir(this.tabela, valores);
        }

        public bool VerificarSeExiste(string coluna, string valor)
        {
            return u.VerificarSeExiste(this.tabela, coluna, valor);
        }

        public bool VerificarSeExiste(List<string> colunas, string valor)
        {
            return u.VerificarSeExiste(this.tabela, colunas, valor);
        }

        public System.Data.DataTable RetornarTabela()
        {
            return u.RetornarTabela(this.tabela);
        }

        public List<string> RetornarTabela(string coluna)
        {
            return u.RetornarTabela(this.tabela, coluna);
        }

        public bool EstaVasio()
        {
            if(RetornarTabela().Rows.Count == 0){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VerificarSeExisteUsuario(string usuario)
        {
            if (u.VerificarSeExiste(tabela, "Usuario", usuario))
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool VerificarSeExisteSenha(string usuario, string senha)
        {
            bool chaveA = false;
            bool chaveB = false;
            DataTable tabela = RetornarTabela();
            DataTableReader dtr = tabela.CreateDataReader();
            while(dtr.Read()){
                if (dtr["Usuario"].ToString() == usuario)
                {
                    chaveA = true;
                    if (dtr["Senha"].ToString() == senha)
                    {
                        chaveB = true;
                    }
                }
            }
            if(chaveA == true && chaveB == true){
                return true;
            }
            else
            {
                return true;
            }
        }

    }
}
