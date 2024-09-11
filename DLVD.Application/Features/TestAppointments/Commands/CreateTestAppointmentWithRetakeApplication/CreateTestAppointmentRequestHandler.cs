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
             return  await HandlePlan(request);
        }

        private async Task<Result<bool>> HandlePlan(CreateTestAppointmentRequest request)
        {
            if (request.ApplicationTypeId != null)
                 return  await CreateTestAppointmentWithRetakeApplication(request);
            else
                return await CreateTestAppointment(request);

        }

        private   async Task<Result<bool>> CreateTestAppointment(CreateTestAppointmentRequest request)
        {
            var testAppointmentToCreate = _mapper.Map<TestAppointment>(request);
            var result =  await _unitOfWork.TestAppointmentRepositry.Add(testAppointmentToCreate);

            if (!result)
                return Result.Fail("Failed To Create Test Appointment ");
            await _unitOfWork.CompleteAsync();
            return Result.Ok(result);
        }
        private async Task<Result<int>> CreateReTakeApplication(CreateTestAppointmentRequest application)
        {
            var applicationToCreate = _mapper.Map<Application>(application);
            await _unitOfWork.CompleteAsync();
            return applicationToCreate.Id;
        }

        private async  Task<Result<bool>> CreateTestAppointmentWithRetakeApplication(
            CreateTestAppointmentRequest request)
        {
            using var transaction = await _unitOfWork.StartTrancation();

            try
            {
                var applicationId = CreateReTakeApplication(request);

                var CreatedSuccessfully =  await CreateTestAppointment(request);

                await _unitOfWork.CommitTrancation();

                return CreatedSuccessfully;
            }
            catch (Exception ex)
            {
                // USE Logger Insted
                // TODO
                Console.WriteLine(ex.ToString());
                transaction.Rollback();
                return Result.Fail("Something  UnExpected Happened Please Contact With The Technical Team");
            }
        }
    }
}
