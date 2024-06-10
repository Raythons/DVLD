using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.AuthenticateUserCommand
{
    public class AuthenticateUserCommand: IRequest<Result<AuthenticateUserResponse>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        public AuthenticateUserCommand() { }
        public AuthenticateUserCommand(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
