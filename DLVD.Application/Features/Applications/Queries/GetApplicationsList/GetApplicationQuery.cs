using DLVD.App.Features.Applications.Queries.GetApplicationsList;
using DLVD.App.Features.Common;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;


namespace DLVD.App.Features.Applications.Queries.GetApplication
{
    public class GetApplicationListQuery 
        : IRequest<Result<List<GetApplicationListDto>>>
    {

        public string? SearchTerm { get; set; }
        public string? SortOdrer { get; set; }
        public string? SortCoulmn { get; set; }
        public int Page { get; set; } = 1;
        public GetApplicationListQuery() { }

        public GetApplicationListQuery(
             string? searchTerm,
            string? sortOdrer,
            string? sortCoulmn,
            int page)
        {
            SearchTerm = searchTerm;
            SortOdrer = sortOdrer;
            SortCoulmn = sortCoulmn;
            Page = page;
        }
        
    }
}
