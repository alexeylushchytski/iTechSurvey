using System.Data.Entity;
using iTechart.Survey.DAL.Context.EntitiesTypeConfiguration;
using iTechArt.Repositories.EntityFramework.Interfaces;
using iTechArt.Survey.DomainModel;

namespace iTechart.Survey.DAL.Context
{
    public sealed class SurveyContext : DbContext, IDbContext
    {
        public SurveyContext() : base("DefaultString") { }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            this.Configuration.LazyLoadingEnabled = false;
            modelBuilder.Configurations.Add(new UserEntityConfiguration());
        }


        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return this.Set<TEntity>();
        }
    }
}