using DVLD.Domain;
using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class TestConfig : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.HasKey(x => x.Id);

        builder.HasOne(x => x.User)
            .WithMany(x => x.TestsCreated)
            .HasForeignKey(x => x.CreatedByUserId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(x => x.TestAppointment)
            .WithOne(x => x.Test)
            .HasForeignKey<Test>(x => x.TestAppointmentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.Property(x => x.TestResult)
                .HasConversion
                (x => (int)x,
                 x => (EnTestResult)Enum.Parse(typeof(EnTestResult), x.ToString())
                );
    }
}
