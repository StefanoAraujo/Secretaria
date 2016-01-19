using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Secretaria.Connection
{
    class Connect
    {
        public static DbConnection GetConnection()
        {
            try
            {
                DbConnection conexao = new SqlConnection(@"Data Source=192.168.0.16,1433; Network Library=DBMSSOCN; Initial Catalog=secretaria; User ID=Cronos; Password=qwerty;");
                conexao.Open();
                return conexao;
            }catch(Exception e){
                MessageBox.Show("Erro ao abrir conexão " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DbCommand GetComando(DbConnection conexao)
        {
            try
            {
                DbCommand comando = conexao.CreateCommand();
                return comando;
            }catch(Exception e){
                MessageBox.Show("Erro ao realizar o comando " + e.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DbDataReader GetDataReader(DbCommand comando)
        {
            try
            {
                return comando.ExecuteReader();
            }catch(Exception e){
                MessageBox.Show("Erro ao retornar os valores " + e.Message + " " + e.Source, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
