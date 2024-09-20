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

namespace DLVD.App.Features.Licenses.Query.GetLicenseId
{
    public class GetLicenseIdQueryHandler : BaseHandler,
        IRequestHandler<GetLicenseIdRequest, Result<int>>
    {
        public GetLicenseIdQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<int>> Handle(
            GetLicenseIdRequest request,
            CancellationToken cancellationToken)
        {
            var LicenseId = await _unitOfWork.LicenseRepositry.GetLicenseIdByApplicationId(request.ApplicationId);

            if (LicenseId == 0)
                return Result.Fail("No License Issued with this application");

            return Result.Ok(LicenseId);
        }
        
    }
}
