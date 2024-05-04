using FluentResults;
using MediatR;

namespace DLVD.App.Features.InternationalDrivvingLicenses.Query.GetInternationalLicense
{
    public record class GetInternationalLicenseRequest (int LicenseId): 
        IRequest<Result<GetInternationalLicenseResponse>>
    {
    }
}
