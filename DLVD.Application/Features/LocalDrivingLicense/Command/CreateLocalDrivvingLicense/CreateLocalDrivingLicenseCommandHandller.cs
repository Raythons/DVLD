using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense
{
    public class CreateLocalDrivingLicenseCommandHandller : 
        BaseHandler,
        IRequestHandler<CreateLocalDrivingLicenseCommand, Result<int>>

    {
        public CreateLocalDrivingLicenseCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<int>> Handle(CreateLocalDrivingLicenseCommand request,
            CancellationToken cancellationToken)
        {


           var personApplications = await _unitOfWork
                                           .ApplicationRepositry
                                          .GetPersonLocalApplicationsOfLicenseClass(request.PersonId, request.LicenseClassId);

            if (personApplications is not null)
            {
                return Result.Fail($"Person Of Id {request.PersonId} Alreayd have request of " +
                    $"The smae license class Try Another Class And The ApplicationId Is: {personApplications.Id} ");
            }

            using var transaction = await _unitOfWork.StartTrancation();
            try
            {
                var applicationToCreate = _mapper.Map<Application>(request);
                await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);

                await _unitOfWork.CompleteAsync();

                var LocalDrivvingLicenseApplication = new LocalDrivingLicenseApplication()
                {
                    ApplicationId = applicationToCreate.Id,
                    LicenseClassId = request.LicenseClassId
                };
                await _unitOfWork.LocalDrivingLicenseApplicationRepositry.Add(LocalDrivvingLicenseApplication);
                await _unitOfWork.CompleteAsync();

                await _unitOfWork.CommitTrancation();               //await _unitOfWork.LocalDrivingLicenseApplicationRepositry.Add();

                return Result.Ok(LocalDrivvingLicenseApplication.Id);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Falied To Create The Local Driving License Application");
            }

        }
    }
}
