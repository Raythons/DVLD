using AutoMapper;
using DLVD.App.Features.Applications.Command.CreateApplication;
using DLVD.App.Features.LocalDrivingLicense.Command.CreateLocalDrivvingLicense;
using DLVD.App.Features.LocalDrivingLicense.Query.GetLocalDriverLicense;
using DVLD.Domain.Entities;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DVLD.API.Controllers
{

    [Route("api/Applications/[controller]")]
    public class LocalDrivvingLicenseController : BaseControllerr
    {

        public LocalDrivvingLicenseController(
            IMapper mapper,
            IMediator mediator) : base(mapper, mediator)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetLocalDrivingLicense(int id)
        {

            if (!ModelState.IsValid)
                return BadRequest("The Request Content Is Wrong");

            var result = await _mediator.Send(new GetLocalDriverLicenseQuery(id));

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));

        }


        [HttpPost]
        public async Task<IActionResult> CreateLocalDrivingLicense(
               [FromBody] CreateLocalDrivingLicenseCommand command)
        {
            if(!ModelState.IsValid)
                return BadRequest("The Request Content Is Wrong");

            var result = await _mediator.Send(command);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));

        }


        [HttpPost]
        [Route("local-drivving-license-and-application")]
        public async Task<IActionResult> CreateLocalDrivingLicenseApplicationWithApplication(
               [FromBody] CreateLocalLicenseAndApplication command)
        {
    
            if (!ModelState.IsValid)
                return BadRequest("The Request Content Is Wrong");

            var applicationResult = await _mediator.Send
                                                       ( new CreateApplicationCommand
                                                           (
                                                           command.PersonId,
                                                           command.CreatedByUserId,
                                                           command.ApplicationTypeId,
                                                           command.LicenseClassId
                                                           )
                                                       );
           
            if (applicationResult.IsFailed)
                return BadRequest(applicationResult.ToResultDto());


            var localLicenseResult = await _mediator
                                                .Send
                                                    (new CreateLocalDrivingLicenseCommand
                                                          (
                                                            applicationResult.Value,
                                                            command.LicenseClassId
                                                          )                                                                 
                                                     );

            if (localLicenseResult.IsFailed)
                return BadRequest(localLicenseResult.ToResultDto());

            return Ok(applicationResult.ToResultDto(applicationResult.Value));

        }
    }

    public class CreateLocalLicenseAndApplication
    {
        public int LicenseClassId { get; set; }
        public int PersonId { get; set; }
        public int CreatedByUserId { get; set; }
        public int ApplicationTypeId { get; set; }


    }
}
