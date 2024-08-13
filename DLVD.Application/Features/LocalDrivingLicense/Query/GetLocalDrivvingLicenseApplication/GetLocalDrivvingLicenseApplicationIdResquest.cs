using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDrivvingLicenseApplication
{
    public record class GetLocalDrivvingLicenseApplicationIdResquest
        (int LocalDrivvingLicneseApplicationId) : IRequest<Result<int>>
    {
    }
}
