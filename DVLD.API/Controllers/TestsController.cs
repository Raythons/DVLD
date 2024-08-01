using AutoMapper;
using DLVD.App.Features.Tests.Command.CreateTestCommand;
using DLVD.App.Features.Tests.Query.GetTest;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class TestsController : BaseControllerr
    {
        public TestsController(
            IMapper mapper, 
            IMediator mediator) : base(mapper, mediator)
        {
        }

        [HttpGet]
        [Route("/{testId:int}")]
        public async Task<IActionResult> GetTest(int testId)
        {
            
            if(!ModelState.IsValid)
                  return BadRequest("Missing An Id");

            var res = await  _mediator.Send(new GetTestQuery(testId));

            if (res.IsFailed)
                return BadRequest(res.ToResultDto());

            return Ok(res.ToResultDto(res.Value));
        }
        [HttpPost]
        public async Task<IActionResult> CreateTest([FromBody] CreateTestCommand cmd)
        {

            if (!ModelState.IsValid)
                return BadRequest("Missing An Id");

            var res = await _mediator.Send(cmd);

            if (res.IsFailed)
                return BadRequest(res.ToResultDto());

            return Ok(res.ToResultDto(res.Value));
        }
    }
}
