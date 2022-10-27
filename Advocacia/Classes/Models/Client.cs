using Advocacia.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;

namespace Advocacia.Models
{
    public class Client : Addresses
    {
        #region Variaveis

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string RG { get; set; }

        public DateTime Birth_Date { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(15)]
        public string Phone { get; set; }

        #endregion

        #region Métodos

        public long Insert(Client client)
        {
            // Converter o objeto Client para JSON
            string clientJson = JsonSerializer.Serialize(client);

            // Criando e configurando a Requisição a API
            var request = WebRequest.CreateHttp(API.Url + "client");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = clientJson.Length;
            request.UserAgent = "Advocacia-API";

            long id;

            try
            {
                //Escrever os dados post para o stream
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(Encoding.UTF8.GetBytes(clientJson), 0, clientJson.Length);
                    stream.Close();
                }

                //Ler a resposta da Requisição
                using (var response = request.GetResponse())
                {
                    var streamDados = response.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object oResponse = reader.ReadToEnd();

                    Client clientPost = JsonSerializer.Deserialize<Client>(oResponse.ToString());

                    id = clientPost.Id;

                    response.Close();
                }

                return id;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Client client)
        {
            // Converter o objeto Client para JSON
            string clientJson = JsonSerializer.Serialize(client);

            // Criando e configurando a Requisição a API
            var request = WebRequest.CreateHttp(API.Url + "client/" + client.Id);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.ContentLength = clientJson.Length;
            request.UserAgent = "Advocacia-API";

            try
            {
                //Escrever os dados post para o stream
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(Encoding.UTF8.GetBytes(clientJson), 0, clientJson.Length);
                    stream.Close();
                }

                //Ler a resposta da Requisição
                using (var response = request.GetResponse())
                {
                    var streamDados = response.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object oResponse = reader.ReadToEnd();

                    Client clientPost = JsonSerializer.Deserialize<Client>(oResponse.ToString());

                    response.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        #endregion
    }
}