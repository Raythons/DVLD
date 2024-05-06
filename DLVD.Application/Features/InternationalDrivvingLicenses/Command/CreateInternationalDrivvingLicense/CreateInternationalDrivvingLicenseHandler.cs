using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
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
            if (!await SatisfiesRequirements(request.IssueUsingLocalDrivingLicenseId))
                Result.Fail("Either The License Is InActive Or Its Expired Please Check It");


            // override default value 
            request.CreateApplicationCommand.Status = EnStatus.Completed;
            var applicationIdResult = await _mediator.Send(request.CreateApplicationCommand, cancellationToken);

            if (applicationIdResult.IsFailed)
                return Result.Fail("Something Went Wrong");


            request.ApplicationId = applicationIdResult.Value;

            var InterNationalLicenseToCreate = _mapper.Map<InternationalDrivingLicense>(request);

            var isSucess = await _unitOfWork
                                    .InternationalDrivingLicenseRepositry
                                    .Add(InterNationalLicenseToCreate);

            if (!isSucess)
                return Result.Fail("").WithError("Something Went Worng While Creating The InterNational License");
            

            await _unitOfWork.CompleteAsync();

            return Result.Ok(true).WithSuccess("InterNationalDrivvingLicense Created Succefully");

        }
     
        private async Task <bool> SatisfiesRequirements(int licenseId)
        {

            return  !(await HasActiveInternationalLicense(licenseId)) && ! (await DidLicenseExpired(licenseId) );

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
