using DLVD.App.Common.Errors;
using DLVD.App.Features.Persons.Commands.CreatePerson;
using FluentResults;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.PipeLineBehaviors
{
    public class ValidationPipleLineBehavipor<Trequest, Tresponse> : IPipelineBehavior<Trequest, Tresponse>
        where Trequest : IRequest<Tresponse>
        where Tresponse : ResultBase , new()
    {
       private readonly IValidator<Trequest> _validator;
       public ValidationPipleLineBehavipor(IValidator<Trequest> validator)
        {
            _validator = validator;
        }  
        public async Task<Tresponse> Handle(
            Trequest request,
            RequestHandlerDelegate<Tresponse> next,
            CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(request, cancellationToken);

            if (!validationResult.IsValid)
            {
                var err = ValidationError.Create();
                var r = new Tresponse();

                foreach (var error in validationResult.Errors)
                {
                    err.Reasons.Add(new ValidationError(error.ErrorMessage));
                }

                r.Reasons.Add(err);
                return r;
            }
             
            return await next();
        }
    }
}
