using DVLD.Domain.Entities.Views;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Infrastructure.Data.EntitiesConfig.Views
{
    public class DetainedLicenseViewConfig : IEntityTypeConfiguration<DetainedLicenseView>
    {
        public void Configure(EntityTypeBuilder<DetainedLicenseView> builder)
        {
            builder.HasNoKey();

            builder.ToView("DetainedLicenseView");
        }
    }
}
