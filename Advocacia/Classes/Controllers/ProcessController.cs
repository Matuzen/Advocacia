using Advocacia.Data;
using Advocacia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Advocacia.Controllers
{
    public class ProcessController
    {
        #region Métodos
        public void Insert(Process process)
        {
            string processJson = JsonSerializer.Serialize(process);

            var request = WebRequest.CreateHttp(API.Url + "process");
            request.Method = "POST";
            request.ContentType = "application/json";
            request.ContentLength = processJson.Length;
            request.UserAgent = "Advocacia-API";

            try
            {
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(Encoding.UTF8.GetBytes(processJson), 0, processJson.Length);
                    stream.Close();
                }

                using (var response = request.GetResponse())
                {
                    var streamDados = response.GetResponseStream();
                    StreamReader reader = new StreamReader(streamDados);
                    object oResponse = reader.ReadToEnd();

                    Process processPost = JsonSerializer.Deserialize<Process>(oResponse.ToString());

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
