using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Users.Commands.CreateRefreshToken
{
    public class CreateRefreshTokenCommandHandler : BaseHandler,
        IRequestHandler<CreateRefreshTokenCommand,
        Result<bool>>
    {
        public CreateRefreshTokenCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(
            CreateRefreshTokenCommand request, CancellationToken cancellationToken)
        {      
            var result = await _unitOfWork.RefreshTokenRepositry.AddAsync(request.RefreshToken);

            if (result  == false)
                return Result.Fail("SomethingWentWrong");

            await _unitOfWork.CompleteAsync();
            return Result.Ok(true);
        }
    }
}
