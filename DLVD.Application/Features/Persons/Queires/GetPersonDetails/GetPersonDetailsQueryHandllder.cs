using AutoMapper;
using DLVD.App.Common;
using DLVD.App.Features.Common;
using DLVD.App.Features.Common.SharedDtos;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using DVLD.Domain.Exceptions.Persons;
using FluentResults;
using MediatR;
using System.Linq.Expressions;







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
            var filterExpression =  GetFilterExpression(request.SearchBy, request.SearchTerm);
            var FoundedPerson = await _unitOfWork.PersonRepository.GetDetails(filterExpression);

            if (FoundedPerson == null)
                return Result.Fail($"Person With {request.SearchBy} '{request.SearchTerm}' Is Not In The System");
            
            
            var personDto = _mapper.Map<GetPersonDetailsDto>(FoundedPerson);

            return Result.Ok(personDto);     
        }
        private static  Expression<Func<Person, bool>> GetFilterExpression(string searchBy, string searchTerm)
        {
            if (searchBy == "Id" && int.TryParse(searchTerm, out int personId))
                return person => person.Id == personId;

            return searchBy.ToLower()
                switch
           {
               "firstname" => person  => person.FirstName == searchTerm,
               "secondname" => person => person.SecondName == searchTerm,
               "thirdName" => person => person.ThirdName == searchTerm,
               "lastname" => person => person.LastName == searchTerm,
               "email" => person => person.Email == searchTerm,
               "nationalno" => person => person.NationalNo == searchTerm,
               _ => person => person.Id == 0,
           };
        }
    }
}
