
using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Licenses.Query.GetLicense
{
    public class GetLicenseQueryHandller : BaseHandler,
        IRequestHandler<GetLicenseQuery, Result<GetLicenseResponse>>
    {
        public GetLicenseQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetLicenseResponse>> Handle(GetLicenseQuery request,
            CancellationToken cancellationToken)
        {
            var License = await _unitOfWork.LicenseRepositry.GetById(request.Id);
                
            
            if (License is null)
                return Result.Fail("License Not Found");

            var LicenseDto = _mapper.Map<GetLicenseResponse>(License);

            return Result.Ok(LicenseDto);
        }
    }
}
