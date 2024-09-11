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
    public class CreateTestAppointmentRequestHandler : BaseHandler,
        IRequestHandler<CreateTestAppointmentRequest, Result<bool>>
    {
        public CreateTestAppointmentRequestHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            CreateTestAppointmentRequest request,
            CancellationToken cancellationToken)
        {
            HandlePlan(request);

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

        private async static  Task<Result<bool>> HandlePlan(CreateTestAppointmentRequest request)
        {
            if (request.ApplicationTypeId == -1)
                 return  await CreateTestAppointmentWithRetakeApplication(request);
            
                return CreateTestAppointment(request);

        }

        private static Result<bool> CreateTestAppointment(CreateTestAppointmentRequest request)
        {
            throw new NotImplementedException();
        }

        private async  Task<Result<bool>> CreateTestAppointmentWithRetakeApplication(
            CreateTestAppointmentRequest request)
        {
            using var transaction = await _unitOfWork.StartTrancation();

            try
            {
                var applicationToCreate = _mapper.Map<Application>(request);


            }
            catch (Exception)
            {

                throw;
            }
            return Result.Ok();
        }
    }
}
