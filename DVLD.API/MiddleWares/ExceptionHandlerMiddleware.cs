using DLVD.App.Common;
using DLVD.App.Common.Errors;
using DVLD.Domain.Exceptions.Persons;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;
using System.Threading.Tasks;

namespace DVLD.API.MiddleWares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlerMiddleware> _logger;
        private readonly IDictionary<Type, Action<UnExpectedErrorResponse, Exception>> _ExceptionHnadllers;

        public ExceptionHandlerMiddleware(
            ILogger<ExceptionHandlerMiddleware> logger,
            RequestDelegate next)
        {
            _next = next;
            _logger = logger;
            _ExceptionHnadllers = new Dictionary<Type, Action<UnExpectedErrorResponse, Exception>>()
            {
                { typeof(PersonNotFound) , HandlePersonNotFoundException}
            };
        }


        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }

            catch (Exception ex)
            {
                    
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private void HandlePersonNotFoundException(UnExpectedErrorResponse errorResponse, Exception exception)
        {
            _logger.LogError($"exception Usr Not Found {exception.Message} on {DateTime.Now}");
            errorResponse.erroMsg = exception.Message;
            errorResponse.StatusCode = System.Net.HttpStatusCode.NotFound;
        }


        private  async Task HandleExceptionAsync(HttpContext httpContext, Exception ex)
        {
            var errorResponse = new UnExpectedErrorResponse();

            Type exType = ex.GetType();
            if (_ExceptionHnadllers.ContainsKey(exType))
                _ExceptionHnadllers[exType].Invoke(errorResponse, ex);
            else
                HandleUnExpectedException(errorResponse, ex);

            var ser = JsonSerializer.Serialize(errorResponse);
            //httpContext.Response.StatusCode = (int)errorResponse.StatusCode;
            await httpContext.Response.WriteAsync(ser);
            return;
        }

        private void HandleUnExpectedException(UnExpectedErrorResponse errorResponse, Exception ex)
        {
            errorResponse.erroMsg = "Something Went Wrong Please Retry in Couple Minuates";
            errorResponse.StatusCode = System.Net.HttpStatusCode.InternalServerError;
        }
    }
   
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandlerMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
