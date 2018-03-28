using System.Data.Entity;
using iTechart.Survey.DAL.Context.EntitiesTypeConfiguration;
using iTechArt.Repositories.EntityFramework.Interfaces;

namespace iTechart.Survey.DAL.Context
{
    public sealed class SurveyContext : DbContext, IDbContext
    {
        public SurveyContext() : base("DefaultString")
        {
            Configuration.LazyLoadingEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
            modelBuilder.Configurations.Add(new RoleEntityConfiguration());
        }


        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return Set<TEntity>();
        }
    }
}