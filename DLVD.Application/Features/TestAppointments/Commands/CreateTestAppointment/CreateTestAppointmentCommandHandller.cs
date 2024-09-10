using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment
{

    public class CreateTestAppointmentCommandHandller : BaseHandler,
        IRequestHandler<CreateTestAppointmentCommand, Result<bool>>
    {
        public CreateTestAppointmentCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            CreateTestAppointmentCommand request,
            CancellationToken cancellationToken)
        {
            var LastTestResult = await _unitOfWork.TestRepositry
                    .LastTestTypeResult(request.LocalDrivingLicenseApplicationId, request.TestTypeId);

            if (LastTestResult == DVLD.Domain.EnTestResult.Fail)
                  CreateRetakeApplication(_mapper.Map<Application>(request));

            var testAppointment = _mapper.Map<TestAppointment>(request);

            var isTestAppointmentAdded = await _unitOfWork.TestAppointmentRepositry
                .Add(testAppointment);

            if (!isTestAppointmentAdded)
                return Result.Fail("SomeThing Went Wrong");

            await _unitOfWork.CompleteAsync();

            return Result.Ok(isTestAppointmentAdded);    
        }
        private async void CreateRetakeApplication(Application applicationToCreate)
        {
            await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);
        }
      

        
    }
}
