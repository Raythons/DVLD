using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DLVD.App.Features.Licenses.Command.RenewLicense;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.ReleaseLicense
{
    public class ReleaseLicenseCommandHnadler : BaseHandler,
        IRequestHandler<ReleaseLicenseRequest , Result<int>>
    {
        private readonly IMediator _mediator;
        public ReleaseLicenseCommandHnadler
            (IUnitOfWork unitOfWork,
            IMapper mapper,
            IMediator mediator) : base(unitOfWork, mapper)
        {
            _mediator = mediator;
        }

        public async Task<Result<int>> Handle(
            ReleaseLicenseRequest request,
            CancellationToken cancellationToken)
        {

            var satisfyRulesResult = await ValidLicenseToRelease(request.LicenseId);

            if (satisfyRulesResult.IsFailed)
                return Result.Fail(satisfyRulesResult.Errors);

            using var transaction = await _unitOfWork.StartTrancation();
            try
            {
                request.DriverId = await _unitOfWork.LicenseRepositry.GetDriverIdByLicenseId(request.LicenseId);
                request.PersonId = await _unitOfWork.DriverRepository.GetPersonId(request.DriverId);
                var applicationToCreate = _mapper.Map<Application>(request);

                await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);

                await _unitOfWork.CompleteAsync();
                request.ApplicationId = applicationToCreate.Id;


                await _unitOfWork.DetainedLicenseRepositry.ReleaseLicense(request.LicenseId, request.CreatedByUserId);
                await _unitOfWork.CompleteAsync();
                await ActivateLicense(request.LicenseId);

                await _unitOfWork.CommitTrancation();               //await _unitOfWork.LocalDrivingLicenseApplicationRepositry.Add();

                
                return Result.Ok(applicationToCreate.Id);

            }
            catch (Exception ex)
            {
                // TO DO LOGGER SYSTEM
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Falied To Create The Local Driving License Application");
            }

  
        }

        private async Task<Result<bool>> ValidLicenseToRelease(int detainedLicenseId)
        {
            var res = new Result<bool>();
            var isDetained = await IsLicenseDetained(detainedLicenseId);
            if (!isDetained)
                res.WithError("This Liecnse Is Not Detained");       

            return res;

        }

        private async Task<bool> IsLicenseDetained(int detainedLicenseId)
        {
            return await _unitOfWork.DetainedLicenseRepositry.IsDetained(detainedLicenseId);
        }
        private async Task ActivateLicense(int licenseId)
        {
            await _unitOfWork.LicenseRepositry.ReActivateLicense(licenseId);
        }

        private async Task<int> CreateApplication(CreateApplicationCommand createApplicationCommand)
        {
            var res = await _mediator.Send(createApplicationCommand);
            if (res.IsSuccess)
                return res.Value;
            throw new Exception("Could Not Create Application");
        }


    }
}
