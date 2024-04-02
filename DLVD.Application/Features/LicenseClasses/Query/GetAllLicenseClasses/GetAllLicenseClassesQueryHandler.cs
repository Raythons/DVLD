using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.LicenseClasses.Query.GetAllLicenseClasses
{
    public class GetAllLicenseClassesQueryHandler : BaseHandler,
        IRequestHandler<GetAllLicenseClassesQuery, Result<IEnumerable<LicenseClassDto>>>
    {

        public GetAllLicenseClassesQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<IEnumerable<LicenseClassDto>>>
            Handle(GetAllLicenseClassesQuery request, CancellationToken cancellationToken)
        {
            var LicenseClasses = await  _unitOfWork.LicenseClassRepositry.All(); 

            var LicenseClassesDto =
                 _mapper.Map<IEnumerable<LicenseClassDto>>(LicenseClasses);

            return Result.Ok(LicenseClassesDto);
        }
    }
}
