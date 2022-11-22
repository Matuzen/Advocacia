using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Advocacia.Classes
{
    public class Banco
    {
        // Variável de conexão
        private static SqlConnection conexao;

        // Método de conexão retornando a conexão
        public static SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection("Data Source=AMAURYJR;Initial Catalog=ADVOCACIA_PRD;User=sa;Password=MasterKey21@");
                conexao.Open(); 
                return conexao;
            }
            catch(SqlException sqlEx)
            {
                throw sqlEx;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch(SqlException sqlEx)
            {
                throw sqlEx;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}