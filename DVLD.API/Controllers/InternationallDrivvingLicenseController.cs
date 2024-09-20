using AutoMapper;
using DLVD.App.Features.InternationalDrivvingLicenses.Command.CreateInternationalDrivvingLicense;
using DLVD.App.Features.InternationalDrivvingLicenses.Query.GetInternationalLicense;
using DVLD.WEB.Controllers;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        [Route("")]
        public async Task<IActionResult> CreatInternationallDrivingLicense(
            [FromBody] CreateInternationalDrivvingLicenseRequest cmd)
        {
            if (!ModelState.IsValid)
                return BadRequest("The Request Content Is Wrong");

            if (int.TryParse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value, out var userId))
                cmd.CreatedByUserId = userId;
            else
                return Unauthorized();

            var result = await _mediator.Send(cmd);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(result.ToResultDto(result.Value));
        }
    }
}
