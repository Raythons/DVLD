using DLVD.App.Features.Common;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.TestAppointments.Quries.GetTestAppointment
{
    public class GetTestAppointmentRequest: 
        IRequest<Result<PagedList<GetTestAppointmentListResponse>>>
    {
        public int LocalDrivvingLicneseApplicationId { get; set; }
        public int TestTypeId { get; set; }

        public GetTestAppointmentRequest(){ }
        public GetTestAppointmentRequest(int localDrivvingLicneseApplicationId, int tetsTypeId)
        {
            LocalDrivvingLicneseApplicationId = localDrivvingLicneseApplicationId;
            TestTypeId = tetsTypeId;
        }
    }
}
