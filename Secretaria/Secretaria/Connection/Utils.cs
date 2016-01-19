using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * @author Felipe de Oliveira
 * 
 * Esta classe serve para retornar ou inserir informações no
 * banco de dados de maneira simples.
 * 
 * Esta classe depende da classe Connect
 * 
 * */
namespace Secretaria.Connection
{
    class Utils : Connect
    {
        /**
         * @author Felipe de Oliveira
         * 
         * Retorna um <code>DataTable</code> apartir de uma string que indica a tabela.
         * São necessários o Nome da tabela.
         * */
        public DataTable RetornarTabela(string tabela)
        {
            //Abrindo conexão com o banco de dados
            DbConnection conexao = GetConnection();
            DbCommand comando = GetComando(conexao);

            //Informando parametros a serem passados
            comando.CommandText = CommandType.Text.ToString();
            comando.CommandText = "SELECT * FROM " + tabela + "";

            //Criando instancia de um dataTable que armazenara toda a tabela
            DataTable dataTable = new DataTable();
            try
            {
                DbDataReader reader = GetDataReader(comando);
                dataTable.Load(reader);

                //Fechando o DbDataReader
                reader.Close();
                reader.Dispose();
                comando.Dispose();
            }
            catch(Exception e)
            {
                MessageBox.Show("Erro ao tentar mostrar tabela. Mais informações:\n" + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Fechando a conexão com o banco de dados
            conexao.Close();
            conexao.Dispose();
            return dataTable;
        }

        /**
         * @author Felipe de Oliveira
         * 
         * Este método retorna um <code>list<string></code> com as informações
         * de uma unica coluna.
         * São necessário o Nome da tabela, o Nome da coluna e o valor a ser pesquisado
         * nos registros.
         * */
        public List<string> RetornarTabela(string tabela, string coluna)
        {
            DataTable tab = RetornarTabela(tabela);
            DataTableReader dtr = tab.CreateDataReader();
            List<string> retorno = new List<string>();
            while (dtr.Read())
            {
                retorno.Add(Convert.ToString(dtr[coluna]));
            }
            return retorno;
        }

        /**
         * @author Felipe Oliveira
         * 
         * Exclui uma linha da tabela.
         * São necessário o Id e o Nome da tabela
         * */
        public void Excluir(int id, string tabela)
        {
            if (VerificarSeExiste(tabela, id))
            {
                //Abrindo conexão com o banco de dados
                DbConnection conexao = GetConnection();
                DbCommand comando = GetComando(conexao);

                //Informando parametros a serem passados
                comando.CommandText = CommandType.Text.ToString();
                string nomeId = RetornarNomeColunaId(tabela);
                comando.CommandText = "DELETE FROM " + tabela + " WHERE " + nomeId + " = @" + nomeId;
                comando.Parameters.Add(new SqlParameter("@" + nomeId, id));
                try
                {
                    //Execução do comando
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Erro ao tentar excluir valores. Mais informações:\n " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Fechando a conexão com o banco de dados
                conexao.Close();
                conexao.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR: Não existe este valor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * @author Felipe de Oliveira
         * 
         * Insere valores na tabela com base em <code>List</code> que representa
         * as colunas e os valores.
         * São necessário o Nome da tabela, uma <code>List</code> de colunas e uma
         * <code>List</code> de valores
         * */
        public void Inserir(string tabela, List<string> valores)
        {
            //Abrindo conexão com o banco de dados
            DbConnection conexao = GetConnection();
            DbCommand comando = GetComando(conexao);

            comando.CommandType = CommandType.Text;

            List<string> colunas = NomeColunas(tabela);

            if (colunas.Count() == valores.Count())
            {
                List<string> colunasList = new List<string>();
                List<string> valoresComando = new List<string>();
                List<string> valoresInseridos = new List<string>();
                foreach (string texto in colunas)
                {
                    if (texto == colunas[(colunas.Count() - 1)])
                    {
                        colunasList.Add(texto);
                        valoresComando.Add("@" + texto);
                        valoresInseridos.Add("@" + texto);
                    }
                    else
                    {
                        colunasList.Add(texto + ", ");
                        valoresComando.Add("@" + texto + ", ");
                        valoresInseridos.Add("@" + texto);
                    }

                }

                string colunasConcat = String.Join(String.Empty, colunasList.ToArray());
                string valoresConcat = String.Join(String.Empty, valoresComando.ToArray());
                comando.CommandText = "INSERT dbo." + tabela + " (" + colunasConcat + ") VALUES (" + valoresConcat + ");";

                try
                {
                    for (int i = 0; i < valores.Count(); i++)
                    {
                        int inteiro;
                        double fracionado;
                        bool booleano;
                        if (int.TryParse(valores[i], out inteiro))
                        {
                            comando.Parameters.Add(new SqlParameter(valoresInseridos[i], int.Parse(valores[i])));
                        }
                        else if (double.TryParse(valores[i], out fracionado))
                        {
                            comando.Parameters.Add(new SqlParameter(valoresInseridos[i], double.Parse(valores[i])));
                        }
                        else if (bool.TryParse(valores[i], out booleano))
                        {
                            comando.Parameters.Add(new SqlParameter(valoresInseridos[i], bool.Parse(valores[i])));
                        }
                        else
                        {
                            comando.Parameters.Add(new SqlParameter(valoresInseridos[i].ToString(), valores[i].ToString()));
                        }
                    }
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    conexao.Dispose();
                    conexao.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comando.Dispose();
                    conexao.Dispose();
                    conexao.Close();
                }

            }
            else
            {
                MessageBox.Show("ERRO: Não foi possivel fazer esta inclusão devido a quantidade de colunas e argumentos adicionais", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /**
         * @author Felipe de oliveira
         * 
         * Este método permite editar algum registro na tabela.
         * São necessário o numero de ID do registro, o Nome da tabela, os valores e as colunas.
         * */
        public void Editar(int id, string tabela, List<string> valores)
        {
            if (VerificarSeExiste(tabela, id))
            {
                List<string> colunas = NomeColunas(tabela);

                if (colunas.Count() == valores.Count())
                {
                    //Abrindo conexão com o banco de dados
                    DbConnection conexao = GetConnection();
                    DbCommand comando = GetComando(conexao);

                    comando.CommandType = CommandType.Text;

                    List<string> colunasFormat = new List<string>();
                    List<string> colunasValorFormat = new List<string>();
                    foreach (string texto in colunas)
                    {
                        if (texto == colunas[(colunas.Count() - 1)])
                        {
                            colunasFormat.Add(texto + "=@" + texto);
                            colunasValorFormat.Add("@" + texto);
                        }
                        else
                        {
                            colunasFormat.Add(texto + "=@" + texto + ", ");
                            colunasValorFormat.Add("@" + texto);
                        }

                    }
                    string colunasConcat = String.Join(String.Empty, colunasFormat.ToArray());
                    comando.CommandText = "UPDATE " + tabela + " SET " + colunasConcat + " WHERE ID = @ID";
                    comando.Parameters.Add(new SqlParameter("@ID", id));

                    for (int i = 0; i < colunasValorFormat.Count(); i++)
                    {
                        //comando.Parameters.Add(new SqlParameter(arm1[i], valores[i]));
                        int inteiro;
                        double fracionado;
                        decimal moeda;
                        bool booleano;
                        if (int.TryParse(valores[i], out inteiro))
                        {
                            comando.Parameters.Add(new SqlParameter(colunasValorFormat[i], int.Parse(valores[i])));
                        }
                        else if (double.TryParse(valores[i], out fracionado))
                        {
                            comando.Parameters.Add(new SqlParameter(colunasValorFormat[i], double.Parse(valores[i])));
                        }
                        else if (decimal.TryParse(valores[i], out moeda))
                        {
                            comando.Parameters.Add(new SqlParameter(colunasValorFormat[i], decimal.Parse(valores[i])));
                        }
                        else if (bool.TryParse(valores[i], out booleano))
                        {
                            comando.Parameters.Add(new SqlParameter(colunasValorFormat[i], bool.Parse(valores[i])));
                        }
                        else
                        {
                            comando.Parameters.Add(new SqlParameter(colunasValorFormat[i], valores[i]));
                        }
                    }
                    try
                    {
                        comando.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ERRO: as colunas não coencidem com valores", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERRO: valor não existenete na tabela.\n Ou id não existente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /**
         * @author Felipe de Oliveira
         * 
         * Este método verifica se existe em uma tabela algum registro
         * compativel com o valor
         * É necessário a tabela, a coluna ou colunas e o valor
         * */
        public bool VerificarSeExiste(string tabela, string coluna, string valor)
        {

            DataTable tab = RetornarTabela(tabela);
            DataTableReader dtr = tab.CreateDataReader();
            List<string> retorno = new List<string>();
            while (dtr.Read())
            {
                
                retorno.Add(Convert.ToString(dtr[coluna]));
                
            }

            return retorno.Any(l => l == valor);

        }

        /**
         * @author Felipe de Oliveira
         * 
         * Este método verifica se existe em uma tabela algum registro de chave primaria
         * compativel com o valor
         * É necessário a tabela, a coluna ou colunas e o valor
         * 
         * Atenção: Este é exclusivo para chaves primárias. Po isso que ele é 
         * privado
         * 
         * */
        private bool VerificarSeExiste(string tabela, int id)
        {

            DataTable tab = RetornarTabela(tabela);
            DataColumn[] chavePrimaria = tab.PrimaryKey;
            DataTableReader dtr = tab.CreateDataReader();
            List<string> retorno = new List<string>();
            while(dtr.Read()){
                retorno.Add(Convert.ToString(dtr[chavePrimaria[0].ColumnName]));
            }

            return retorno.Any(l => l == Convert.ToString(id));

        }

        /**
         * @author Felipe de Oliveira
         * 
         * Retorna o nome da chave primaria
         * 
         * Atenção: Este é exclusivo para chaves primárias. Po isso que ele é 
         * privado
         * 
         * */
        private string RetornarNomeColunaId(string tabela)
        {
            DataTable tab = RetornarTabela(tabela);
            DataColumn[] chavePrimaria = tab.PrimaryKey;
            DataTableReader dtr = tab.CreateDataReader();
            List<string> retorno = new List<string>();
            return chavePrimaria[0].ColumnName;;
        }

        /**
         * @author Felipe de Oliveira
         * 
         * Este método verifica se existe em uma tabela algum registro
         * compativel com o valor
         * É necessário a tabela, a coluna ou colunas e o valor
         * */
        public bool VerificarSeExiste(string tabela, List<string> colunas, string valor)
        {

            DataTable tab = RetornarTabela(tabela);
            DataTableReader dtr = tab.CreateDataReader();
            List<string> retorno = new List<string>();
            while (dtr.Read())
            {
                foreach (string texto in colunas)
                {
                    retorno.Add(Convert.ToString(dtr[texto]));
                }

            }

            return retorno.Any(l => l == valor);

        }

        /**
         * @author Felipe de Oliveira
         * 
         * Este método permite retornar o nome das colunas de uma tabela.
         * É necessario o nome da tabela
         * */
        private List<string> NomeColunas(string tabela)
        {
            List<string> colunas = new List<string>();
            DataTable tab = RetornarTabela(tabela);
            //DataColumn[] chavePrimaria = tab.PrimaryKey;

            foreach (DataColumn column in tab.Columns)
            {
                if (!(column.ColumnName.ToUpper() == "ID"))
                {
                    colunas.Add(column.ColumnName);
                }
            }
            return colunas;
        }

    }
}
