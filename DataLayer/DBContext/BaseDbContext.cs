using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DBContext
{
    public abstract class BaseDbContext<TContext> : System.Data.Entity.DbContext where TContext : System.Data.Entity.DbContext
    {
        protected BaseDbContext(string connectionStringName)
            : base(connectionStringName)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }
    }
}
