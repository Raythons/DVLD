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

namespace DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment
{
    public class CreateTestAppointmentCommandHandller : BaseHandler,
        IRequestHandler<CreateTestAppointmentCommand, Result<bool>>
    {
        public CreateTestAppointmentCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            CreateTestAppointmentCommand request,
            CancellationToken cancellationToken)
        {
            var testAppointment = _mapper.Map<TestAppointment>(request);

            var isTestAdded = await _unitOfWork.TestAppointmentRepositry.Add(testAppointment);

            if (!isTestAdded)
                return Result.Fail("SomeThing Went Wrong");

            await _unitOfWork.CompleteAsync();

            return Result.Ok(isTestAdded);
        
        }
    }
}
