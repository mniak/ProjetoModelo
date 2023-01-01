﻿using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    public class ApiModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
        }

        public void UseInApp(WebApplication app)
        {
            app.UseAuthorization();
            app.MapControllers();
        }
    }
}
