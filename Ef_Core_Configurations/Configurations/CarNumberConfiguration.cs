using Ef_Core_Configurations.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Ef_Core_Configurations.Configurations
{
    public class CarNumberConfiguration : IEntityTypeConfiguration<CarNumber>
    {
        public void Configure(EntityTypeBuilder<CarNumber> builder)
        {
            builder.ToTable("CarNumbers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Number)
                 .IsRequired()
                 .HasMaxLength(100);

            builder.HasIndex(x => x.Number)
                .IsUnique()
                .HasDatabaseName("uk_CarNumber_Number");

            builder.HasIndex(x=> new {x.Id,x.IsDeleted})
                .IsUnique();

        }
    }
}
