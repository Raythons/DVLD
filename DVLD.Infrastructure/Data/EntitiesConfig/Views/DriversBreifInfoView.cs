using DVLD.Domain.Entities.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DVLD.Infrastructure.Data.EntitiesConfig.Views
{
    public class DriversBreifInfoViewConfig : IEntityTypeConfiguration<DriversBreifInfoView>
    {
        public void Configure(EntityTypeBuilder<DriversBreifInfoView> builder)
        {
            builder.HasNoKey();


            builder.ToView("Drivers_View");
        }
    }
}
