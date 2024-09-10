using AutoMapper;
using DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment;
using DLVD.App.Features.TestAppointments.Quries.GetTestAppointment;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DVLD.API.Controllers
{
    [Authorize]
    public class TestAppointmentsController : BaseControllerr
    {
        public TestAppointmentsController(
            IMapper mapper,
            IMediator mediator) : base(mapper, mediator)
        {
        }


        //[HttpGet]
        //[Route("{AppointmentId:int}")]
        //public async Task<IActionResult> GetTestAppointment(int id)
        //{
        //    var result = await _mediator.Send(GetTestAppointmentQuery(id));

        //    if (result.IsFailed)
        //        return BadRequest(result.ToResultDto());

        //    return Ok(result.ToResultDto());
        //}

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetTestAppointment([FromQuery]GetTestAppointmentRequest req)
        {
            var result = await _mediator.Send(req);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));
        }

        //[HttpGet]
        //[Route("")]
        //public async Task<IActionResult> GetTestAppointment([FromQuery] GetTestAppointmentRequest req)
        //{
        //    var result = await _mediator.Send(req);

        //    if (result.IsFailed)
        //        return BadRequest(result.ToResultDto());

        //    return Ok(result.ToResultDto(result.Value));
        //}

        [HttpPost]
        [Route("")]
        
        public async Task<IActionResult> CreateTestAppointment([FromBody] CreateTestAppointmentCommand cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("");

            if(int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId ))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();

            var result = await _mediator.Send(cmd);

            if(result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto());
        }
    }
}
