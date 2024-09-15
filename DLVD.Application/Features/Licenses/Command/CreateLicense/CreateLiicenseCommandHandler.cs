using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Command.CreateLicense
{

    public class CreateLicenseCommandHandler : BaseHandler,
        IRequestHandler<CreateLicenseCommand, Result<bool>>
    {
        
        public CreateLicenseCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<bool>> Handle(CreateLicenseCommand request, 
            CancellationToken cancellationToken)
        {
            
            if (!await HasPassedAllTests(request.LocalDrivingLicenseApplicationId))
                return Result.Fail("The Person Didnt Passed All Of The Tests Required");
   
            
            await _unitOfWork.StartTrancation();
            using var transaction = await _unitOfWork.StartTrancation();
            try
            {
                
                request.DriverId = await HandleGetDriverId(request.PersonId , request.CreatedByUserId);
                var ApplicationCreationHelper =  new StHandleApplicationCreation
                                                        (
                                                         request.ApplicationTypeId,
                                                         request.PaidFees,
                                                         request.PersonId, 
                                                         request.CreatedByUserId
                                                        );
           
                request.ApplicationId = await  HandleApplicationCreation(ApplicationCreationHelper);
                request.LicenseClassId = await _unitOfWork.LocalDrivingLicenseApplicationRepositry
                                                        .GetLicenseClassId(request.LocalDrivingLicenseApplicationId);

                request.ExpirationDate = await CalculateExpirationDate(request.LicenseClassId);

                var LicenseToCreate = _mapper.Map<DVLD.Domain.Entities.License>(request);
                var isCreated = await _unitOfWork.LicenseRepositry.Add(LicenseToCreate);

                if (!isCreated)
                    Result.Fail("Something Went Wrong");
                await _unitOfWork.CompleteAsync();

                await _unitOfWork.CommitTrancation();             

                return Result.Ok();
            }
            catch  (Exception ex) 
            {
                // TODO ADD  LOGGER AND Email Service SYSTEM
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Falied To Create The License Please CALL The Developers " );
            }
        }

        private async Task<int> HandleApplicationCreation(StHandleApplicationCreation applicationCreationFileds)
        {
            var applicationToCreate = _mapper.Map<Application>(applicationCreationFileds);
            await _unitOfWork.CompleteAsync();
            return applicationToCreate.Id;
        }

        private async Task<int> HandleGetDriverId(int personId, int createdByUserId)
        {
            var DriverId = await _unitOfWork.DriverRepository.GetIdByPersonId(personId);
            if (DriverId == -1)
                return await CreateDriverAndGetId(personId, createdByUserId);

            return DriverId;
        }

        private async Task<int> CreateDriverAndGetId(int personId, int createdByUserId)
        {
            Driver driverToCreate = new Driver() { PersonId = personId , CreatedByUserId = createdByUserId, CreatedAt = DateTime.Now};
            
            var createdSuccesfully = await _unitOfWork.DriverRepository.Add(driverToCreate);

            await _unitOfWork.CompleteAsync();

            return driverToCreate.Id;
        }

        private async Task<DateTime> CalculateExpirationDate(int licenseClassId)
        {
            int expirationYears =  await _unitOfWork
                            .LicenseClassRepositry
                            .GetClassExpirationYears(licenseClassId);

            return DateTime.UtcNow.AddYears(expirationYears);
        }

        private async Task<bool> HasPassedAllTests(int localDrivingLicenseApplicationId)
        {

            return await _unitOfWork
                                     .LocalDrivingLicenseApplicationRepositry
                                     .HasPassedAllTests(localDrivingLicenseApplicationId);
        }
       
    }
}
