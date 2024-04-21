using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Query
{
    public class GetLicenseQuery: IRequest<Result<GetLicenseDto>>
    {
        public int Id { get; set; }

        public GetLicenseQuery(int id)
        {
            Id = id;
        }
    }
}
