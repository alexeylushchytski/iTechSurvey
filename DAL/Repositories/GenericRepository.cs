using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Context;
using DAL.Interfaces;

namespace DAL.Repositories
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbConnection _dbContext;

        private IDbSet<T> TableDbSet => _dbContext.Set<T>();

        public IQueryable<T> Entities => TableDbSet;


        public GenericRepository(DbConnection dbContext)
        {
            _dbContext = dbContext;
        }


        public void Remove(T entity)
        {
            TableDbSet.Remove(entity);
        }


        public void Add(T entity)
        {
            TableDbSet.Add(entity);
        }
    }
}
