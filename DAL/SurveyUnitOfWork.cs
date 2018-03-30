using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechart.Survey.DAL.Interfaces;
using iTechart.Survey.DAL.Repositories;
using iTechArt.Repositories.EntityFramework.UnitOfWork;

namespace iTechart.Survey.DAL
{
    public sealed class SurveyUnitOfWork : UnitOfWork, ISurveyUnitOfWork
    {
        private readonly IDbContext _dbContext;


        public UsersRepository UsersRepository { get; set; }

        public SurveyUnitOfWork(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
            UsersRepository = new UsersRepository(_dbContext);
        }
    }
}