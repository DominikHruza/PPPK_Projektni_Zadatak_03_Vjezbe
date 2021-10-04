using System.Data.SqlClient;

namespace Projektni_Zadatak_03_Vjezbe.Dal
{
    class SqlRepository : IRepository
    {
        private string cs;
        private const string ConnectionString = "Server={0};Uid={1};Pwd={2}";


        public void LogIn(string server, string username, string password)
        {
            using (SqlConnection con = new SqlConnection(string.Format(ConnectionString, server, username, password)))
            {
                cs = con.ConnectionString;
                con.Open();
            }
        }
    }
}