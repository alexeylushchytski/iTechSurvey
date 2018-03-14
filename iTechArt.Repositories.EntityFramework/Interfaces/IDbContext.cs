using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;

namespace iTechArt.Repositories.EntityFramework.Interfaces
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;


        Task<int> SaveChangesAsync();


        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;


        void Dispose();
    }
}