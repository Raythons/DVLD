using DVLD.Domain.Entities;
using FluentResults;
using MediatR;

namespace DLVD.App.Features.Countries.Query.GetALL
{
    public record class GetAllCountriesRequest : IRequest<IEnumerable<Country>>
    {
    }
}
