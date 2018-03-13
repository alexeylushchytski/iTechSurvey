using System.Threading.Tasks;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Repositories.Interfaces;

namespace iTechArt.Repositories.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbContext _dbContext;


        public UnitOfWork(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
            return new Repository<T>(_dbContext);
        }
    }
}