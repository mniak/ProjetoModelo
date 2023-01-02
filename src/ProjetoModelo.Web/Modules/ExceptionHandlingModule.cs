using Microsoft.AspNetCore.Mvc;
using ProjetoModelo.Web.Infra.ExceptionHandling;
using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    internal class ExceptionHandlingModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            builder.Services.PostConfigure<MvcOptions>(o =>
            {
                o.Filters.Add<ExceptionFilter>();
            });
        }

        public void UseInApp(WebApplication app) { }
    }
}