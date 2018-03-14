using System.Data.Entity.ModelConfiguration;
using iTechArt.Survey.DomainModel;

namespace iTechart.Survey.DAL.Context.EntitiesTypeConfiguration
{
    internal class UserEntityConfiguration : EntityTypeConfiguration<User>
    {
        internal UserEntityConfiguration()
        {
            ToTable("Users");
            HasKey(x => x.Id);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(255);
            Property(x => x.Email).IsRequired().HasColumnName("Email");
            Property(x => x.Password).IsRequired();
        }
    }
}