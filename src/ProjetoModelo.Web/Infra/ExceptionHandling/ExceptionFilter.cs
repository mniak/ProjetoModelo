using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjetoModelo.Web.Infra.ExceptionHandling
{
    internal class ExceptionFilter : IAsyncExceptionFilter
    {
        private readonly ILogger logger;

        public ExceptionFilter(ILogger<ExceptionFilter> logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public Task OnExceptionAsync(ExceptionContext context)
        {
            switch (context.Exception)
            {
                default:
                    context.Result = new ObjectResult(new ErrorModel("Unknown error"))
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                    };
                    logger.LogError(context.Exception, "Unexpected error. Returning status 500.");
                    break;
            }
            if (context.Result != null)
            {
                context.ExceptionHandled = true;
            }
            return Task.CompletedTask;
        }
    }
}
