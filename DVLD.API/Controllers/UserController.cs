using AutoMapper;
using DLVD.App.Features.Users.Commands.CreateUser;
using DLVD.App.Features.Users.Commands.UpdateUser;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using DLVD.App.Features.Users.Queires.GetUsersList;
using FluentResults.Samples.WebController;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DVLD.WEB.Controllers
{

    [Authorize]
    public class UserController : BaseControllerr
    {
     
        private readonly ILogger<UserController> _logger;
        public UserController(IMapper mapper,
                    IMediator mediator,
                    ILogger<UserController> logger):base(mapper, mediator)
        {
            _logger = logger;
        }


        [HttpGet]
        [Route("{userId:int}")]
        //[Authorize]
        public async Task<IActionResult> GetUser(int userId)
        {
            if (!ModelState.IsValid)
                return BadRequest("Something Went Wrong");
 
            var query = new GetUserQuery(userId);
             
            var Result = await _mediator.Send(query);

            if (Result.IsFailed)
                return NotFound(Result.ToResultDto(false));
            
            return Ok(Result.ToResultDto(Result.ValueOrDefault));
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> GetPaginatedUsers([FromQuery] GetUsersListQuery query)
        {

            if (!ModelState.IsValid)
                return BadRequest("Something Went Wrong");

            var Result = await _mediator.Send(query);

            return  Ok(Result.ToResultDto(Result.ValueOrDefault));
        }


        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand user)
        {
            var Result = await _mediator.Send(user);

            if (!Result.IsFailed)
                return BadRequest(Result.ToResultDto("Something Went Wrong"));
            return NoContent();
        }

        [HttpPut]
        [Route("")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand user)
        {
            if (!ModelState.IsValid)
                return BadRequest("SomeThing Went Wrong");

            var Result = await _mediator.Send(user);

            if (Result.IsFailed)
                return BadRequest(Result.ToResultDto("SomeThing Went Wrong"));
            return NoContent();

        }
    }
}
