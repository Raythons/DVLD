using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentValidation;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using DLVD.App.Common.Errors;
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

            
            var validator = new CreatePersonValidator();
            var validationResult = await validator.ValidateAsync(request, cancellationToken);

            

            //if (!validationResult.IsValid)
            //{
                
            //    var err = ValidationError.Create();

            //    foreach (var error in validationResult.Errors)
            //    {
            //        err.Reasons.Add(new ValidationError(error.ErrorMessage));
            //    }

            //    Result r = Result.Fail(err);
            //    return r;
            //}

            var Person = _mapper.Map<Person>(request);


            bool IsCreated = await _unitOfWork.PersonRepository.Add(Person);
            await _unitOfWork.CompleteAsync();

            return Result.Ok(IsCreated);
        }
    }
}
