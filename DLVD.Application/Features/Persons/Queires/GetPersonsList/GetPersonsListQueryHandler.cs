using AutoMapper;
using DLVD.App.Features.Common;
using DLVD.App.Features.Persons.Queires.GetPersonsList;
using DVLD.App.Interfaces.Persistence;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonList
{
    public class GetPersonsListQueryHandler : BaseHandler,
        IRequestHandler<GetPersonsListQuery,Result<IEnumerable<GetPersonsListDto>>>
    {
        public GetPersonsListQueryHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async  Task<Result<IEnumerable<GetPersonsListDto>>> Handle
            (GetPersonsListQuery request,
            CancellationToken cancellationToken)

        {

            var Persons = await _unitOfWork.PersonRepository.GetAllAsync();

            var PersonsDto = _mapper.Map<IEnumerable<GetPersonsListDto>>(Persons);

            return Result.Ok(PersonsDto);


        }
    }
}
