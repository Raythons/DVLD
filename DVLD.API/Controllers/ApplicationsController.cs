using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Applications.Command.UpdateApplicaton;
using DLVD.App.Features.Applications.Queries.GetApplication;
using DVLD.Domain.Enums;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class ApplicationsController : BaseControllerr
    {
        public ApplicationsController(
            IMapper mapper,
            IMediator mediator) : base(mapper, mediator)
        {
        }

        [HttpGet]
        [Route("{applicationId:int}")]
        
        public async Task<IActionResult> GetApplication(int  applicationId)
        {
            if(!ModelState.IsValid)
                return BadRequest("Data is Bad");

            var applicationResult = await _mediator.Send(new GetApplicationQuery(applicationId));

            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto(applicationResult.Errors));

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }
        
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetApplicationList([FromQuery] GetApplicationListQuery query )
        {
            if (!ModelState.IsValid)
                return BadRequest("Data is Bad");

            var applicationResult = await _mediator.Send(query);

            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto(applicationResult.Errors));

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }
        //[Authorize]
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreaterApplication(CreateApplicationCommand command)
        {
            
            if (!ModelState.IsValid)
                return BadRequest("Data is Bad");

            var applicationResult = await _mediator.Send(command);

            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto(applicationResult.Errors));

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }

        [HttpPut]
        [Route("{applicationId:int}/Status")]
        public async Task<IActionResult> UpdateApplicationStatus(int applicationId, [FromBody] EnStatus status )
        {
            if (!ModelState.IsValid)
                return BadRequest("Inalid Data");

            var applicationResult = await _mediator.Send(
                                                    new UpdateApplicationStatusCommand(applicationId, status)
                                                    );

            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto(applicationResult.Errors));

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }

            //public async Task<IActionResult> CreateLocalDrivingLicense(CreateLocalDrivingLicenseCommand command)
            //{

            //    var result = await _mediator.Send(command);
            //}


        }
    }
