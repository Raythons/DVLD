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

namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointmentWithNewApplication
{
    public class CreateTestAppointmentWithNewApplicationHandler : BaseHandler,
        IRequestHandler<CreateTestAppointmentWithNewApplicationCommand, Result<bool>>
    {
        public CreateTestAppointmentWithNewApplicationHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            CreateTestAppointmentWithNewApplicationCommand request,
            CancellationToken cancellationToken)
        {
            var applicationToCreate = _mapper.Map<Application>(request);

            var isApplicationAdd = await _unitOfWork.ApplicationRepositry.Add(applicationToCreate);
            if (!isApplicationAdd)
                return Result.Fail("Could Noit Crate ReTake Application");

            var testAppointmentToCreate = _mapper.Map<TestAppointment>(request);


            var isAppointmentAdded = await _unitOfWork.TestAppointmentRepositry
                    .Add(testAppointmentToCreate);

            if (!isAppointmentAdded)
                return Result.Fail("Could Not Crate testAppointment Application");


            return true;
        }
    }
}
