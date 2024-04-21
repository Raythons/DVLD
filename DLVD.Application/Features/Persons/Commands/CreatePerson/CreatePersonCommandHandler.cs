using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

//using FluentResults.Samples.WebController;

namespace DLVD.App.Features.Persons.Commands.CreatePerson
{
    
    public class CreatePersonCommandHandler :
        BaseHandler,
        IRequestHandler<CreatePersonCommand, Result<bool>>
    {

        public CreatePersonCommandHandler(
            IUnitOfWork unitOfWor,
            IMapper mapper) : base(unitOfWor, mapper)
        {

        }    
        public async Task<Result<bool>> Handle(CreatePersonCommand request,
            CancellationToken cancellationToken)
        {

                
            var Person = _mapper.Map<Person>(request);


            bool IsCreated = await _unitOfWork.PersonRepository.Add(Person);
            await _unitOfWork.CompleteAsync();

            return Result.Ok(IsCreated);
        }
    }
}
