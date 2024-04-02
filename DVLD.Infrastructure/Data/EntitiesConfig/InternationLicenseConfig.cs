using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class InternationLicenseConfig : IEntityTypeConfiguration<InternationalDrivingLicense>
{
    public void Configure(EntityTypeBuilder<InternationalDrivingLicense> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.InternationalDLAsCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Application)
            .WithOne(x => x.InternationalDrivingLicenseApplication)
            .HasForeignKey<InternationalDrivingLicense>(x => x.ApplicationId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.License)
            .WithOne(x => x.InternationalDrivingLicense)
            .HasForeignKey<InternationalDrivingLicense>(x => x.IssueUsingLocalDrivingLicenseId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Driver)
            .WithOne(x => x.InternationalDrivingLicense)
            .HasForeignKey<InternationalDrivingLicense>(x => x.DriverId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}
