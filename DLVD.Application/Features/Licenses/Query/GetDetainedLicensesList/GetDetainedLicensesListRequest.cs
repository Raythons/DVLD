﻿using DLVD.App.Features.Common;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Query.GetDetainedLicensesList
{
    public record class GetDetainedLicensesListRequest (
                                            string? Fitler,
                                               string? OrderBy,
                                               bool? Descending = true,
                                               int Page = 1) :
        IRequest<Result<PagedList<DetainedLicenseView>>>
    {
    }
}
