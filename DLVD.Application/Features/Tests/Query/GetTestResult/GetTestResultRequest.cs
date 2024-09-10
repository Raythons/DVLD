using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Tests.Query.GetTestResult
{
    public class GetTestResultRequest : IRequest<Result<GetTestResultResponse>>
    {
        public int  TestTypeId {get; set;}
        public int LocalDrivingLicenseApplicationId { get; set; }
        
    }
}
