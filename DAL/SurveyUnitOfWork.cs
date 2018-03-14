using iTechArt.Repositories.EntityFramework.Interfaces;
using System.Threading.Tasks;
using iTechart.Survey.DAL.Interfaces;
using iTechArt.Repositories.EntityFramework.UnitOfWork;

namespace iTechart.Survey.DAL
{
    public sealed class SurveyUnitOfWork : UnitOfWork, ISurveyUnitOfWork
    {
        private readonly IDbContext _dbContext;


        public SurveyUnitOfWork(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public override async Task<int> CommitAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }
    }
}