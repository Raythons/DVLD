using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Applications.Queries.GetApplication
{
    public class GetApplicationQueryHandller : BaseHandler,
                    IRequestHandler<GetApplicationQuery, Result<GetApplicationDto>>
    {
        public GetApplicationQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetApplicationDto>> Handle(
            GetApplicationQuery request, CancellationToken cancellationToken)
        {
            var application = await _unitOfWork.ApplicationRepositry.GetById(request.Id);

            if (application is null)
                return Result.Fail("Application Not Found");

            var applicationDto = _mapper.Map<GetApplicationDto>(application);


            return Result.Ok(applicationDto);
        }
    }
}
