using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advocacia.Models;

namespace Advocacia.Classes.Controllers
{
    public class ClientControlller
    {
        #region Métodos

        public long Insert(Client client)
        {
            try
            {
                using (SqlConnection con = Banco.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_insert_client", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", client.Name);
                        cmd.Parameters.AddWithValue("@RG", client.RG);
                        cmd.Parameters.AddWithValue("@Birth_Date", client.Birth_Date);
                        cmd.Parameters.AddWithValue("@Email", client.Email);
                        cmd.Parameters.AddWithValue("@Phone", client.Phone);
                        cmd.Parameters.AddWithValue("@Address_Code", client.Address_Code);
                        cmd.Parameters.AddWithValue("@Address", client.Address);
                        cmd.Parameters.AddWithValue("@Number", client.Number);
                        cmd.Parameters.AddWithValue("@District", client.District);
                        cmd.Parameters.AddWithValue("@City", client.City);
                        cmd.Parameters.AddWithValue("@State", client.State);
                        
                        cmd.Parameters.Add("@Id", SqlDbType.BigInt);
                        cmd.Parameters["@Id"].Direction = ParameterDirection.Output;

                        con.Open();
                        cmd.ExecuteNonQuery();

                        long id = (long)cmd.Parameters["@Id"].Value;

                        return id;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Client client)
        {           
            try
            {
                using (SqlConnection con = Banco.Conectar())
                {
                    using (SqlCommand cmd = new SqlCommand("sp_update_client", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", client.Name);
                        cmd.Parameters.AddWithValue("@RG", client.RG);
                        cmd.Parameters.AddWithValue("@Birth_Date", client.Birth_Date);
                        cmd.Parameters.AddWithValue("@Email", client.Email);
                        cmd.Parameters.AddWithValue("@Phone", client.Phone);
                        cmd.Parameters.AddWithValue("@Address_Code", client.Address_Code);
                        cmd.Parameters.AddWithValue("@Address", client.Address);
                        cmd.Parameters.AddWithValue("@Number", client.Number);
                        cmd.Parameters.AddWithValue("@District", client.District);
                        cmd.Parameters.AddWithValue("@City", client.City);
                        cmd.Parameters.AddWithValue("@State", client.State);
                        cmd.Parameters.AddWithValue("@Id", client.Id);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
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
