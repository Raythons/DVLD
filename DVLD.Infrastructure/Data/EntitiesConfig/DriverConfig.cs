using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class DriverConfig : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.DriversCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Person)
            .WithOne(x => x.Driver)
            .HasForeignKey<Driver>(x => x.PersonId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
