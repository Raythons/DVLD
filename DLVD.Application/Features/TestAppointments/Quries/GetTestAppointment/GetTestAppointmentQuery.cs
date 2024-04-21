using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.TestAppointments.Quries.GetTestAppointment
{
    public class GetTestAppointmentQuery: IRequest<Result<TestAppointmentDto>>
    {
        public int Id { get; set; }

        GetTestAppointmentQuery(){ }
        GetTestAppointmentQuery(int id)
        {
            Id = id;
        }
    }
}
