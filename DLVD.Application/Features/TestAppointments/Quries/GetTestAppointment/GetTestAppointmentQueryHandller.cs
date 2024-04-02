using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
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
        IRequestHandler<GetTestAppointmentQuery, Result<TestAppointmentDto>>
    {
        public GetTestAppointmentQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<TestAppointmentDto>> Handle(GetTestAppointmentQuery request,
            CancellationToken cancellationToken)
        {

            var testAppointment = _unitOfWork.TestAppointmentRepositry.GetById(request.Id);

            if (testAppointment is null)
                return Result.Fail("Test Not Found");

            
            var testAppointmentDto = _mapper.Map<TestAppointmentDto>(testAppointment);



            return Result.Ok(testAppointmentDto);
        }
    }
}
