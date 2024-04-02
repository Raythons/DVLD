using DLVD.App.Features.Persons.Commands.CreatePerson;
using DLVD.App.PipeLineBehaviors;
using FluentResults;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.extensions
{
    public static  class ValidationPipleLineRegisterExtension
    {
        public static MediatRServiceConfiguration AddValidation<Trequest, Tresponse>(
            this MediatRServiceConfiguration config)
            where Trequest : IRequest<Tresponse>
            where Tresponse : ResultBase, new()
        {

            return config.AddBehavior<IPipelineBehavior<Trequest, Tresponse>, 
                                        ValidationPipleLineBehavipor<Trequest, Tresponse>>();
        }
    }
}
