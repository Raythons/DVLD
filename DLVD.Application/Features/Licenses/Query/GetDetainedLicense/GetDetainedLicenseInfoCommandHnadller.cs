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
                                            .GetById(request.LicenseId,
                                                dl => new GetDetainedLicenseInfoResponse()
                                                {
                                                    ApplicationFees = (int)dl.Application.PaidFees,
                                                    DetainId = dl.Id,
                                                    LicenseID = dl.LicenseId,
                                                    DetainTime = dl.DetainDate,
                                                    CreatedByUser = dl.CreateUser.UserName,
                                                    FineFees = dl.FineFees,
                                                    
                                                }
                                            );

            return DetainedLicenseInfo;
        }
    }
}
