﻿using AutoMapper;
using DLVD.App.Features.TestAppointments.Commands.CreateTestAppointment;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
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

        [HttpPost]
        
        public async Task<IActionResult> CreateTestAppointment([FromBody] CreateTestAppointmentCommand cmd)
        {

            if (!ModelState.IsValid)
                return BadRequest("");

            var result = await _mediator.Send(cmd);

            if(result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto());

        }
    }
}
