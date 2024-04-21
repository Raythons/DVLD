using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;
using System.Linq.Expressions;
using Application = DVLD.Domain.Entities.Application;
using DLVD.App.Features.Applications.Queries.GetApplicationsList;

namespace DLVD.App.Features.Applications.Queries.GetApplication
{
    public class GetApplicationListQueryHandller : BaseHandler,
                    IRequestHandler<GetApplicationListQuery,Result<List<GetApplicationListDto>>>
    {
        public GetApplicationListQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<List<GetApplicationListDto>>> Handle(
            GetApplicationListQuery request, CancellationToken cancellationToken)
        {

            var sortColumnExp = GerOrderByProperty(request.SortCoulmn);

            var application = await _unitOfWork.ApplicationRepositry
                                    .GetPaginatedAsync(request.Page,                                                  
                                                  sortColumnExp,
                                                  request.SearchTerm,
                                                  request.SortOdrer
                                                );

            if (application is null)
                return Result.Fail("Application Not Found");

            var applicationsDtoList = _mapper
                    .Map<List<GetApplicationListDto>>(application);

            return Result.Ok(applicationsDtoList);
        }
        private static Expression<Func<Application, object>> GerOrderByProperty(string? sortCoulmn)
        {
            return sortCoulmn?.ToLower()
                switch
            {
                "Application" => application => application.Id,
                "Status" => application => application.Status,
                "CreationDate" => application => application.CreatedAt,
                _ => application => application.Id
            };
        }
    }
}
