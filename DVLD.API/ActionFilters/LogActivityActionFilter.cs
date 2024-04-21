using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace DVLD.API.ActionFilters
{
    public class LogActivityActionFilter : IActionFilter, IAsyncActionFilter
    {
        private readonly ILogger<LogActivityActionFilter> _logger;

        public LogActivityActionFilter(ILogger<LogActivityActionFilter> logger)
        {
            _logger = logger;
        }

       
        public void OnActionExecuting(ActionExecutingContext context)
        {
            
           _logger.LogInformation($"Args {JsonSerializer.Serialize(context.ActionArguments)}  ||" +
               $" Controller =>  {context.Controller} ||  Name Desc {context.ActionDescriptor.DisplayName}");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation($"{nameof(LogActivityActionFilter)} OnActionExecuted ");

        }
        
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {

            _logger.LogInformation($"(ASYNCC)Args {JsonSerializer.Serialize(context.ActionArguments)}||" +
                $" Controller =>  {context.Controller} ||" +
                $"  Name Desc {context.ActionDescriptor.DisplayName}");
            await  next(); 
            _logger.LogInformation($"After Ended");
        }
    }
}
