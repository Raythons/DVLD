using AutoMapper;
using DLVD.App.Features.Tests.Command.CreateTestCommand;
using DLVD.App.Features.Tests.Query.GetTest;
using DLVD.App.Features.Tests.Query.GetTestResult;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DVLD.API.Controllers
{
    public class TestController : BaseControllerr
    {
        public TestController(
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

        [HttpGet]
        [Route("TestResult/")]
        public async Task<IActionResult> GetTestResult([FromQuery]  GetTestResultRequest request)
        {

            if (!ModelState.IsValid)
                return BadRequest("Missing An Id");

            var res = await _mediator.Send(request);

            if (res.IsFailed)
                return BadRequest(res.ToResultDto());

            return Ok(res.ToResultDto(res.Value));
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateTest([FromBody] CreateTestCommand cmd)
        {

            if (int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();

            if (!ModelState.IsValid)
                return BadRequest("Missing An Id");

            var res = await _mediator.Send(cmd);

            if (res.IsFailed)
                return BadRequest(res.ToResultDto());

            return Ok(res.ToResultDto(res.Value));
        }
    }
}
