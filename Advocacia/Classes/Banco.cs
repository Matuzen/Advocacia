using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Advocacia.Classes
{
    class Banco
    {
        // Variável de conexão
        private static SqlConnection conexao;

        // Método de conexão retornando a conexão
        private static SqlConnection ConexaoBanco()
        {
            conexao = new SqlConnection("Data Source=D:\\PIM\\TOP SERVICES BRASIL ADVOCACIA\\Advocacia\\Advocacia\\Banco\\banco_advocacia.db"); // caminho do banco de dados e o nome do banco de dados
            conexao.Open(); // Abre a conexão 
            return conexao;
            // Aqui o return serve para retornar a conexão com o banco aberta caso ele seja chamado em outra parte do projeto
        }

        // Método de conexão retornando a conexão
        public static SqlConnection Conectar()
        {
            try
            {
                conexao = new SqlConnection("Server=./SQLEXPRESS;Database=ADVOCACIA_PRD; Trusted_Connection=True;"); // caminho do banco de dados e o nome do banco de dados
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

        public static DataTable ObterTodosUsuarios()
        // Retorna um DataTable já preenchido com todos os usuários do sistema
        // Criar um comand na nossa conxeão com o sql e passar para um DataAdapter que vai fazer a consulta e preencher um DataTable com essas informações                                                                                                          
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();        // Rotina que engloba todo o conteúdo. Como se fosse um container
                                                       // Chama o banco ConexaoBanco e Retorna do banco o método CreateCommand
                cmd.CommandText = "SELECT * FROM Lawyers";
                da = new SqlDataAdapter(cmd.CommandText, vcon); // Criar o DataAdapter pois ele precisa do comando SQL e da ConexaoBanco passar 2 comando pra ele, comando que a gente quer utilizar e a conexao 
                da.Fill(dt); // preencer o DataTable com essas informações, atualiza as linhas no DataSet
                vcon.Close();
                return dt;
                // Retorna todos os usuários do nosso sistema

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Método genérico para consultas que retorna um DataTable com o resultado da consulta
        public static DataTable Consulta(string sql)
        {
            SqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = Conectar();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
                // Retorna todos os usuários do nosso sistema

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}