using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Query.GetLicensesList
{
    public class GetPersonLicensesListQueryHandller : BaseHandler,
        IRequestHandler<GetLicensesListRequest, Result<PagedList<GetPersonLicensesListResponse>>>
    {
        public GetPersonLicensesListQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : 
            base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<GetPersonLicensesListResponse>>> Handle(
            GetLicensesListRequest request,
            CancellationToken cancellationToken)
        {
            var LicensesList = await _unitOfWork
                                                 .LicenseRepositry
                                                 .GetAllByProjectionAsync<GetPersonLicensesListResponse>
                                                 (L =>  new GetPersonLicensesListResponse (1));

            if (LicensesList is null)
                return Result.Fail("Something Went Wrong");

            return Result.Ok(LicensesList);
        }
    }
}
