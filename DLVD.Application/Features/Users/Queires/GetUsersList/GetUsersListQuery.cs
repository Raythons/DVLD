using DLVD.App.Features.Common;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Users.Queires.GetUsersList
{
    public record GetUsersListQuery(string? SearchTerm,
                                string? SortCoulmn,
                                string? SortOrder,
                                int Page = 1)
                                : IRequest<Result<PagedList<GetUserDto>>>
    {
    }
}
