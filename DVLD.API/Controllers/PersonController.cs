using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using DLVD.App.Features.Persons.Queires.GetPersonDetails;
using DLVD.App.Features.Persons.Commands.CreatePerson;
using DLVD.App.Features.Persons.Commands.DeletePerson;
using DLVD.App.Features.Persons.Commands.UpdatePerson; 
using DLVD.App.Features.Persons.Queires.GetPersonsPaginitaed;
using Microsoft.Extensions.Options;
using DVLD.API;
using FluentResults.Samples.WebController;
using DLVD.App.Features.Persons.Queires.GetPersonEditDetails;
using Microsoft.AspNetCore.Authorization;







namespace DVLD.WEB.Controllers
{
    //[Authorize]
    public class PersonController : BaseControllerr
    {

        private readonly ILogger<PersonController> _logger;
        private readonly IOptionsSnapshot<OptionsConfigOptions> _optionsConfig;
        
        public PersonController(
            ILogger<PersonController> logger,
            IMapper mapper,
             IMediator mediator,
             IOptionsSnapshot<OptionsConfigOptions> optionsConfig) : base(mapper, mediator)
        {
            _logger = logger;
            _optionsConfig = optionsConfig;
            var g = _optionsConfig.Value;
        }
            
        [HttpGet]
        [Route("Details")] 
        public async Task<IActionResult> GetPerson([FromQuery] GetPersonDetailsQuery getPersonDetailsQuery)
        {
            _logger.LogInformation("Person has been hitten");

            var result = await _mediator.Send(getPersonDetailsQuery);

            if(result.IsFailed) 
                return NotFound(result.ToResultDto(false));
            
            return Ok(result.ToResultDto(result.Value));   
        }

        [HttpGet]
        [Route("to-edit/{personId:int}")]
        public async Task<IActionResult> GetPersonToEdit(int personId)
        {
            _logger.LogInformation("Person has been hitten");
            var query = new GetPersonEditDetailsRequest(personId);

            var result = await _mediator.Send(query);

            if (result.IsFailed)
                return NotFound(result.ToResultDto(false));

            return Ok(result.ToResultDto(result.Value));
        }


        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetPersonsPaginitate([FromQuery] GetPersonsPaginatedQuery query)
        {
            
             var result  = await _mediator.Send(query);

            if (result.IsFailed) return NotFound(result.ToResultDto());

            return Ok(result.ToResultDto(result.ValueOrDefault));

        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreatePerson([FromForm] CreatePersonCommand command)
        {
            if (!ModelState.IsValid)
                return BadRequest("Field Or More Not In Correct form");

            if (Request.Form.Files.Count > 0)
            {
                using var ms = new MemoryStream();
                Request.Form.Files[0].CopyTo(ms);

                command.Image = ms.ToArray();
            }


            //if (Enum.TryParse(typeof(EnGender), command.Gender.ToString() , true, out object genderValue))
            //    command.Gender = (EnGender)genderValue;
            var result = await _mediator.Send(command);


            if (!result.IsSuccess)  
                return BadRequest(result.ToResultDto());
            
            return Ok(result.ToResultDto(result.Value));
                //Match<IActionResult>(
                //    succ => Ok("Person Added Succesfully"),
                //    fail => BadRequest(result)
                //);    
        }


        [HttpDelete]
        [Route("{personId:int}")]
        public async Task<IActionResult> DeletePerson(int personId)
        {
            var query = new DeletePersonCommand(personId);

            var result = await _mediator.Send(query);

            if (result.IsFailed)
                return BadRequest(result.ToResultDto());

            return Ok(true);
        }

        [HttpPut]
        [Route("{personId:int}")]
        public async Task<IActionResult> UpdatePerson(
                    [FromForm] UpdatePersonCommand updatePersonCommand,
                    int personId)
        {
            updatePersonCommand.PersonId = personId;
            updatePersonCommand.Image = HandleImageFile(Request.Form.Files);
    
            var query = new UpdatePersonCommand(updatePersonCommand);

            var result = await _mediator.Send(query);

            if (result.IsFailed)
                return NotFound(result.ToResultDto());

            return Ok(result.ToResultDto());
        }
        private static byte[]? HandleImageFile (IFormFileCollection formFiles)
        {
            if (formFiles.Count == 0)
                return null;

            using var ms = new MemoryStream();
            formFiles[0].CopyTo(ms);

            return ms.ToArray();
        }
    
    }
}
