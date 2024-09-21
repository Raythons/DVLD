using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Query.GetDetainedLicense
{
    public class GetDetainedLicenseInfoCommandHnadller : BaseHandler,
        IRequestHandler<GetDetainedLicenseInfoRequest, Result<GetDetainedLicenseInfoResponse>>
    {
        public GetDetainedLicenseInfoCommandHnadller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetDetainedLicenseInfoResponse>> Handle(
            GetDetainedLicenseInfoRequest request,
            CancellationToken cancellationToken)
        {

            var DetainedLicenseInfo = await _unitOfWork.DetainedLicenseRepositry
                                            .GetByLicenseId(request.LicenseId,
                                                dl => new GetDetainedLicenseInfoResponse()
                                                {
                                                    CreatedBy = dl.CreateUser.UserName,
                                                    DetainDate = dl.DetainDate,
                                                    FineFees = dl.FineFees,
                                                }
                                            );

            return DetainedLicenseInfo;
        }
    }
}
