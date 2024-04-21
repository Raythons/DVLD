using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Tests.Command.CreateTestCommand
{
    public class CreateTestCommandHandller : BaseHandler,
        IRequestHandler<CreateTestCommand, Result<bool>>
    {
        public CreateTestCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(CreateTestCommand request,
            CancellationToken cancellationToken)
        {
            var testToCreate = _mapper.Map<Test>(request);

            var IsSucess = await _unitOfWork.TestRepositry.Add(testToCreate);

            await _unitOfWork.TestAppointmentRepositry
                             .LockTestAppoitnment(request.TestAppointmentId);

            if (!IsSucess)           
                return Result.Fail("Something Went Wrongs PleaseTry Later ");
           
            await _unitOfWork.CompleteAsync();

            return Result.Ok(true);
        }
    }
}
