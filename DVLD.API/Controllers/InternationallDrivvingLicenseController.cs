using AutoMapper;
using DLVD.App.Features.InternationalDrivvingLicenses.Command.CreateInternationalDrivvingLicense;
using DLVD.App.Features.InternationalDrivvingLicenses.Query.GetInternationalLicense;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    [Route("api/Applications/[controller]")]
    public class InternationallDrivvingLicenseController : BaseControllerr
    {
        public InternationallDrivvingLicenseController(
            IMapper mapper,
            IMediator mediator) : base(mapper, mediator)
        {
        }


        [HttpGet]
        [Route("licenseId:{int}")]
        public async Task<IActionResult> GetInternationalLicenseDetails(int licenseId)
        {

            var result = await _mediator.Send( new GetInternationalLicenseRequest(licenseId));

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));
        }

        [HttpPost]
        public async Task<IActionResult> CreatInternationallDrivingLicense(
            [FromBody] CreateInternationalDrivvingLicenseRequest command)
        {
            if (!ModelState.IsValid)
                return BadRequest("The Request Content Is Wrong");

            var result = await _mediator.Send(command);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));
        }
    }
}
