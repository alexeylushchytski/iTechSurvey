using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;
using DAL.Repositories;
using Models;

namespace DAL
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbConnection _dbContext;

        #region Repositories
        public IRepository<User> UsersRepository => new GenericRepository<User>(_dbContext);
        #endregion

        public UnitOfWork()
        {
            _dbContext = new DbConnection();
        }


        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }


        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
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
