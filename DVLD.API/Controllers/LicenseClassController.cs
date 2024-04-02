using AutoMapper;
using DLVD.App.Features.LicenseClasses.Query.GetAllLicenseClasses;
using DVLD.App.Interfaces.Persistence;
using DVLD.Domain.Entities;
using DVLD.WEB.Controllers;
using FluentResults;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class LicenseClassController : BaseControllerr
    {
        public LicenseClassController(
            IMapper mapper,
            IMediator mediator, IUnitOfWork unitOfWork) : base(mapper, mediator)
        {
        }


        [HttpGet]
        public async Task<IActionResult> GetAllLicenseClasses()
        {

            var result = await _mediator.Send( new GetAllLicenseClassesQuery() );

           if ( result.IsFailed ) {
                return BadRequest("SomeThing Went Wrong ");
            }

            return Ok(result.ToResultDto(result.Value));
        }

    }
}
