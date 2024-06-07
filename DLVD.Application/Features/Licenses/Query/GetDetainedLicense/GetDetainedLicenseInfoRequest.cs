using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Query.GetDetainedLicense
{
    public class GetDetainedLicenseInfoRequest : IRequest<Result<GetDetainedLicenseInfoResponse>>
    {
        public int LicenseId { get; set; }

        public GetDetainedLicenseInfoRequest(int licenseId)
        {
            LicenseId = licenseId;
        }
    }
}
