using Events.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Map
{
    class OrganizerMap : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            builder.ToTable("Organizers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(25)").IsRequired();

            builder.Property(x => x.CPF).HasColumnType("varchar(11)").IsRequired();

            builder.Property(x => x.Email).HasColumnType("varchar(30)").IsRequired();

            builder.HasMany(x => x.Events).WithOne(x => x.Organizer).HasForeignKey(x => x.OrganizerId).IsRequired(false);
        }
    }
}
