

using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class LicenseClassConfig : IEntityTypeConfiguration<LicenseClass>
{
    public void Configure(EntityTypeBuilder<LicenseClass> builder)
    {
        builder.Property(x => x.ClassFees).HasColumnType("smallmoney");
        builder.HasKey(x => x.Id);


        builder.HasData(FillInitialData());

    }

    public List<LicenseClass> FillInitialData()
    {
        var licenseClasses = new List<LicenseClass>
{
        new LicenseClass
        {
            Id =1,
            ClassName = "Small Motorcycle",
            ClassDescription = "Allows driving small motorcycles.",
            MinimumAllowedAge = 18,
            DefaultValidityLength = 5,
            ClassFees = 100.0f
        },
        new LicenseClass
        {
            Id =2,
            ClassName = "Heavy Motorcycle",
            ClassDescription = "Allows driving heavy motorcycles.",
            MinimumAllowedAge = 21,
            DefaultValidityLength = 5,
            ClassFees = 150.0f
        },
        new LicenseClass
        {
            Id =3,
            ClassName = "Ordinary Driving License",
            ClassDescription = "Allows ordinary driving of cars.",
            MinimumAllowedAge = 18,
            DefaultValidityLength = 10,
            ClassFees = 200.0f
        },
        new LicenseClass
        {
            Id =4,
            ClassName = "Commercial",
            ClassDescription = "Allows driving commercial vehicles.",
            MinimumAllowedAge = 21,
            DefaultValidityLength = 5,
            ClassFees = 300.0f
        },
        new LicenseClass
        {
            Id =5,
            ClassName = "Agricultural",
            ClassDescription = "Allows driving agricultural vehicles.",
            MinimumAllowedAge = 18,
            DefaultValidityLength = 5,
            ClassFees = 120.0f
        },
        new LicenseClass
        {
            Id =6,
            ClassName = "Small and Medium Buses",
            ClassDescription = "Allows driving small and medium buses.",
            MinimumAllowedAge = 21,
            DefaultValidityLength = 5,
            ClassFees = 250.0f
        },
        new LicenseClass
        {
            Id =7,
            ClassName = "Truck and Heavy Vehicle",
            ClassDescription = "Allows driving trucks and heavy vehicles.",
            MinimumAllowedAge = 21,
            DefaultValidityLength = 5,
            ClassFees = 350.0f
        }
};

        return licenseClasses;
    }
}
