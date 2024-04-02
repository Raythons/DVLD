using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment
{
    public class CreateTestAppointmentCommand : IRequest<Result<bool>>
    {

        public int TestTypeId { get; set; }
        public int LocalDrivingLicenseApplicationId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserId { get; set; }


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
