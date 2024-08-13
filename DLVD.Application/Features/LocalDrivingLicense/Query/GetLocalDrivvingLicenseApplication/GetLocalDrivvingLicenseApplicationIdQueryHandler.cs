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

namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDrivvingLicenseApplication
{
    public class GetLocalDrivvingLicenseApplicationIdQueryHandler : BaseHandler,
        IRequestHandler<GetLocalDrivvingLicenseApplicationIdResquest,Result<int>>
    {
        public GetLocalDrivvingLicenseApplicationIdQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<int>> Handle(
            GetLocalDrivvingLicenseApplicationIdResquest request,
            CancellationToken cancellationToken)
        {
            return Result.Ok( await _unitOfWork.LocalDrivingLicenseApplicationRepositry
                 .GetApplicationId(request.LocalDrivvingLicneseApplicationId));
        }
    }
}
