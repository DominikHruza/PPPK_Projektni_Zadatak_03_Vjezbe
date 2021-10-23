using System;
using System.Collections.Generic;
using Projektni_Zadatak_03_Vjezbe.Dal;

namespace Projektni_Zadatak_03_Vjezbe.Models
{
    public class DBEntity
    {
        private readonly Lazy<IEnumerable<Column>> columns;
        public DBEntity()
        {
            columns = new Lazy<IEnumerable<Column>>(() => RepositoryFactory.GetRepository().GetColumns(this));
        }
        public IList<Column> Columns
        {
            get => new List<Column>(columns.Value);
        }
        public string Schema { get; set; }
        public string Name { get; set; }
        public Database Database { get; set; }
        public override string ToString() => $"{Schema}.{Name}";

    }
}
