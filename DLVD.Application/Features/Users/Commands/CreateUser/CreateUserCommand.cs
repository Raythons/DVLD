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
    
    public record CreateUserCommand(
                        int PersonId,
                        string UserName,
                        string Password) : IRequest<Result<bool>>
    {

    }
}
