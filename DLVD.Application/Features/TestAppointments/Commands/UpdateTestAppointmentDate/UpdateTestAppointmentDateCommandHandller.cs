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

namespace DLVD.App.Features.TestAppointments.Commands.UpdateTestAppointmentDate
{
    public class UpdateTestAppointmentDateCommandHandller : BaseHandler,
        IRequestHandler<UpdateTestAppointmentDateCommand, Result<bool>>
    {
        public UpdateTestAppointmentDateCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            UpdateTestAppointmentDateCommand request,
            CancellationToken cancellationToken)
        {

            var isUpdated = await _unitOfWork
                                    .TestAppointmentRepositry
                                    .UpdateDate(request.TestAppoinmentId, request.NewDate);

            if (!isUpdated)
                return Result.Fail("Couldnt Update The Test Appoitnemnt");

        }
    }
}
