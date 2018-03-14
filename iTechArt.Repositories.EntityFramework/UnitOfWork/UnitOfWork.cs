using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Repositories.Interfaces;

namespace iTechArt.Repositories.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;


        private readonly Dictionary<Type, object> _repositories;


        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
            _repositories = new Dictionary<Type, object>();
        }


        public virtual async Task<int>  CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }


        public virtual IRepository<T> GetRepository<T>() where T : class
        {
            object repository;
            if (_repositories.TryGetValue(typeof(T), out repository))
            {
                return (IRepository<T>)repository;
            }
            var repositore = new Repository<T>(_dbContext);
            _repositories.Add(typeof(T), repositore);
            return repositore;
        }
    }
}