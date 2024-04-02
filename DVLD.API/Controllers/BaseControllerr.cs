using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.WEB.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class BaseControllerr : ControllerBase
    {
        protected readonly IMapper _mapper;
        protected readonly IMediator _mediator;
        public BaseControllerr(
            IMapper mapper,
            IMediator mediator)
        {
            _mapper = mapper;
            _mediator = mediator;
        }
    }
}
