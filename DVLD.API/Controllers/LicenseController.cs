using AutoMapper;
using DLVD.App.Features.Licenses.Command.CreateLicense;
using DLVD.App.Features.Licenses.Command.DetainLicense;
using DLVD.App.Features.Licenses.Command.RenewLicense;
using DLVD.App.Features.Licenses.Command.ReplaceLicense;
using DLVD.App.Features.Licenses.Query.GetDetainedLicense;
using DLVD.App.Features.Licenses.Query.GetLicense;
using DLVD.App.Features.Licenses.Query.GetLicenseId;
using DLVD.App.Features.Licenses.Query.GetLicensesList;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DVLD.API.Controllers
{
    
    public class LicenseController : BaseControllerr
    { 
        public LicenseController(
            IMapper mapper, 
            IMediator mediator) : base(mapper, mediator)
        {
        }


        [HttpGet]
        [Route("{licenseId:int}")]
        public async Task<IActionResult> GetLicense(int licenseId) 
        { 
            if(!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(new GetLicenseQuery(licenseId));


            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetLicense([FromQuery] GetLicensesListRequest cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(cmd);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpGet]
        [Route("licenseid/{applicationId:int}")]
        public async Task<IActionResult> GetLicenseId(int  applicationId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send( new GetLicenseIdRequest(applicationId));

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateLicense([FromBody] CreateLicenseCommand cmd)
        {
     
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            if (int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();
    
            var result = await _mediator.Send(cmd);
                    
            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPost]
        [Route("renew")]
        public async Task<IActionResult> RenewLicense([FromBody] RenewLicenseRerquest cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            if (int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();

            var result = await _mediator.Send(cmd);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPut]
        [Route("replace")]
        public async Task<IActionResult> ReplaceLicense(ReplaceLicenseRequest cmd)
        {
            Console.WriteLine("##########################################");

            Console.WriteLine(cmd.PreviousLicenseId);
            Console.WriteLine("##########################################");

            if (!ModelState.IsValid)
                return BadRequest("Bad Data");


            if (int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();

            var result = await _mediator.Send(cmd);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPost]
        [Route("/detain")]
        public async Task<IActionResult> DetainLicense(DetainLicenseRequest cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(cmd);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpGet]
        [Route("detain/{licenseId:int}")]
        public async Task<IActionResult> GetDetainLicense(int licenseId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(new GetDetainedLicenseInfoRequest(licenseId));

            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }
    }
}
