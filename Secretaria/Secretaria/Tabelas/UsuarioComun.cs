using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class UsuarioComun : Tabela<UsuarioComun>
    {
        private string tabela = "usuarios_comun";
        private Utils u = new Utils();

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private int funcionarioId;

        public int FuncionarioId
        {
            get { return funcionarioId; }
            set { funcionarioId = value; }
        }


        public void Editar(int id, UsuarioComun valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(Convert.ToString(valor.FuncionarioId));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(UsuarioComun valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
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
    }
}
