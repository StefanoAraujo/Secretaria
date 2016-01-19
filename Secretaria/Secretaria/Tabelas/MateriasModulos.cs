using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class MateriasModulos : Tabela<MateriasModulos>
    {
        private string tabela = "materias_modulos";
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
        private int cargaHoraria;

        public int CargaHoraria
        {
            get { return cargaHoraria; }
            set { cargaHoraria = value; }
        }
        private string descricao;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }


        public void Editar(int id, MateriasModulos valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(Convert.ToString(valor.CargaHoraria));
            valores.Add(valor.Descricao);
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(MateriasModulos valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(Convert.ToString(valor.CargaHoraria));
            valores.Add(valor.Descricao);
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
