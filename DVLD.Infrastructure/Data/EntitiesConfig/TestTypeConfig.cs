

using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class TestTypeConfig : IEntityTypeConfiguration<TestType>
{
    public void Configure(EntityTypeBuilder<TestType> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.TestTypeFees)
            .HasColumnType("smallmoney");

        builder.HasData(FillInitialData());

    }

    private List<TestType> FillInitialData()
    {
        List<TestType> applicationTypes = new List<TestType>() {
            new(){
                Id =1,
                TestTypeTitle = "VisionTest",
                TestTypeDescription = "Test For Eyes Of The Candidate",
                TestTypeFees = 15.5f
            }, new(){
                Id =2,
                TestTypeTitle = "Written Test",
                TestTypeDescription = "Test For Eyes Of The Candidate",
               TestTypeFees = 15.5f
            },
            new(){
                Id =3,
                TestTypeTitle = "Practical Test",
                TestTypeDescription = "Test For Eyes Of The Candidate",
               TestTypeFees = 15.5f
            }
        };
        return applicationTypes;
    }
}
