using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.TestAppointments.Commands.UpdateTestAppointmentDate
{
    public class UpdateTestAppointmentDateCommand : IRequest<Result<bool>>
    {
        public UpdateTestAppointmentDateCommand(
            DateTime newDate,
            int testAppoinmentId)
        {
            NewDate = newDate;
            TestAppoinmentId = testAppoinmentId;
        }

        public DateTime NewDate { get; set; }

        public int TestAppoinmentId { get; set; }

    }
}
