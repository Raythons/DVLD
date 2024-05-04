using DLVD.App.Features.Common;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Drivers.Query.GetDriversList
{
    public record class GetDriverListRequest(string? Fitler,
                                             string? OrderBy,
                                             bool? Descending = true,
                                             int Page = 1) :
        IRequest<Result<PagedList<DriversBreifInfoView>>>{ }
       
}

