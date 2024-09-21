﻿using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Common;
using DLVD.App.Features.Licenses.Command.RenewLicense;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Command.ReplaceLicense
{
    public class ReplaceLicenseCommandHandller : BaseHandler,
        IRequestHandler<ReplaceLicenseRequest, Result<ReplaceLicenseResponse>>
    {
        private readonly IMediator _mediator;
        public ReplaceLicenseCommandHandller
            (IUnitOfWork unitOfWork,
            IMapper mapper,
            IMediator mediator  ) : base(unitOfWork, mapper)
        {
            _mediator = mediator;
        }

        public async Task<Result<ReplaceLicenseResponse>> Handle(
            ReplaceLicenseRequest request, 
            CancellationToken cancellationToken)
        {
            var SatisfyRulesResult = await ValidLicenseToReplace(request.PreviousLicenseId);


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
                request.IssueReason = request.ReplacementType.ToString();

                var LicenseToCreate = _mapper.Map<License>(request);

                await _unitOfWork.LicenseRepositry.Add(LicenseToCreate);
                await _unitOfWork.CompleteAsync();

                await DeActivedLicense(request.PreviousLicenseId);

                await _unitOfWork.CommitTrancation();               //await _unitOfWork.LocalDrivingLicenseApplicationRepositry.Add();

                var response = new ReplaceLicenseResponse(request.ApplicationId,
                                                     request.PreviousLicenseId,
                                                     LicenseToCreate.Id);
                return Result.Ok(response);

            }
            catch (Exception ex)
            {
                // TO DO LOGGER SYSTEM
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Falied To Create The Local Driving License Application");
            }

        }

        private async Task<Result<bool>> ValidLicenseToReplace(int previousLicenseId)
        {
            var res = new Result<bool>();


            var isExpired = await DidLicenseExpired(previousLicenseId);
            if (isExpired)
                res.WithError("Cannot Rplace UnExpired License");

            var IsActive = await IsActiveLicense(previousLicenseId);
            if (!IsActive)
                res.WithError("Cannot Replace DeActivated License");

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

        private async Task<int> CreateLicense(ReplaceLicenseRequest request)
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
            var ValidatityLengthInYears = await _unitOfWork
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

