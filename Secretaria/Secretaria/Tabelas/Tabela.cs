using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Secretaria.Connection;
using System.Data;

namespace Secretaria.Tabelas 
{
    interface Tabela <TTipo>
    {
        void Editar(int id, TTipo valor);

        void Excluir(int id);

        void Inserir(TTipo valor);

        bool VerificarSeExiste(string coluna, string valor);

        bool VerificarSeExiste(List<string> colunas, string valor);

        DataTable RetornarTabela();

        List<string> RetornarTabela(string coluna);

    }
}
