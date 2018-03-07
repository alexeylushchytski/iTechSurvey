using System.Data.Entity;
using System.Linq;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        private IDbSet<T> TableDbSet => _dbContext.Set<T>();


        public Repository(DbContext dbContext)
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