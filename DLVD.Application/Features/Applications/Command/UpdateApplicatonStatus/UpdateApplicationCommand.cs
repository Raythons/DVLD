using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common.Converters;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DLVD.App.Features.Applications.Command.UpdateApplicaton
{
    public class UpdateApplicationStatusCommand : IRequest<Result<bool>>
    {
        // Re-using the CreateApplication command To Make The
        // Same Validation when creating new Application  

        public int LocalDrivvingLicenseApplicationId { get; set; }

        public UpdateApplicationStatusCommand(
            int localDrivvingLicenseApplicationId
            )
        {
            LocalDrivvingLicenseApplicationId = localDrivvingLicenseApplicationId;
        }
    }
}
