using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Features.Persons.Queires.GetPersonsList;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonsPaginitaed
{
    public class GetPersonsPaginatedQueryHandler : BaseHandler,
        IRequestHandler<GetPersonsPaginatedQuery, Result<IEnumerable<GetPersonsListDto>>>
    {
        public GetPersonsPaginatedQueryHandler
            (IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<IEnumerable<GetPersonsListDto>>> Handle(
            GetPersonsPaginatedQuery request,
            CancellationToken cancellationToken)
        {
            //if (!string.IsNullOrEmpty(request.SearchTerm))

            var sortCoulmnExp = GerOrderByProperty(request.SortCoulmn);

            var PaginatedPersons = await _unitOfWork.
                                        PersonRepository.
                                        GetPaginatedAsync(
                                            request.Page,
                                            request.SearchTerm,
                                            sortCoulmnExp,
                                            request.SortOdrer);

            var PersonsDto = _mapper.Map<IEnumerable<GetPersonsListDto>>(PaginatedPersons);

            return Result.Ok(PersonsDto);

        }
        
        private static Expression<Func<Person, object>> GerOrderByProperty(string? sortCoulmn)
        {
            return sortCoulmn?.ToLower()
                switch
            {
                "FirstName" => person => person.FirstName,
                "SecondName" => person=> person.SecondName,
                "ThirdName" => person=> person.ThirdName,
                "LastName" => person=> person.LastName,
                "id" => person=> person.Id,
                _ => person=> person.Id
            };
        }
    }
}
