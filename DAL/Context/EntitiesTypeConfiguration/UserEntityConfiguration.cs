using System.Data.Entity.ModelConfiguration;
using iTechArt.Survey.DomainModel;

namespace iTechart.Survey.DAL.Context.EntitiesTypeConfiguration
{
    internal class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        internal UserEntityConfiguration()
        {
            this.ToTable("Users");
            this.HasKey(x => x.Id);
            this.Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(255);
            this.Property(x => x.Email).IsRequired().HasColumnName("Email");
            this.Property(x => x.Password).IsRequired();
        }
    }
}