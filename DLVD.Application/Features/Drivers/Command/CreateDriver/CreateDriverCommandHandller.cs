using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Drivers.Command.CreateDriver
{
    public class CreateDriverCommandHandller : BaseHandler,
        IRequestHandler<CreateDriverCommand, Result<bool>>
    {
        public CreateDriverCommandHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(CreateDriverCommand request,
            CancellationToken cancellationToken)
        {
            var DriverToCreate = _mapper.Map<Driver>(request);

            var isAdded = await _unitOfWork.DriverRepository.Add(DriverToCreate);

            if (!isAdded)
                Result.Fail("SomeThing Went Wrong Try Again Later");

            await _unitOfWork.CompleteAsync();

            return Result.Ok(isAdded);
        }
    }
}
