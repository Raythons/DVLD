using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Commands.CreateRefreshToken
{
    public class CreateRefreshTokenCommand: IRequest<Result<bool>>
    {
        public RefreshToken RefreshToken;
        public CreateRefreshTokenCommand(RefreshToken refreshToken)
        {
            RefreshToken = refreshToken;
        }
    }
}
