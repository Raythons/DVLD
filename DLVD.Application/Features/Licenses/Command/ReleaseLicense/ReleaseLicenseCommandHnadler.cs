using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
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

            int releaseApplicationId;
            try
            {
                releaseApplicationId = await CreateApplication(request.CreateApplicationCommand);
            }
            catch (Exception e)
            {
                return Result.Fail("couldn't Create Application To The License");
            }

            await ActivateLicense(request.LicenseId);

            return Result.Ok(releaseApplicationId);

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
        private async Task ActivateLicense(int previousLicenseId)
        {
            await _unitOfWork.LicenseRepositry.DeActivateLicense(previousLicenseId);
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
