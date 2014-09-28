using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Database.Repositories
{
    public class DataSource<TEntityType> : DbContext where TEntityType : class
    {
        public DataSource()
            : base("Server=127.0.0.1;Database=plusemu;Uid=root;Pwd=knoef14;")
        {
            Database.CommandTimeout = 5;
        }

        protected DbSet<TEntityType> GetTable()
        {
            return Set<TEntityType>();
        }
    }
}
