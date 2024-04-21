using FluentResults;
using MediatR;


namespace DLVD.App.Features.Drivers.Command.CreateDriver
{
    public class CreateDriverCommand: IRequest<Result<bool>>
    {
        public int PersonId { get; set; }
        public int CreatedByUserId { get; set; }
        public DateTime CreatedAt { get;  } = DateTime.Now; 

    }
}
