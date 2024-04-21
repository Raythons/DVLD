using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Applications.Queries.GetApplication
{
    public class GetApplicationQuery : IRequest<Result<GetApplicationDto>>
    {
        public int Id { get; set; }
        public GetApplicationQuery(int id)
        {
            Id = id;
        }
        public GetApplicationQuery() { }


    }
}
