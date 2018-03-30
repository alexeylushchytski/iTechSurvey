using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Repositories.EntityFramework.Repository;
using iTechArt.Survey.DomainModel;

namespace iTechart.Survey.DAL.Repositories
{
    public class UsersRepository: Repository<User>
    {
        private readonly IDbContext _dbContext;


        public UsersRepository(IDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

                
        public override async Task<IReadOnlyCollection<User>> GetAllAsync()
        {
            return await TableDbSet.Include(x => x.Role).ToListAsync();
        }
    }
}
