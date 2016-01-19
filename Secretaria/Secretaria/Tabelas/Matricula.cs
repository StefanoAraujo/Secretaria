using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class Matricula : Tabela<Matricula>
    {
        private string tabela = "matricula";
        private Utils u = new Utils();

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private int criadorId;

        public int CriadorId
        {
            get { return criadorId; }
            set { criadorId = value; }
        }
        private int materiasModulosId;

        public int MateriasModulosId
        {
            get { return materiasModulosId; }
            set { materiasModulosId = value; }
        }


        public void Editar(int id, Matricula valor)
        {
            List<string> valores = new List<string>();
            valores.Add(Convert.ToString(valor.MateriasModulosId));
            valores.Add(Convert.ToString(valor.CriadorId));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(Matricula valor)
        {
            List<string> valores = new List<string>();
            valores.Add(Convert.ToString(valor.MateriasModulosId));
            valores.Add(Convert.ToString(valor.CriadorId));
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
