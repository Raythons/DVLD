using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.DetainLicense
{
    public  class DetainLicenseCommandHandler : BaseHandler , 
        IRequestHandler<DetainLicenseRequest, Result<DetainLicenseResponse>>
    {
        public DetainLicenseCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<DetainLicenseResponse>> Handle(
            DetainLicenseRequest request,
            CancellationToken cancellationToken)
        {
            var SatisfyRulesResult = await ValidLicenseToDetain(request.LicenseId);


            if (SatisfyRulesResult.IsFailed)
                return Result.Fail(SatisfyRulesResult.Errors);


            var LicenseToDetain = _mapper.Map<DetainedLicense>(request);

            await _unitOfWork.DetainedLicenseRepositry.Add(LicenseToDetain);
            await DeActivateLicense(request.LicenseId);


            await _unitOfWork.CompleteAsync();
            var response = new DetainLicenseResponse(LicenseToDetain.Id);

            return Result.Ok(response);
        }

        private async Task<Result<bool>> ValidLicenseToDetain(int LicenseIdToDetain)
        {
            var res = new Result<bool>();

            var IsActive = await IsActiveLicense(LicenseIdToDetain);

            if (!IsActive)
                res.WithError("Cannot Detain DeActivated License");

            var IsDetained = await _unitOfWork.LicenseRepositry.IsLicenseDetained(LicenseIdToDetain);

            if (!IsDetained)
                res.WithError("License Already Detained");

            return res;
        }
        private async Task<Result<bool>> isLicenseDetained(int LicenseIdToDetain)
        {
            return await _unitOfWork.LicenseRepositry.IsLicenseDetained(LicenseIdToDetain);
        }


        private async Task<bool> IsActiveLicense(int previousLicenseId)
        {
            return await _unitOfWork.LicenseRepositry.IsActiveLicense(previousLicenseId);
        }

        private async Task DeActivateLicense(int previousLicenseId)
        {
            await _unitOfWork.LicenseRepositry.DeActivateLicense(previousLicenseId);
        }


    }
}

