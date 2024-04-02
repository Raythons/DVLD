using System.Diagnostics;

namespace DVLD.API.MiddleWares
{
    public class ProfillingMiddleWare
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<ProfillingMiddleWare> _logger;

        public ProfillingMiddleWare(
            RequestDelegate next,
            ILogger<ProfillingMiddleWare> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            await _next(context);
            stopWatch.Stop();
            _logger.LogInformation($"Request `{context.Request.Path}` took `{stopWatch.ElapsedMilliseconds}` ");
        
        }

    }
}
