using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Tests.Query.GetTestResult
{
    public class GetTestResultHandler : BaseHandler ,
        IRequestHandler<GetTestResultRequest, Result<GetTestResultResponse>>
    {
        public GetTestResultHandler(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetTestResultResponse>> Handle(
            GetTestResultRequest request,
            CancellationToken cancellationToken)
        {


            var testResult = await _unitOfWork.TestRepositry.All();
            throw new NotImplementedException();
        }
    }
}
