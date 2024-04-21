
using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Licenses.Query
{
    public class GetLicenseQueryHandller : BaseHandler,
        IRequestHandler<GetLicenseQuery, Result<GetLicenseDto>>
    {
        public GetLicenseQueryHandller(
            IUnitOfWork unitOfWork, 
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetLicenseDto>> Handle(GetLicenseQuery request,
            CancellationToken cancellationToken)
        {
            var License = await _unitOfWork.LicenseRepositry.GetById(request.Id);

            if (License is null)
                return Result.Fail("License Not Found");

            var LicenseDto = _mapper.Map<GetLicenseDto>(License);

            return Result.Ok(LicenseDto);

        }
    }
}
