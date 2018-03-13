using System;
using System.Collections.Generic;
using System.Linq;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.Interfaces;
using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Repositories.EntityFramework.UnitOfWork;

namespace iTechart.Survey.DAL
{
    public sealed class SurveyUnitOfWork : UnitOfWork, ISurveyUnitOfWork
    {
        private readonly IDbContext _dbContext;
        private readonly Dictionary<string, object> _repositories = new Dictionary<string, object>();

        public SurveyUnitOfWork(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public override IRepository<T> GetRepository<T>()
        {
            object repository;
            if (_repositories.TryGetValue(typeof(T).ToString(), out repository))
            {
                return (IRepository<T>)repository;
            }
            _repositories.Add(typeof(T).ToString(), new Repository<T>(_dbContext));
            _repositories.TryGetValue(typeof(T).ToString(), out repository);
            return (IRepository<T>)repository;
        }


        public override async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}