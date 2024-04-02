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

namespace DLVD.App.Features.Users.Commands.AuthenticateUserCommand
{
    public class AuthenticateUserCommandHandler : BaseHandler, 
        IRequestHandler<AuthenticateUserCommand, Result<AuthenticateUserDto>>
    {
        public AuthenticateUserCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        
        public async Task<Result<AuthenticateUserDto>> Handle(
            AuthenticateUserCommand request,
            CancellationToken cancellationToken)
        {
            var user = await _unitOfWork.UserRepository.GetById(request.Id);

            if (user is null)
                  return new Result().WithError("User Not Found");

            if (!user.IsActive)
                return new Result().WithError("The User Is DeActivated");

            if (user.Password != request.Password)
                return new Result().WithError("UserName Or Password Wrong");

            var res = _mapper.Map<AuthenticateUserDto>(user);

            return Result.Ok(res);
        }
    }
}
