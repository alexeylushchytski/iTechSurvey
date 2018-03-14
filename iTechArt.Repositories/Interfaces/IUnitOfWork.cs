using System.Threading.Tasks;

namespace iTechArt.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task<int> CommitAsync();


        void Dispose();


        IRepository<T> GetRepository<T>() where T : class;
    }
}