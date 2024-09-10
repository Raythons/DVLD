using DVLD.Domain.Entities;
using DVLD.Domain.Enums;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointmentWithNewApplication
{
    public class CreateTestAppointmentWithNewApplicationCommand: IRequest<Result<bool>>
    {
        public int TestTypeId { get; set; }
        public int? ApplicationTypeId { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        public int? LicenseClassId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserId { get; set; }
        public int? PersonId { get; set; }
        public EnStatus Status { get; } = EnStatus.New;
        public DateTime CreatedAt { get; } = DateTime.Now;
        public DateTime LastStatus { get; } = DateTime.Now;


        public CreateTestAppointmentWithNewApplicationCommand(
         int testTypeId, int applicationTypeId,
         int localDrivingLicenseApplicationId,
         int licenseClassId, DateTime appointmentDate, float paidFees,
         int createdByUserId, int personId)
        {
            TestTypeId = testTypeId;
            ApplicationTypeId = applicationTypeId;
            LocalDrivingLicenseApplicationId = localDrivingLicenseApplicationId;
            LicenseClassId = licenseClassId;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserId = createdByUserId;
            PersonId = personId;
        }
    }
}
