using Projektni_Zadatak_03_Vjezbe.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Projektni_Zadatak_03_Vjezbe.Dal
{
    class SqlRepository : IRepository
    {
        private string cs;
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";
        private const string SelectDatabases = "SELECT name As Name from sys.databases";


        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }

        public IEnumerable<Database> GetDatabases()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                using (SqlCommand cmd = con.CreateCommand())
                {
                    cmd.CommandText = SelectDatabases;
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            yield return new Database
                            {
                                Name = dr[nameof(Database.Name)].ToString()
                            };
                        }
                    }
                }
            }
        }
    }
}