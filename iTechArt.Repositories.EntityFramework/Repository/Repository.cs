using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.Interfaces;

namespace iTechArt.Repositories.EntityFramework.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDbContext _dbContext;

        private IDbSet<T> TableDbSet => _dbContext.Set<T>();


        public Repository(IDbContext dbContext)
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


        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
        }


        public T GetById(int id)
        {
            return TableDbSet.Find(id);
        }


        public async Task<T> GetByAsync(Expression<Func<T, bool>> predicate)
        {
            return await TableDbSet.FirstOrDefaultAsync(predicate);
        }


        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return await TableDbSet.ToListAsync();
        }


        public async Task<int> DeleteRange(IEnumerable<T> collection)
        {
            ((DbSet<T>)TableDbSet).RemoveRange(collection);
            return await _dbContext.SaveChangesAsync();
        }
    }
}