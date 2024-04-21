using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Tests.Query.GetTest
{
    public class GetTestQuery : IRequest<Result<GetTestDto>>
    {
        public int Id { get; set; }

        public GetTestQuery(int id)
        {
            Id = id;
        }

        public GetTestQuery() { }
    }
}
