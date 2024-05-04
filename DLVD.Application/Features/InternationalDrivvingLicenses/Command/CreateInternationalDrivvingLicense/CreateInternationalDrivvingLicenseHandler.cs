using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.InternationalDrivvingLicenses.Command.CreateInternationalDrivvingLicense
{
    public class CreateInternationalDrivvingLicenseHandler : BaseHandler,
        IRequestHandler<CreateInternationalDrivvingLicenseRequest, Result<bool>>
    {
        public CreateInternationalDrivvingLicenseHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }


        public  async Task<Result<bool>> Handle(
            CreateInternationalDrivvingLicenseRequest request,
            CancellationToken cancellationToken)
        {

            if (!await SatisfiesRequirements(request.IssueUsingLocalDrivingLicenseId))
                Result.Fail("Either The License Is InActive Or Its Expired Please Check It");

            var applicationToCreate = _mapper.Map<Application>(request.CreateApplicationCommand);

            await _unitOfWork.CompleteAsync();

            var res = new Result<bool>();
            // Magic Number Should Be Refactored Later
            if ((request.ApplicationId = await CreateApplication(applicationToCreate)) == 0)
                return res.WithError("Something Went Worng While Creating The Application ");

            var InterNationalLicenseToCreate = _mapper.Map<InternationalDrivingLicense>(request);

            var isSucess = await _unitOfWork
                                    .InternationalDrivingLicenseRepositry
                                    .Add(InterNationalLicenseToCreate);

            if (!isSucess)
                return Result.Fail("").WithError("Something Went Worng While Creating The InterNational License");
            

            await _unitOfWork.CompleteAsync();

            return res.WithSuccess("InterNationalDrivvingLicense Created Succefully");

        }
        // 0 Means It Failed
        private async Task<int> CreateApplication(Application application)
        {
            bool isSucess = await _unitOfWork.
                                        ApplicationRepositry
                                       .Add(application);
            return isSucess ? application.Id : 0;
        }
        private async Task <bool> SatisfiesRequirements(int licenseId)
        {

            return  await HasActiveInternationalLicense(licenseId) && ! await DidLicenseExpired(licenseId);

        }

        private async Task<bool> DidLicenseExpired(int LicenseId)
        {
            var ExpirationDate =  await _unitOfWork.LicenseRepositry.GetExpirationDate(LicenseId);

            return ExpirationDate < DateTime.UtcNow;
        }

        private async Task<bool> HasActiveInternationalLicense(int LicenseId)
        {
            return await _unitOfWork.InternationalDrivingLicenseRepositry
                                .HasActiveInternationaLicense(LicenseId);
        }
    }
}
