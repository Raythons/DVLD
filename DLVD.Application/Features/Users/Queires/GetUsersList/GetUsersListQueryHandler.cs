using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using MediatR;
using System.Linq.Expressions;
using AutoMapper.QueryableExtensions;
using DLVD.App.extensions;
using FluentResults;

namespace DLVD.App.Features.Users.Queires.GetUsersList
{
    public class GetUsersListQueryHandler : BaseHandler,
        IRequestHandler<GetUsersListQuery, Result<PagedList<GetUserDto>>>
    {
        public GetUsersListQueryHandler(
            IUnitOfWork unitOfWork, 
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<GetUserDto>>> Handle(GetUsersListQuery request, CancellationToken cancellationToken)
        {
            IQueryable<User> UserQuery = _unitOfWork.UserRepository.GetPaginatedUsers();

            if (!string.IsNullOrWhiteSpace(request.SearchTerm))
                UserQuery = UserQuery.Where(u => u.UserName.Contains(request.SearchTerm));

            UserQuery = UserQuery.ApplySorting(request?.SortOrder, GerOrderByProperty(request?.SortCoulmn));


            var UsersDtoQuery =  UserQuery/*.Include(u => u.Person)*/
                                .ProjectTo<GetUserDto>(_mapper.ConfigurationProvider);

            var Users = await PagedList<GetUserDto>.CreateAsync(
                    UsersDtoQuery,
                    request.Page,
                    20
                   );
                              
            return Result.Ok(Users);
        }

        private static Expression<Func<User, object>> GerOrderByProperty(string? sortCoulmn)
        {
            return  sortCoulmn?.ToLower()
                switch
            {
                "name" => user => user.UserName,
                "id" => user => user.Id,
                "activity" => user => user.IsActive,
                _ => User => User.Id
            };
        }
    }
}
