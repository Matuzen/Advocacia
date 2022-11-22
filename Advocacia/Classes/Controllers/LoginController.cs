using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advocacia.Classes.Controllers
{
    class LoginController
    {
        #region VÁRIAVEIS

        private string user;
        private string password;

        #endregion

        #region PROPRIEDADES

        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }

        #endregion

        #region MÉTODOS

        public bool Login()
        {
            try
            {
                using (SqlConnection con = Banco.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_validate_lawyer", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user", User);
                        cmd.Parameters.AddWithValue("@password", Password);

                        bool result = cmd.ExecuteScalar().ToString() == "0" ? false : true;

                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Banco.Desconectar();
            }
        }

        #endregion
    }
}
