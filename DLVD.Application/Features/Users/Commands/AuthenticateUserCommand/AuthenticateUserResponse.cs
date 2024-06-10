

using DVLD.Domain.Entities;

namespace DLVD.App.Features.Users.Commands.AuthenticateUserCommand
{
    public class AuthenticateUserResponse
    {
        public string UserName { get; set; }
        public int Id { get; set; }
        public string Image { get; set; }

        public AuthenticateUserResponse() { }

        public AuthenticateUserResponse(string userName, int id)
        {
            UserName = userName;
            Id = id;
        }
        public AuthenticateUserResponse(string userName,int id, string image)
        {
            UserName = userName;
            Image = image;
            Id = id;
        }
    }
}
