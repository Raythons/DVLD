using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDriverLicense
{
    public class GetLocalDriverLicenseQuery: IRequest<Result<GetLocalDrivvingLicenseDto>>
    {
        public int  Id { get; set; }

        public GetLocalDriverLicenseQuery(int id)
        {
            Id = id;
        }

        public GetLocalDriverLicenseQuery() { }
    }
}
