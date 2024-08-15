using DLVD.App.Features.Common;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.TestAppointments.Quries.GetTestAppointment
{
   public class GetTestAppointmentListResponse
    {
        public int AppointmentId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public float PaidFees { get; set; }
        public bool IsLocked { get; set; }
    }

}