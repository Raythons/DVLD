using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Licenses.Query.GetDetainedLicensesList
{
    public class GetDetainedLicensesListQueryHandller : BaseHandler,
         IRequestHandler<GetDetainedLicensesListRequest, Result<PagedList<DetainedLicenseView>>>
    {
        public GetDetainedLicensesListQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<DetainedLicenseView>>> Handle(
            GetDetainedLicensesListRequest request,
            CancellationToken cancellationToken)
        {
            var DetainedLicensesList = await _unitOfWork
                                                 .DetainedLicenseRepositry
                                                 .GetAllPaginatedAsync();


            if (DetainedLicensesList is null)
                return Result.Fail("Something Went Wrong");


            return Result.Ok(DetainedLicensesList);
        }
    }
}
