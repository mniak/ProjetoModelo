using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjetoModelo.Web.Infra.ExceptionHandling
{
    internal class ExceptionFilter : IAsyncExceptionFilter
    {
        public Task OnExceptionAsync(ExceptionContext context)
        {
            switch (context.Exception)
            {
                default:
                    context.Result = new ObjectResult(new ErrorModel("Unknown error"))
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                    };
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
