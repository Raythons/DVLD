using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain;
using DVLD.Domain.Entities;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDrivvingLicensesList
{
    public class GetLocalDrivvinglicensesListCommandHandler : BaseHandler,
        IRequestHandler<GetLocalDrivvinglicensesListRequest, Result<PagedList<LocalDrivvingLicenseApplicationsView>>>

    {
        public GetLocalDrivvinglicensesListCommandHandler(
            IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<LocalDrivvingLicenseApplicationsView>>> Handle(
            GetLocalDrivvinglicensesListRequest request,
            CancellationToken cancellationToken)
        {

            var LocalDrivvingLicenseList = await _unitOfWork
                                                    .LocalDrivingLicenseApplicationRepositry
                                                    .GetAllPaginatedAsync(); 
                                                                                                                      

            if (LocalDrivvingLicenseList is null)
                return Result.Fail("Something Went Wrong");


            return Result.Ok(LocalDrivvingLicenseList);


        }
    } 
}
