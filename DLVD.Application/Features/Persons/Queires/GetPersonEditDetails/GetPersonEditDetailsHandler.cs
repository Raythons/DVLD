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

namespace DLVD.App.Features.Persons.Queires.GetPersonEditDetails
{
    public class GetPersonEditDetailsHandler : BaseHandler,
        IRequestHandler<GetPersonEditDetailsRequest, Result<GetPersonEditDetailsResponse>>
    {
        public GetPersonEditDetailsHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<GetPersonEditDetailsResponse>> Handle(
            GetPersonEditDetailsRequest request, 
            CancellationToken cancellationToken)
        {
            var foundPerson = await _unitOfWork.PersonRepository.GetById(request.PersonId);

            if (foundPerson == null) 
                return Result.Fail($"Person With Id {request.PersonId} Is Not In The System");

            var mappedPerson =  _mapper.Map<GetPersonEditDetailsResponse>(foundPerson);

            return mappedPerson;
        }
    }
}
