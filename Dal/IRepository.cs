using Projektni_Zadatak_03_Vjezbe.Models;
using System.Collections.Generic;
using System.Data;

namespace Projektni_Zadatak_03_Vjezbe.Dal
{
    internal interface IRepository
    {
        void LogIn(string server, string username, string password);
        IEnumerable<Database> GetDatabases();
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        DataSet CreateDataSet(DBEntity dbEntity);
        DataSet CreateDataSet(string query);

        long RunNonQuery(string query); 
    }
}