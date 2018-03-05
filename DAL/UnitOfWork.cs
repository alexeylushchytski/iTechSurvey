using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DbConnection DbContext;

        #region Repositories

        #endregion

        public UnitOfWork(DbConnection dbContext)
        {
            DbContext = dbContext;
        }


        public void Commit()
        {
            DbContext.SaveChanges();
        }


        public void Dispose()
        {
            DbContext.Dispose();
        }


        public void RejectChanges()
        {
            foreach (var entry in DbContext.ChangeTracker.Entries()
                .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
