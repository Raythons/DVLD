using DLVD.App.Features.Common;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Query.GetLicensesList
{
    public record class GetLicensesListRequest(string? Fitler,
                                               string? OrderBy,
                                               bool? Descending = true,
                                               int Page = 1) :
        IRequest<Result<PagedList<GetPersonLicensesListResponse>>>
    {
    }
}
