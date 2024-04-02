using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense
{
    public class CreateLocalDrivingLicenseCommandHandller : 
        BaseHandler,
        IRequestHandler<CreateLocalDrivingLicenseCommand, Result<int>>

    {
        public CreateLocalDrivingLicenseCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<int>> Handle(CreateLocalDrivingLicenseCommand request,
            CancellationToken cancellationToken)
        {


                                    
            var localLicenseApplication = _mapper
                                            .Map<LocalDrivingLicenseApplication>(request);

            bool isSuccess = await _unitOfWork
                                        .LocalDrivingLicenseApplicationRepositry
                                        .Add(localLicenseApplication);

            if (!isSuccess)
                return Result.Fail("Falied To Create The Local Driving License Application");

            await _unitOfWork.CompleteAsync();

            return Result.Ok(localLicenseApplication.Id);
            
        }
    }
}
