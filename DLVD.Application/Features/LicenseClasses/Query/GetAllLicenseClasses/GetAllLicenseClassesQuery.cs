using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.LicenseClasses.Query.GetAllLicenseClasses
{
    public class GetAllLicenseClassesQuery :
        IRequest<Result<IEnumerable<LicenseClassDto>>>
    {
    }
}
