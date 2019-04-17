using Events.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Map
{
    public class EventMap : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.ToTable("Events");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();

            builder.Property(x => x.ShortDescription).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.FullDescription).HasColumnType("varchar(100)").IsRequired();

            builder.Property(x => x.CompanyName).HasColumnType("varchar(25)").IsRequired();

            builder.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();

            builder.Property(x => x.Name).HasColumnType("varchar(100)").IsRequired();

            builder.Ignore(x => x.Tags);

            builder.HasOne(x => x.Category).WithMany(x => x.Events).IsRequired();

            builder.HasOne(x => x.Address).WithOne().HasForeignKey<Event>(x => x.AddressId).IsRequired();
        }
    }
}
