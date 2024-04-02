
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class DetainedLicenseConfig : IEntityTypeConfiguration<DetainedLicense>
{
    public void Configure(EntityTypeBuilder<DetainedLicense> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.License)
            .WithMany(x => x.DetainedLicense)

            .HasForeignKey(x => x.LicenseId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.ReleaseUser)
            .WithMany(x => x.DetainedLicensesReleased)
            .HasForeignKey(x => x.ReleasedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.CreateUser)
            .WithMany(x => x.DetainedLicensesCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);


        builder.HasOne(x => x.Application)
            .WithMany(x => x.DetainedLicense)
           .HasForeignKey(x => x.ReleaseApplicationId);

        builder.Property(x => x.FineFees).HasColumnType("smallmoney");

    }

   
}
