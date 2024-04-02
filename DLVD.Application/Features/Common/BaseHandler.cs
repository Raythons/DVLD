using AutoMapper;
using DVLD.App.Interfaces.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLVD.App.Features.Common
{
    public class BaseHandler
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMapper _mapper;

        public BaseHandler(IUnitOfWork unitOfWork, IMapper mapper) 
        { 
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork)); 
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
    }
}
