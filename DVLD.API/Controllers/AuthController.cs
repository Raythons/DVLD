using AutoMapper;
using DVLD.API.Config;
using DVLD.WEB.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Security.Claims;
using DLVD.App.Features.Users.Queires.GetUserQuery;
using FluentResults.Samples.WebController;
using DLVD.App.Features.Users.Commands.AuthenticateUserCommand;
using DVLD.Domain.Entities;
using DLVD.App.Features.Users.Commands.CreateRefreshToken;
using FluentResults;
using DVLD.App.Interfaces.Persistence;
using System.Net;

namespace DVLD.API.Controllers
{
    public class AuthController : BaseControllerr
    {
        private readonly JwtConfig _jwtConfig;
        private readonly TokenValidationParameters _tokenValidationParameters;
        private readonly IUnitOfWork _unitOfWork;
        public AuthController(
            IMapper mapper, 
            IMediator mediator,
            JwtConfig jwtConfig,
            TokenValidationParameters tokenValidationParameters,
            IUnitOfWork unitOfWork) : base(mapper, mediator)
        {
            _jwtConfig = jwtConfig;
            _tokenValidationParameters = tokenValidationParameters;
            _unitOfWork = unitOfWork;

        }

        [HttpPost]
        [Route("log-in")]
        public async Task<IActionResult> LogIn([FromBody] AuthenticateUserCommand userData)
        {
            var result = await _mediator.Send(userData);
            if (result.IsFailed)
                return Unauthorized(result.ToResultDto(false));
            
            //if (!Result.Value.UserName.Equals(userData.UserName, StringComparison.OrdinalIgnoreCase) && 
            //     Result.Value.Id  == userData.Id) 

            //    return Unauthorized(Result.ToResultDto(false));
            
            var securityTokenId = Guid.NewGuid().ToString();
        
            var accessToken =  GenerateJwtToken(result.Value, securityTokenId);

            if (string.IsNullOrEmpty(accessToken))
                return Unauthorized("Error Happened");

            var RefreshToken = new RefreshToken()
            {
                JwtId = securityTokenId,
                Token = GenerateRandomString(64),
                CreatedOn = DateTime.UtcNow,
                ExpiresOn = DateTime.UtcNow.AddMonths(6),
                RevokedOn = null,
                UserId = result.Value.Id
            };

            var createRefreshTokenResult = await _mediator
                                        .Send(new CreateRefreshTokenCommand(RefreshToken));

            if (createRefreshTokenResult.IsFailed)
                return Unauthorized(createRefreshTokenResult.ToResultDto(createRefreshTokenResult.ValueOrDefault));

            setRefreshToken(RefreshToken);

            var gg = new
            {
                result.Value.UserName,
                result.Value.Image,
                accessToken
            };

            return Ok(gg);
        }
      
        
        private  void setRefreshToken(RefreshToken refreshToken)
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,
                Expires = refreshToken.ExpiresOn,
                Secure = true,
                Path = "/"
            };
             Response.Cookies.Append("refreshToken", refreshToken.Token, cookieOptions);
             //Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:5173/");

        }


        [HttpGet]
        [Route("Refresh")]
        public async Task<IActionResult> RefreshToken([FromHeader] string authorization)
        {
            Console.WriteLine(authorization);
            authorization = authorization.Split(" ")[1];
            Console.WriteLine("--------------------Splited Token ------------------");
            Console.WriteLine(authorization);
            Console.WriteLine("--------------------Splited Token ------------------");


            string refreshTokenVal = Request.Cookies.FirstOrDefault(x => x.Key == "refreshToken").Value;
            Console.WriteLine($"refresh :  @@@#@#@#@{refreshTokenVal}");
            var result = await VerifyRefreshAndGenerateAccess(refreshTokenVal, authorization);

            Console.WriteLine($"result is : {result}");
            Console.WriteLine($"------------------------------------------------------------");
            Console.WriteLine($"result Value  is : {result.ValueOrDefault}");

            if (result.IsFailed)
               return Unauthorized(result.ToResultDto(result.Errors));

            return Ok(result.ToResultDto(result.Value));
        }

        private async Task<Result<string>> VerifyRefreshAndGenerateAccess(string refreshToken, string accessToken)
        {
            var jwtTokenHandler =  new JwtSecurityTokenHandler();

            try
            {
                _tokenValidationParameters.ValidateLifetime = false;

                var tokenInVerification = jwtTokenHandler.
                                ValidateToken(accessToken, _tokenValidationParameters, out var validedToken);

                if (validedToken is JwtSecurityToken jwtSecurityToken)
                {
                    var result = jwtSecurityToken.Header.Alg
                        .Equals(SecurityAlgorithms.HmacSha256, StringComparison.OrdinalIgnoreCase);

                    if (result == false)
                        return null;
                }

                //var UtcExpiryDate = long.Parse(tokenInVerification.Claims
                //                    .FirstOrDefault(t => t.Type == JwtRegisteredClaimNames.Exp)!.Value);

                //var expiryDate = unixTimeStampToDateTime(UtcExpiryDate);
    
                
                var storedToken = await _unitOfWork.RefreshTokenRepositry.GetById(refreshToken);

                if (storedToken is null || !(storedToken.IsActive))
                    return Result.Fail("Invalid Token");        

                var jti = tokenInVerification.Claims.
                    FirstOrDefault(x => x.Type == JwtRegisteredClaimNames.Jti)?.Value;

                if (storedToken.JwtId != jti)
                    return Result.Fail("JwtId Problem");

                await _unitOfWork.CompleteAsync();

                var user = await _mediator.Send(new GetUserQuery(storedToken.UserId));
                
                return  Result.Ok(GenerateJwtToken(
                    new AuthenticateUserResponse(user.Value.userName, user.Value.Id), storedToken.JwtId));

            }
            catch (Exception)
            {

                throw;
            }
        }

          
        private static DateTime unixTimeStampToDateTime(long unixTimeStamp)
        {
            var dateTimeVal = new DateTime(1970,1 ,1, 0,0,0,0,DateTimeKind.Utc);
            dateTimeVal.AddSeconds(unixTimeStamp).ToUniversalTime();

            return dateTimeVal;
        }
        
        private   string GenerateJwtToken(
            AuthenticateUserResponse userData, string securityJwtId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Issuer = _jwtConfig.Issuer,
                Audience = _jwtConfig.Auidiance,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_jwtConfig!.Secret)),
                    SecurityAlgorithms.HmacSha256),
                
                Subject = new ClaimsIdentity(new Claim[] {
                    new(ClaimTypes.NameIdentifier, userData.Id.ToString()),
                    new(ClaimTypes.Name, userData.UserName),
                    new (JwtRegisteredClaimNames.Jti, securityJwtId),
                    new (JwtRegisteredClaimNames.Iat, DateTime.Now.ToUniversalTime().ToString())
                }),
                Expires = DateTime.UtcNow.Add(_jwtConfig.ExpireTime),
            };

           var securityToken = tokenHandler.CreateToken(tokenDescriptor);

           var accessToken = tokenHandler.WriteToken(securityToken);

           return accessToken;
        }
        
        private static string GenerateRandomString(int length) {

            var random = new Random();

            var chars = "ABCDEFGHIJKLMNOBQUSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz_";

            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length - 1)]).ToArray()); 
            //return new string(Enumerable.Repeat(chars, length));

        }
    }
}
