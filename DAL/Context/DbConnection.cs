using System.Data.Entity;
using iTechArt.Survey.DomainModel;

namespace DAL.Context
{
    public sealed class DbConnection : DbContext
    {
        public DbConnection() : base("DefaultString") { }
        internal DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<User>().Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(255);
            modelBuilder.Entity<User>().Property(x => x.Email).IsRequired().HasColumnName("Email");
            modelBuilder.Entity<User>().Property(x => x.Password).IsRequired();
            base.OnModelCreating(modelBuilder);
        }
    }
}