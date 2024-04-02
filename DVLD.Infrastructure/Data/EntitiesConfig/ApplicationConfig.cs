

using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class ApplicationConfig : IEntityTypeConfiguration<Application>
{
    public void Configure(EntityTypeBuilder<Application> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.ApplicationsCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.Person)
            .WithMany(x => x.Applications)
            .HasForeignKey(x => x.PersonId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.ApplicationType)
            .WithMany(x => x.Applications)
            .HasForeignKey(x =>x.ApplicationTypeId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x => x.Status)
            .HasConversion(
            x => (short)x,
            x => (EnStatus)Enum.Parse(typeof(EnStatus), x.ToString())
            );

        builder.Property(x => x.PaidFees)
            .HasColumnType("smallmoney");
    }
}
