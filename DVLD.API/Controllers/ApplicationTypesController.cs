using AutoMapper;
using DVLD.App.Interfaces.Persistence;
using DVLD.WEB.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class ApplicationTypesController : BaseControllerr
    {

        private readonly IUnitOfWork _unitOfWork;

        public ApplicationTypesController(
            IMapper mapper,
            IMediator mediator,
            IUnitOfWork unitOfWork) : base(mapper, mediator)
        {
            _unitOfWork = unitOfWork;
        }

     

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetApplicationsTypes()
        {
            var values = await _unitOfWork.ApplicationTypeRepositry.All();

            return Ok(values);
        }
     

        [HttpGet]
        [Route("ApplicationFees/int:typeId")]
        public async Task<IActionResult> GetApplicationFees(int typeId)
        {
            
            var values = await _unitOfWork.ApplicationTypeRepositry.GetApplicationTypeFees(typeId);

            return Ok(values);
        }

    }
}
