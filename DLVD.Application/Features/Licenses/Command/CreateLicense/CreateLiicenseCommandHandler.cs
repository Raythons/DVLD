using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.CreateLicense
{

    public class CreateLicenseCommandHandler : BaseHandler,
        IRequestHandler<CreateLicenseCommand, Result<bool>>
    {
        public CreateLicenseCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<bool>> Handle(CreateLicenseCommand request, 
            CancellationToken cancellationToken)
        {

            if (!await HasPassedAllTests(request.LocalDrivingLicenseApplicationId))
                return Result.Fail("The Person Didnt Passed All Of The Tests Required");

            var LicenseToCreate = _mapper.Map<DVLD.Domain.Entities.License>(request);


            LicenseToCreate.ExpirationDate = await CalculateExpirationDate(request.LicenseClassId);

            var isCreated = await _unitOfWork.LicenseRepositry.Add(LicenseToCreate);         

            if (!isCreated)
                Result.Fail("Something Went Wrong");

            await _unitOfWork.ApplicationRepositry
                                .UpdateStatus(request.ApplicationId, EnStatus.Completed);

            await _unitOfWork.CompleteAsync();

            return Result.Ok(true);
        }

        private async Task<DateTime> CalculateExpirationDate(int licenseClassId)
        {
            int expirationYears =  await _unitOfWork
                            .LicenseClassRepositry
                            .GetClassExpirationYears(licenseClassId);

            return DateTime.UtcNow.AddYears(expirationYears);
        }

        private async Task<bool> HasPassedAllTests(int localDrivingLicenseApplicationId)
        {

            return await _unitOfWork
                                     .LocalDrivingLicenseApplicationRepositry
                                     .HasPassedAllTests(localDrivingLicenseApplicationId);
        }



    }
}
