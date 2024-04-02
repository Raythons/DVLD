

using DVLD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Data.Data.EntitiesConfig;

internal class AppTypesConfig : IEntityTypeConfiguration<ApplicationType>
{
    public void Configure(EntityTypeBuilder<ApplicationType> builder)
    {
        builder.HasKey(x => x.ApplicationTypeId);

        builder.HasData(FillInitialData());
    }

    private List<ApplicationType> FillInitialData()
    {
        List<ApplicationType> applicationTypes = new List<ApplicationType>() { 
            new(){
                ApplicationTypeId =1,
                ApplicationTypeTitle = "New Local Driving License Service ",
                ApplicationTypeFees = 15.5f
            }, new(){
                ApplicationTypeId = 2,
                ApplicationTypeTitle = "Renew Driving License Service",
                ApplicationTypeFees = 5f
            }, 
            new(){
                ApplicationTypeId = 3,
                ApplicationTypeTitle = "Replacment for a Lost Driving License",
                ApplicationTypeFees = 10f
            }, 
            new(){
                ApplicationTypeId = 4,
                ApplicationTypeTitle = "Replacment for a Damaged  Driving License",
                ApplicationTypeFees = 15.5f
            }, 
            new(){
                ApplicationTypeId = 5,
                ApplicationTypeTitle = "Release Detained Driving License",
                ApplicationTypeFees = 15.5f
            },
            new(){
                ApplicationTypeId = 6,
                ApplicationTypeTitle = "New International License ",
                ApplicationTypeFees = 15.5f
            },
            new(){
                ApplicationTypeId = 7,
                ApplicationTypeTitle = "Retake Test",
                ApplicationTypeFees = 15.5f
            },
        };
        return applicationTypes;
    }
}
