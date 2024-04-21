using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.AuthenticateUserCommand
{
    public class AuthenticateUserCommand: IRequest<Result<AuthenticateUserDto>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }

        public AuthenticateUserCommand() { }
        public AuthenticateUserCommand(string userName, string password, int userId)
        {
            UserName = userName;
            Password = password;
            Id = userId;
        }
    }
}
