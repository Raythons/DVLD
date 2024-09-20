using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Licenses.Query.GetLicenseId
{
    public record class GetLicenseIdRequest (int ApplicationId) : IRequest<Result<int>>
    {
    }
}
