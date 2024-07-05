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

namespace DLVD.App.Features.Persons.Commands.DeletePerson
{
    public class DeletePersonCommandHandler :   BaseHandler,
        IRequestHandler<DeletePersonCommand, Result<bool>>
    {
        public DeletePersonCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<bool>> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {

            if (await _unitOfWork.PersonRepository.isConnectedEntity(request.personId))
                return Result.Fail("Person Conneted In The System You Cant Delete It ");

            bool isDeleted = await _unitOfWork.PersonRepository.Delete(request.personId);
            await _unitOfWork.CompleteAsync();

            return isDeleted;
        }
    }
}
