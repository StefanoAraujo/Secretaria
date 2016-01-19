using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class Aluno : Tabela<Aluno>
    {
        private string tabela = "aluno";
        
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private int numeroImovel;

        public int NumeroImovel
        {
            get { return numeroImovel; }
            set { numeroImovel = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        private string celular;

        public string Celular
        {
            get { return celular; }
            set { celular = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private int turmaId;

        public int TurmaId
        {
            get { return turmaId; }
            set { turmaId = value; }
        }
        private int matriculaId;

        public int MatriculaId
        {
            get { return matriculaId; }
            set { matriculaId = value; }
        }

        private Utils u = new Utils();

        public void Editar(int id, Aluno valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(valor.DataNascimento.ToShortDateString());
            valores.Add(valor.Cidade);
            valores.Add(valor.Bairro);
            valores.Add(valor.Endereco);
            valores.Add(Convert.ToString(valor.NumeroImovel));
            valores.Add(valor.Rg);
            valores.Add(valor.Cpf);
            valores.Add(valor.Telefone);
            valores.Add(valor.Celular);
            valores.Add(valor.Email);
            valores.Add(Convert.ToString(valor.MatriculaId));
            valores.Add(Convert.ToString(valor.TurmaId));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(Aluno valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(valor.DataNascimento.ToString());
            valores.Add(valor.Cidade);
            valores.Add(valor.Bairro);
            valores.Add(valor.Endereco);
            valores.Add(Convert.ToString(valor.NumeroImovel));
            valores.Add(valor.Rg);
            valores.Add(valor.Cpf);
            valores.Add(valor.Telefone);
            valores.Add(valor.Celular);
            valores.Add(valor.Email);
            valores.Add(Convert.ToString(valor.MatriculaId));
            valores.Add(Convert.ToString(valor.TurmaId));
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
