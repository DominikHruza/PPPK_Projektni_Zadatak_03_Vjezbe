using Projektni_Zadatak_03_Vjezbe.Models;
using System.Collections.Generic;

namespace Projektni_Zadatak_03_Vjezbe.Dal
{
    internal interface IRepository
    {
        void LogIn(string server, string username, string password);
        IEnumerable<Database> GetDatabases();
    }
}