using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Advocacia.Classes
{
    class Banco
    {
        // Variável de conexão
        private static SQLiteConnection conexao;

        // Método de conexão retornando a conexão
        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source=D:\\PIM\\TOP SERVICES BRASIL ADVOCACIA\\Advocacia\\Advocacia\\Banco\\banco_advocacia.db"); // caminho do banco de dados e o nome do banco de dados
            conexao.Open(); // Abre a conexão 
            return conexao;
            // Aqui o return serve para retornar a conexão com o banco aberta caso ele seja chamado em outra parte do projeto
        }

        public static DataTable ObterTodosUsuarios()
        // Retorna um DataTable já preenchido com todos os usuários do sistema
        // Criar um comand na nossa conxeão com o sql e passar para um DataAdapter que vai fazer a consulta e preencher um DataTable com essas informações                                                                                                          
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();        // Rotina que engloba todo o conteúdo. Como se fosse um container
                                                       // Chama o banco ConexaoBanco e Retorna do banco o método CreateCommand
                cmd.CommandText = "SELECT * FROM Lawyers";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon); // Criar o DataAdapter pois ele precisa do comando SQL e da ConexaoBanco passar 2 comando pra ele, comando que a gente quer utilizar e a conexao 
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
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
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


        // Funções do form Clients

        public static void NovoCliente(Clients c)
        { 
            
        }

    }
}