using DLVD.App.Features.Common.SharedDtos;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonDetails
{
    public class GetPersonDetailsQuery: IRequest<Result<GetPersonDetailsDto>>
    {
        public string? SearchBy { get; set; } = "Id";
        public string? SearchTerm { get; set; }

        public GetPersonDetailsQuery() { }

        public GetPersonDetailsQuery(string searchTerm,
            string searchBy )
        {
            SearchBy =    searchBy ?? "Id";
            SearchTerm = searchTerm;
        }


    }
}
