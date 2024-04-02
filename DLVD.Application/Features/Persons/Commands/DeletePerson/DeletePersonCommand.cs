using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Commands.DeletePerson
{
    public class DeletePersonCommand : IRequest<Result<bool>>
    {
        public int personId { get; set; }


        public DeletePersonCommand() { }

        public DeletePersonCommand(int id)
        {
            personId = id;
        }
    }
}
