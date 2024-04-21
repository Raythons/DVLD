using DLVD.App.Features.Common;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDrivvingLicensesList
{
    record class GetLocalDrivvinglicensesListRequest(int Page = 1) :
        IRequest<Result<PagedList<BriefLocalDrivvingLicenseResponse>>>
    {
    }
}
