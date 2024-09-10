using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentValidation;


namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment
{
    public class CreateTestAppointmentValidator:
        AbstractValidator<CreateTestAppointmentCommand>
    {
        private readonly ITestAppointmentRepositry _testAppointmentRepositry;
        private readonly ITestRepositry _testRepositry;

        public CreateTestAppointmentValidator(
            IUnitOfWork unitOfWork)
        {
            _testAppointmentRepositry = unitOfWork.TestAppointmentRepositry;
            _testRepositry = unitOfWork.TestRepositry;

            RuleFor(t => t.AppointmentDate)
                .GreaterThan(DateTime.Now);

            RuleFor(t => t.LocalDrivingLicenseApplicationId)
                .MustAsync(async (cmd, ldla ,c)=>await DidntPassedTheTest(cmd.TestTypeId,ldla,c))
                .WithMessage("Person Already Passed the tets cannot make An Apointment to It")

                .MustAsync(DontHaveActiveTest).WithMessage($"There Is Already An Active TestAppointment.");
        }

        private async Task<bool> DidntPassedTheTest(
            int testTypeId,
            int localDrivingLicenseApplicationId,       
            CancellationToken token
            )
        {
            var LastTestResult = await _testRepositry
              .LastTestTypeResult(localDrivingLicenseApplicationId, testTypeId);

            if (LastTestResult == DVLD.Domain.EnTestResult.Pass)
                return false;
            return true;
        }

        private async Task<bool> DontHaveActiveTest(int localDrivingLicenseApplicationId, 
            CancellationToken token)
        {
            bool hasActiveTest = await _testAppointmentRepositry
               .HasActiveTestAppointment(localDrivingLicenseApplicationId);

            return !hasActiveTest;
        }
        
    }
}
