using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class Turmas : Tabela<Turmas>
    {
        private string tabela = "turma";
        private Utils u = new Utils();

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string curso;

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
        private int qutMax;

        public int QutMax
        {
            get { return qutMax; }
            set { qutMax = value; }
        }
        private int qutMin;

        public int QutMin
        {
            get { return qutMin; }
            set { qutMin = value; }
        }
        private int professorId;

        public int ProfessorId
        {
            get { return professorId; }
            set { professorId = value; }
        }
        private int criadorId;

        public int CriadorId
        {
            get { return criadorId; }
            set { criadorId = value; }
        }


        public void Editar(int id, Turmas valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Curso);
            valores.Add(Convert.ToString(valor.QutMax));
            valores.Add(Convert.ToString(valor.QutMin));
            valores.Add(Convert.ToString(valor.CriadorId));
            valores.Add(Convert.ToString(valor.ProfessorId));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(Turmas valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Curso);
            valores.Add(Convert.ToString(valor.QutMax));
            valores.Add(Convert.ToString(valor.QutMin));
            valores.Add(Convert.ToString(valor.CriadorId));
            valores.Add(Convert.ToString(valor.ProfessorId));
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
