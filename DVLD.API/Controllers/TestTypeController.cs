using AutoMapper;
using DVLD.App.Interfaces.Persistence;
using DVLD.WEB.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class TestTypeController :  BaseControllerr
    {

        private readonly IUnitOfWork _unitOfWork;

        public TestTypeController(
            IMapper mapper,
            IMediator mediator,
            IUnitOfWork unitOfWork) : base(mapper, mediator)
        {
            _unitOfWork = unitOfWork;
        }

    [HttpGet]
    public async Task<IActionResult> GetTestTypes()
    {
        var values = await _unitOfWork.TestTypeRepositry.All();

        return Ok(values);
    }

}
}

