using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.InternationalDrivvingLicenses.Query.GetInternationalLicense
{
    public class GetInternationalQueryHandler : BaseHandler,
        IRequestHandler<GetInternationalLicenseRequest, Result<GetInternationalLicenseResponse>>
    {
        public GetInternationalQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetInternationalLicenseResponse>> Handle(
            GetInternationalLicenseRequest request,
            CancellationToken cancellationToken)
        {

            var foundedInternationalLicense = await _unitOfWork
                                                       .InternationalDrivingLicenseRepositry
                                                       .GetById(request.LicenseId);

            if (foundedInternationalLicense is null)
                return Result.Fail("Not Found");

            var mappedInternationalLicense = _mapper.Map<GetInternationalLicenseResponse>(foundedInternationalLicense);

            return Result.Ok(mappedInternationalLicense);

        }
    }
}
