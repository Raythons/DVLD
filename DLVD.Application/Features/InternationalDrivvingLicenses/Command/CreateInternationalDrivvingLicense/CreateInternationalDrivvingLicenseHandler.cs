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
        private readonly IMediator _mediator;
        public CreateInternationalDrivvingLicenseHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IMediator mediator) : base(unitOfWork, mapper)
        {
            _mediator = mediator;
        }


        public  async Task<Result<bool>> Handle(
            CreateInternationalDrivvingLicenseRequest request,
            CancellationToken cancellationToken)
        {
            var result = await SatisfiesRequirements(request.LicenseId , request.DriverId);
            if (result.IsFailed)
                return result;


            using var transaction = await _unitOfWork.StartTrancation();
            try
            {

                var applicationToCreate = _mapper.Map<Application>(request);
                applicationToCreate.PersonId = await _unitOfWork.DriverRepository.GetPersonId(request.DriverId);
                await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);

                await _unitOfWork.CompleteAsync();
                request.ApplicationId = applicationToCreate.Id;

                var LicenseToCreate = _mapper.Map<InternationalDrivingLicense>(request);
                LicenseToCreate.IssueUsingLocalDrivingLicenseId = request.LicenseId;

                var IssueResult = await _unitOfWork.InternationalDrivingLicenseRepositry
                                        .Add(LicenseToCreate);

                await _unitOfWork.CompleteAsync();

                await _unitOfWork.CommitTrancation();
                if (!IssueResult)
                    return Result.Fail("Couldnt Create the InterNationalLicense Something Went Wrong");

                return Result.Ok(true);
            }
            catch (Exception e)
            {
                // Logger System TO Do
                Console.WriteLine(e);
                transaction.Rollback();
                throw;
            }
        }
     
        private async Task<Result<bool> >SatisfiesRequirements(int licenseId, int driverId)
        {
            if (await AlreadyHaveInternatonalLicense(driverId))
                return Result.Fail("Driver Already Have International License");
            if (await HasActiveInternationalLicense(licenseId))
                return Result.Fail("There is Already  An Active InternationalLicense connected With current License}");
            if (await DidLicenseExpired(licenseId))
                return Result.Fail("License Expired Please Re-new It");

            return Result.Ok();
        }
        private async Task<bool> AlreadyHaveInternatonalLicense(int driverId)
        {
            return await _unitOfWork.InternationalDrivingLicenseRepositry
                                .HaveInternationalLicense(driverId);
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
