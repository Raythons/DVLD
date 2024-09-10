using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Tests.Query.GetTestResult
{
    public class GetTestResultRequest : IRequest<Result<GetTestResultResponse>>
    {
        public int  TestTypeId {get; set;}
        public int LocalDrivingLicenseApplicationId { get; set; }
        
    }
}
