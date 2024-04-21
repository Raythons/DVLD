using DLVD.App.Features.Common.SharedDtos;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Drivers.Query.GetDriver
{
    public class GetDriverQuery: IRequest<Result<GetDriverDto>>
    {
        public int Id { get; set; }

        public GetDriverQuery(int id)
        {
            Id = id;
        }
    }
}
