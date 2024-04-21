using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Users.Queires.GetUserQuery
{
    public record GetUserQuery(int Id): IRequest<Result<GetUserDto>>
    {
    }
}
