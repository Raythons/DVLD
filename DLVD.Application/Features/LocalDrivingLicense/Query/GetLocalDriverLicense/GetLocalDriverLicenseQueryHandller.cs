using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDriverLicense
{
    public class GetLocalDriverLicenseQueryHandller : BaseHandler,
        IRequestHandler<GetLocalDriverLicenseQuery, Result<GetLocalDrivvingLicenseDto>>
    {
        public GetLocalDriverLicenseQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetLocalDrivvingLicenseDto>> Handle(
            GetLocalDriverLicenseQuery request,
            CancellationToken cancellationToken)
        {
            var LocalDrivvingLicenseApp = await _unitOfWork
                                            .LocalDrivingLicenseApplicationRepositry
                                            .GetById(request.Id);

            if (LocalDrivvingLicenseApp is null)
                return Result.Fail("Local DrivvingLicense App Not Found");


            var LocalDrivvingLicenseAppDto = _mapper.
                                                Map<GetLocalDrivvingLicenseDto>(LocalDrivvingLicenseApp);


            return LocalDrivvingLicenseAppDto;
            
        }
    }
}
