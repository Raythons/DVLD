
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class LocalDLAConfig : IEntityTypeConfiguration<LocalDrivingLicenseApplication>
{
    public void Configure(EntityTypeBuilder<LocalDrivingLicenseApplication> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.LicenseClass)
            .WithMany(x => x.LocalDrivingLicenseApplications)
            .HasForeignKey(x => x.LicenseClassId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Application)
            .WithOne(x => x.LocalDrivingLicenseApplication)
            .HasForeignKey<LocalDrivingLicenseApplication>(x => x.ApplicationId)
            .OnDelete(DeleteBehavior.NoAction);

        //builder.HasOne(x => x.)
        //builder.HasOne(x => x.);
    }
}
