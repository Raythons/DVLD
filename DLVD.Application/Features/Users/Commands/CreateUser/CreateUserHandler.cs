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

namespace DLVD.App.Features.Users.Commands.CreateUser
{
    public class CreateUserHandler : BaseHandler
            ,IRequestHandler<CreateUserCommand, Result<bool>>
    {
        public CreateUserHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        
        public async Task<Result<bool>> Handle(CreateUserCommand request, 
            CancellationToken cancellationToken)
        {

            var userToAdd =  _mapper.Map<User>(request);

            bool isAdded = await _unitOfWork.UserRepository.AddAsync(userToAdd);

            if (isAdded)    
                await _unitOfWork.CompleteAsync();

            return Result.Ok(isAdded);
        }
    }
}
