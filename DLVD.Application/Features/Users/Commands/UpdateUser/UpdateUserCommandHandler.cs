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

namespace DLVD.App.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : BaseHandler, IRequestHandler<UpdateUserCommand, Result<bool>>
    {
        public UpdateUserCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            User user = _mapper.Map<User>(request);

            bool isUpdated = await _unitOfWork.UserRepository.Update(user);

            if (isUpdated)
                await _unitOfWork.CompleteAsync();

            return Result.Ok(isUpdated);
        }
    }
}
