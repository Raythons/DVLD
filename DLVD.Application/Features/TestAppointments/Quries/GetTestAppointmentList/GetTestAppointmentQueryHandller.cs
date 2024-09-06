using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.TestAppointments.Quries.GetTestAppointment
{
    public class GetTestAppointmentQueryHandller : BaseHandler,
        IRequestHandler<GetTestAppointmentRequest, Result<PagedList<GetTestAppointmentListResponse>>>
    {
        public GetTestAppointmentQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<GetTestAppointmentListResponse>>> Handle(
            GetTestAppointmentRequest request, CancellationToken cancellationToken)
        {
            
            var testAppointment =  await _unitOfWork.TestAppointmentRepositry
                                                .GetAllByProjectionAsync<GetTestAppointmentListResponse>
                                                 (
                                                      s => new ()
                                                      {
                                                          AppointmentId = s.Id,
                                                          AppointmentDate = s.AppointmentDate,
                                                          IsLocked = s.IsLocked,
                                                          PaidFees = s.PaidFees,
                                                      },
                                                      x => x.TestTypeId == request.TestTypeId &&
                                                           x.LocalDrivingLicenseApplicationId == request.LocalDrivingLicenseApplicationId,

                                                    x => x.AppointmentDate
                                                 );

            if (testAppointment is null)
                return Result.Fail("Test Not Found");
            return Result.Ok(testAppointment);
        }
    }
}
