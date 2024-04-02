using DLVD.App.Features.Persons.Queires.GetPersonsList;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Persons.Queires.GetPersonsPaginitaed
{
    public class GetPersonsPaginatedQuery: IRequest<Result<IEnumerable<GetPersonsListDto>>>
    {
        public string? SearchTerm {  get; set; }
        public string? SortOdrer {  get; set; }
        public string? SortCoulmn { get; set; }
        public int Page { get; set; } = 1;


        public GetPersonsPaginatedQuery() { }
       

        public GetPersonsPaginatedQuery(
             string? searchTerm, 
            string? sortOdrer,
            string? sortCoulmn,
            int page ) 
        {
            SearchTerm = searchTerm;
            SortOdrer = sortOdrer;
            SortCoulmn = sortCoulmn;
            Page = page;
        }
    }
}
