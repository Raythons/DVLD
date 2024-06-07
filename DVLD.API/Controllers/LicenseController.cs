using AutoMapper;
using DLVD.App.Features.Licenses.Command.CreateLicense;
using DLVD.App.Features.Licenses.Command.RenewLicense;
using DLVD.App.Features.Licenses.Query.GetLicense;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        [Route("licenseId:int")]
        public async Task<IActionResult> GetLicense(int licenseId) 
        { 
            if(!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(new GetLicenseQuery(licenseId));


            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateLicense(CreateLicenseCommand cmd)
        {
     
            if (!ModelState.IsValid)
                return BadRequest("Bad Data");

            var result = await _mediator.Send(cmd);


            if (result.IsFailed)
                return BadRequest(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> RenewLicense(RenewLicenseRerquest cmd)
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
