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

namespace DLVD.App.Features.Tests.Query.GetTest
{
    public class GetTestQueryHandller : BaseHandler,
        IRequestHandler<GetTestQuery , Result<GetTestDto>>
    {
        public GetTestQueryHandller(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<Result<GetTestDto>> Handle(GetTestQuery request,
            CancellationToken cancellationToken)
        {
            var test = await _unitOfWork.TestRepositry.GetById(request.Id);

            if (test is null)
                return Result.Fail($"Test With Id ${request.Id} Not Found");

           return  _mapper.Map<GetTestDto>(test);
        }
    }
}
