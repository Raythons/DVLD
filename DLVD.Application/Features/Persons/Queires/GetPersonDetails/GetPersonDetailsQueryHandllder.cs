using AutoMapper;
using DLVD.App.Common;
using DLVD.App.Features.Common;
using DLVD.App.Features.Common.SharedDtos;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using DVLD.Domain.Exceptions.Persons;
using FluentResults;
using MediatR;







namespace DLVD.App.Features.Persons.Queires.GetPersonDetails
{
    public class GetpersonDetailsQueryHandllder : BaseHandler,
        IRequestHandler<GetPersonDetailsQuery, Result<GetPersonDetailsDto>>
    {
        public GetpersonDetailsQueryHandllder(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<Result<GetPersonDetailsDto>> Handle(
            GetPersonDetailsQuery request,
            CancellationToken cancellationToken)
        {
            var FoundedPerson = await _unitOfWork.PersonRepository.GetById(request.Id);

            if (FoundedPerson == null)
                return Result.Fail($"Person With Id {request.Id} Is Not In The System");
            

            var personDto = _mapper.Map<GetPersonDetailsDto>(FoundedPerson);

            return Result.Ok(personDto);     
        }
    }
}
