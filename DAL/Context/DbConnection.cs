using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public sealed class DbConnection : DbContext
    {
        public DbConnection() : base("DefaultString") { }
    }
}
