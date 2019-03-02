using Events.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Events.Infra.Data.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Adresses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Street).HasColumnType("varchar(50)").IsRequired();

            builder.Property(x => x.District).HasColumnType("varchar(20)").IsRequired();

            builder.Property(x => x.City).HasColumnType("varchar(20)").IsRequired();

            builder.Property(x => x.State).HasColumnType("varchar(20)").IsRequired();

            builder.Property(x => x.Complement).HasColumnType("varchar(50)").IsRequired();

            builder.Property(x => x.Number).HasColumnType("varchar(30)").IsRequired();

            builder.Property(x => x.CEP).HasColumnType("varchar(8)").IsRequired();
        }
    }
}
