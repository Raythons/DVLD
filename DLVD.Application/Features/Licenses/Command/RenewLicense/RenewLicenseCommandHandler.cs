using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
            var isExpired = await DidLicenseExpired(request.PreviousLicenseId);

            if (!isExpired)
                return Result.Fail("Cannot Re-New UnExpired License");

            try
            {
                request.CreatedByApplicationId = await CreateApplication(request.CreateApplicationCommand);
            }
            catch (Exception e)
            {
                return Result.Fail("Coldnt Create Application To The License");
            }

            var CreatedLicenseId = await CreateLicense(request);



            var respopnse = new RenewLicenseResponse(request.CreatedByApplicationId,
                                                     request.PreviousLicenseId,
                                                     CreatedLicenseId);

            return Result.Ok(respopnse);

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
