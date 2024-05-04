using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities.Views;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Drivers.Query.GetDriversList
{
    public class GetDriverListCommandHandler : BaseHandler, 
        IRequestHandler<GetDriverListRequest, Result<PagedList<DriversBreifInfoView>>>
    {
        public GetDriverListCommandHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<Result<PagedList<DriversBreifInfoView>>>Handle(
            GetDriverListRequest request,
            CancellationToken cancellationToken)
        {

            //var GetOrderFilterExp = GetOrderFilterExp
            var DriverseList = await _unitOfWork
                                      .DriverRepository
                                      .GetAllPaginatedAsync();


            


            return Result.Ok(DriverseList);




        }
    }
}
