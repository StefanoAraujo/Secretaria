using Secretaria.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secretaria.Tabelas
{
    class Funcionario : Tabela<Funcionario>
    {
        private string tabela = "funcionario";

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
        private string departamento;

        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        private DateTime dataNascimento;

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }
        private string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        private string rg;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
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
        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        private string bairro;

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        private string cidade;

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }
        private int numeroImovel;

        public int NumeroImovel
        {
            get { return numeroImovel; }
            set { numeroImovel = value; }
        }

        private Utils u = new Utils();

        public void Editar(int id, Funcionario valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(valor.Departamento);
            valores.Add(String.Format("{0:yyyy/M/d}", valor.DataNascimento));
            valores.Add(valor.Cpf);
            valores.Add(valor.Rg);
            valores.Add(valor.Telefone);
            valores.Add(valor.Celular);
            valores.Add(valor.Endereco);
            valores.Add(valor.Bairro);
            valores.Add(valor.Cidade);
            valores.Add(Convert.ToString(valor.NumeroImovel));
            u.Editar(id, this.tabela, valores);
        }

        public void Excluir(int id)
        {
            u.Excluir(id, this.tabela);
        }

        public void Inserir(Funcionario valor)
        {
            List<string> valores = new List<string>();
            valores.Add(valor.Nome);
            valores.Add(valor.Departamento);
            valores.Add(String.Format("{0:yyyy-M-d}", valor.DataNascimento));
            valores.Add(valor.Cpf);
            valores.Add(valor.Rg);
            valores.Add(valor.Telefone);
            valores.Add(valor.Celular);
            valores.Add(valor.Endereco);
            valores.Add(valor.Bairro);
            valores.Add(valor.Cidade);
            valores.Add(Convert.ToString(valor.NumeroImovel));
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
