using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Licenses.Query.GetLicense
{
    public class GetLicenseQuery : IRequest<Result<GetLicenseResponse>>
    {
        public int Id { get; set; }
        
        public GetLicenseQuery(int id)
        {
            Id = id;
        }
    }
}
