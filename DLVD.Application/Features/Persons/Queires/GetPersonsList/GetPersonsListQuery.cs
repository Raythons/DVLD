



using DLVD.App.Features.Persons.Queires.GetPersonsList;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Persons.Queires.GetPersonList
{
    public class GetPersonsListQuery : IRequest<Result<IEnumerable<GetPersonsListDto>>>
    {

    }
}
