using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using License = DVLD.Domain.Entities.License;

namespace DLVD.App.Features.Licenses.Command.RenewLicense
{
    public class RenewLicenseCommandHandler : BaseHandler,
        IRequestHandler<RenewLicenseRerquest, Result<RenewLicenseResponse>>
    {
        readonly IMediator _mediator;
        public RenewLicenseCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper,
            IMediator mediator) : base(unitOfWork, mapper)
        {
            _mediator = mediator;
        }

        public async Task<Result<RenewLicenseResponse>> Handle(
            RenewLicenseRerquest request,
            CancellationToken cancellationToken)
        {
            var SatisfyRulesResult = await ValidLicenseToRenew(request.PreviousLicenseId);

            if (SatisfyRulesResult.IsFailed)
                return Result.Fail(SatisfyRulesResult.Errors);

            using var transaction = await _unitOfWork.StartTrancation();
            try
            {
                request.DriverId = await _unitOfWork.LicenseRepositry.GetDriverIdByLicenseId(request.PreviousLicenseId);
                request.PersonId = await _unitOfWork.DriverRepository.GetPersonId(request.DriverId);
                var applicationToCreate = _mapper.Map<Application>(request);

                await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);

                await _unitOfWork.CompleteAsync();
                request.ApplicationId = applicationToCreate.Id;
                request.LicenseClassId = await _unitOfWork.LicenseRepositry.GetLicenseClassId(request.PreviousLicenseId);
                request.ExpirationDate = await GetExpirationDate(request.LicenseClassId);


                var LicenseToCreate = _mapper.Map<License>(request);

                await _unitOfWork.LicenseRepositry.Add(LicenseToCreate);
                await _unitOfWork.CompleteAsync();

                await DeActivedLicense(request.PreviousLicenseId);

                await _unitOfWork.CommitTrancation();               //await _unitOfWork.LocalDrivingLicenseApplicationRepositry.Add();

                var respopnse = new RenewLicenseResponse(request.ApplicationId,
                                                     request.PreviousLicenseId,
                                                     LicenseToCreate.Id);
                return Result.Ok(respopnse);

            }
            catch (Exception ex)
            {
                // TO DO LOGGER SYSTEM
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Falied To Create The Local Driving License Application");
            }
        }

        private async Task<Result<bool>> ValidLicenseToRenew(int previousLicenseId)
        {
            var res = new Result<bool>();
            var isExpired = await DidLicenseExpired(previousLicenseId);
            if (!isExpired)
                res.WithError("Cannot Re-New UnExpired License");

            var IsActive = await IsActiveLicense(previousLicenseId);
            if (!IsActive)
                res.WithError("Cannot ReNew DeActivated License");

            return res;
           
        }

        private async Task<bool> IsActiveLicense(int previousLicenseId)
        {
            return await _unitOfWork.LicenseRepositry.IsActiveLicense(previousLicenseId);
        }

        private async Task DeActivedLicense(int previousLicenseId)
        {
            await _unitOfWork.LicenseRepositry.DeActivateLicense(previousLicenseId);
        }

        private async Task<int> CreateLicense(RenewLicenseRerquest request)
        {      
            var LicenseToCreate = _mapper.Map<License>(request);
            
            var isSuccess = await _unitOfWork.LicenseRepositry.Add(LicenseToCreate);
            if (!isSuccess)
                throw new Exception("Couldnt Add The License");

            await _unitOfWork.CompleteAsync();
                
            return LicenseToCreate.Id;
        }

        private async Task<DateTime> GetExpirationDate(int licenseClassId)
        {
            var ValidatityLengthInYears =  await _unitOfWork
                                                    .LicenseClassRepositry
                                                    .GetClassExpirationYears(licenseClassId);

            var ExpirationDate = DateTime.UtcNow.AddYears(ValidatityLengthInYears);

            return ExpirationDate;
        }

        private async Task<int> CreateApplication(CreateApplicationCommand createApplicationCommand)
        {
            var res = await _mediator.Send(createApplicationCommand);
            if (res.IsSuccess)
                return res.Value;
           throw new Exception("Could Not Create Application");
        }

        private async Task<bool> DidLicenseExpired(int LicenseId)
        {
            var ExpirationDate = await _unitOfWork.LicenseRepositry.GetExpirationDate(LicenseId);

            return ExpirationDate < DateTime.UtcNow;
        }

    }
}
