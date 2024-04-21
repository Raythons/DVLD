using AutoMapper;
using DLVD.App.Features.Drivers.Command.CreateDriver;
using DLVD.App.Features.Drivers.Query.GetDriver;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class DriverController : BaseControllerr
    {
        public DriverController(
            IMapper mapper,
            IMediator mediator) : base(mapper, mediator)
        {
        }
        [HttpGet]
        [Route("driverId:int")]
        public async Task<IActionResult> GetDriver(int driverId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(new GetDriverQuery(driverId));


            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateDriver(CreateDriverCommand cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(cmd);


            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }
    }
}
