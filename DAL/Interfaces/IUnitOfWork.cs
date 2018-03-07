namespace DAL.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();


        void RejectChanges();


        void Dispose();


        IRepository<T> GetRepository<T>() where T : class;
    }
}
