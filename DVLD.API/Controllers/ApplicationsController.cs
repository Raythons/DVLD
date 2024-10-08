﻿using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.Applications.Command.UpdateApplicaton;
using DLVD.App.Features.Applications.Queries.GetApplication;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Enums;
using DVLD.WEB.Controllers;
using FluentResults;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DVLD.API.Controllers
{
    public class ApplicationsController : BaseControllerr
    {
        private IUnitOfWork _unitOfWork;
        public ApplicationsController(
            IMapper mapper,
            IMediator mediator,
            IUnitOfWork unitOfWork) : base(mapper, mediator)
        {
            _unitOfWork = unitOfWork;
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

        [HttpGet]
        [Route("{applicationId:int}/IssuedLicense")]
        public async Task<IActionResult> IsApplicationAssociatedWithLicense(int applicationId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Data is Bad");

            var IssuedLicense =  await  _unitOfWork.ApplicationRepositry.IsAssociatedWithLicense(applicationId);

            //await _unitOfWork.CompleteAsync();

            if (!IssuedLicense)
                return Ok(Result.Ok(false).ToResultDto(false));

            return Ok(Result.Ok(true).ToResultDto(true));

        }
        //[Authorize]
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreaterApplication(CreateApplicationCommand command)
        {
            
            if (!ModelState.IsValid)
                return BadRequest("Data is Bad");

            int.TryParse(User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value, out int createByUserId);
            command.CreatedByUserId = createByUserId;

            var applicationResult = await _mediator.Send(command);

            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto(applicationResult.Errors));

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }
     

        [HttpPut]
        [Route("{applicationId:int}/Status")]
        public async Task<IActionResult> DeleteApplication(int applicationId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Inalid Data");

            var applicationResult = await _mediator.Send(
                                                    new UpdateApplicationStatusCommand(applicationId)
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
