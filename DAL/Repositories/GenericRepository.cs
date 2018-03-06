using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using DAL.Context;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        private IDbSet<T> TableDbSet => _dbContext.Set<T>();


        public GenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<T> Entities => TableDbSet;


        public void Remove(T entity)
        {
            TableDbSet.Remove(entity);
        }


        public void Add(T entity)
        {
            TableDbSet.Add(entity);
        }


        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }


        public T GetById(int id)
        {
            return TableDbSet.Find(id);
        }

        
    }
}
