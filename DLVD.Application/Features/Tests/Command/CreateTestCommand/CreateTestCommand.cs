using DVLD.Domain;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Tests.Command.CreateTestCommand
{
    public class CreateTestCommand : IRequest<Result<bool>>
    {
        public int TestAppointmentId { get; set; }
        public EnTestResult TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserId { get; set; } 
        
        public CreateTestCommand() { }

        public CreateTestCommand
            (int testAppointmentId,
            EnTestResult testResult,
            string notes,
            int createdByUserId)
        {
            TestAppointmentId = testAppointmentId;
            TestResult = testResult;
            Notes = notes;
            CreatedByUserId = createdByUserId;
        }
    }
}
