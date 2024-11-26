using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace SchoolDBManage
{
    public class DataAccessLayer
    {
        //select
        public static DataTable ExecuteQuery(string query) 
        {
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ITI"].ConnectionString);
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }


        //inser,update, delete
        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int affected;
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["pubs"].ConnectionString);
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddRange(parameters);

            try
            {
                con.Open();
                affected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { con.Close(); }

            return affected;
        }
    }
}
