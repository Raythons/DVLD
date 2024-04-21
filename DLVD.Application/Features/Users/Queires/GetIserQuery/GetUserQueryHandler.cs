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

namespace DLVD.App.Features.Users.Queires.GetUserQuery
{
    public class GetUserQueryHandler : BaseHandler,  
        IRequestHandler<GetUserQuery, Result<GetUserDto>>
    {
        public GetUserQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<GetUserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            User? user =  await _unitOfWork.UserRepository.GetById(request.Id);

           var UserDto =   _mapper.Map<GetUserDto>(user);
           
            return Result.Ok(UserDto);
           
        }
    }
}
