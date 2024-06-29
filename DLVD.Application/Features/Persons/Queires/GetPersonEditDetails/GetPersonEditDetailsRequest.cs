using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonEditDetails
{
    public   record class GetPersonEditDetailsRequest (int PersonId) 
        : IRequest<Result<GetPersonEditDetailsResponse>>
    {
    }
}
