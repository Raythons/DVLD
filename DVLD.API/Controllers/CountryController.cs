using AutoMapper;
using DLVD.App.Features.Countries.Query.GetALL;
using DLVD.App.Features.InternationalDrivvingLicenses.Query.GetInternationalLicense;
using DVLD.WEB.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.API.Controllers
{
    public class CountryController :BaseControllerr
    {

        public CountryController(
           IMapper mapper,
           IMediator mediator) : base(mapper, mediator)
        {
        }


        [HttpGet]
        public async Task<IActionResult> GetALLCountries()
        {

            var result = await _mediator.Send(new GetAllCountriesRequest());

            return Ok(result);
        }

    }
}
