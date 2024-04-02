using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.AuthenticateUserCommand
{
    public class AuthenticateUserDto
    {
        public string UserName { get; set; }
        public int Id { get; set; }

        public AuthenticateUserDto() { }

        public AuthenticateUserDto(string userName,  int id)
        {
            UserName = userName;
            Id = id;
        }
    }
}
