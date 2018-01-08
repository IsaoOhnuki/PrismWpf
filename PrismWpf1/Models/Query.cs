using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismWpf1.Models
{
    public class Query
    {
        private static DataModule.Database db;
        public static DataModule.Database DB { get { return DB ?? (db = new DataModule.Database()); } }

        public IQueryable<DataModule.MyEntity> MyEntities()
        {
            return DB.MyEntities;
        }
    }
}
