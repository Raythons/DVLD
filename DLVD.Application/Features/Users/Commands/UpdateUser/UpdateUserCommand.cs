using DLVD.App.Features.Persons.Commands.UpdatePerson;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.UpdateUser
{
    public  class UpdateUserCommand : IRequest<Result<bool>>
    {
         public int Id { get; set; }
         public string UserName { get; set; }
         public string Password { get; set; }

        public UpdateUserCommand() { }

        public UpdateUserCommand(
            int id,
            string userName,
            string password
            )
        {
            Id = id;
            UserName = userName;
            Password = password;
        }

        
    }
}
