using OpenTelemetry;
using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    public class OpenTelemetryModule : IModule
    {
        const string serviceName = "MyCompany.MyProduct.MyService";
        const string serviceVersion = "1.0.0";

        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            builder.Services.AddOpenTelemetry()
                .WithTracing()
                .WithMetrics()
                ;
        }

        public void UseInApp(WebApplication app)
        {
        }
    }
}
