using OpenTelemetry;
using OpenTelemetry.Logs;
using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    internal class OpenTelemetryModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            builder.Services.AddLogging(b =>
            {
                b.AddOpenTelemetry(o => {
                    o.AddOtlpExporter();
                });
            });

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