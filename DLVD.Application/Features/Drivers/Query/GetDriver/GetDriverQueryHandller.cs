using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Features.Common.SharedDtos;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Drivers.Query.GetDriver
{
    public class GetDriverQueryHandller : BaseHandler,
        IRequestHandler<GetDriverQuery, Result<GetDriverDto>>
    {
        public GetDriverQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetDriverDto>> Handle(GetDriverQuery request,
            CancellationToken cancellationToken)
        {
            var Driver = await _unitOfWork.DriverRepository.GetById(request.Id);

            if (Driver is null)
                return Result.Fail("Driver Not Found");

            var DriverDto = _mapper.Map<GetDriverDto>(Driver);
      
            return Result.Ok(DriverDto);        
        }
    }
}
