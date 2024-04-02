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

namespace DLVD.App.Features.Persons.Commands.UpdatePerson
{
    public class UpdatePersonCommandHandler : BaseHandler,
        IRequestHandler<UpdatePersonCommand, Result<bool>>
    {
        public UpdatePersonCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(UpdatePersonCommand request,
            CancellationToken cancellationToken)
        {
            Person newPersonData =  _mapper.Map<Person>(request);

            bool isUpdated = await _unitOfWork.PersonRepository.Update(newPersonData);

            if (isUpdated)    
                await _unitOfWork.CompleteAsync();
            

            return Result.Ok(isUpdated);
            
        }
    }
}
