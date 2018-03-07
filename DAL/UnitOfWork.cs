using System.Data.Entity;
using DAL.Interfaces;
using DAL.Repositories;

namespace DAL
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;


        public UnitOfWork(){ }


        public UnitOfWork(DbContext dbConnection)
        {
            _dbContext = dbConnection;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        public void Dispose()
        {
            _dbContext.Dispose();
        }
       

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_dbContext);
        }
    }
}