using AutoMapper;
using DLVD.App.Features.Common;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using FluentResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Countries.Query.GetALL
{
    public class GetALLCountriesHandler : BaseHandler ,
        IRequestHandler<GetAllCountriesRequest, IEnumerable<Country>>
    {
        public GetALLCountriesHandler(
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<IEnumerable<Country>> Handle(
            GetAllCountriesRequest request,
            CancellationToken cancellationToken)
        {
            return await _unitOfWork.CountryRepository.GetAll();
        }
    }
}
