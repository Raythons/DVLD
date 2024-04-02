using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class LicenseConfig : IEntityTypeConfiguration<License>
{
    public void Configure(EntityTypeBuilder<License> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.LicenseClass)
            .WithMany(x => x.Licenses).HasForeignKey(x=> x.LicenseClassId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.User)
            .WithMany(x => x.LicensesCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Application)
            .WithOne(x => x.License)
            .HasForeignKey<License>(x => x.ApplicationId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Driver)
            .WithOne(x => x.License)
            .HasForeignKey<License>(x => x.DriverId);
    }
}
