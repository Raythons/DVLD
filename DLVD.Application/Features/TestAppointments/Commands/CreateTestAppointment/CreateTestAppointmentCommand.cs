using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment
{
    public class CreateTestAppointmentCommand : IRequest<Result<bool>>
    {
        public int TestTypeId { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
        public int PersonId { get; set; }
        public EnStatus Status { get; } = EnStatus.New;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime LastStatus { get; } = DateTime.Now;


        public CreateTestAppointmentCommand() { }

        public CreateTestAppointmentCommand(
            int testTypeId,
            int localDrivingLicenseApplicationId,
            DateTime appointmentDate,
            float paidFees,
            int createdByUserId)
        {
            TestTypeId = testTypeId;
            LocalDrivingLicenseApplicationId = localDrivingLicenseApplicationId;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserId = createdByUserId;
        }
    }
}
