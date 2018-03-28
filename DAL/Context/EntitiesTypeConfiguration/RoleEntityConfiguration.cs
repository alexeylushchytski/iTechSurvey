using System.Data.Entity.ModelConfiguration;
using iTechArt.Survey.DomainModel;

namespace iTechart.Survey.DAL.Context.EntitiesTypeConfiguration
{
    internal class RoleEntityConfiguration : EntityTypeConfiguration<Role>
    {
        internal RoleEntityConfiguration()
        {
            ToTable("Roles");
            HasKey(x => x.Id);
            Property(x => x.Name).HasColumnName("Name").IsRequired().HasMaxLength(255);
        }
    }
}