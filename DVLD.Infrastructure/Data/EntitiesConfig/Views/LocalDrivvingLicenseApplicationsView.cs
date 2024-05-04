using DVLD.Domain.Entities.Views;
using DVLD.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Infrastructure.Data.EntitiesConfig.Views
{
    public class LocalDrivvingLicenseApplicationsViewConfig :
            IEntityTypeConfiguration<LocalDrivvingLicenseApplicationsView>
    {
        public void Configure(EntityTypeBuilder<LocalDrivvingLicenseApplicationsView> builder)
        {
            builder.HasNoKey();
            //builder.Property(x => x.PassedTestCount).HasColumnType("int");


            builder.Property(x => x.Status)
                .HasConversion(
                x => (short)x,
                x => (EnStatus)Enum.Parse(typeof(EnStatus), x.ToString())
                );

            builder.ToView("LocalDrivingLicenseApplications_View");
            


        }
    }
}
