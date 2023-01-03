using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Trace;
using ProjetoModelo.Web.Infra.Modules;
using Serilog;

namespace ProjetoModelo.Web.Modules
{
    internal class ObservabilityModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            var serilogLogger = new LoggerConfiguration()
                .WriteTo.Console()
                .CreateLogger();
                
            builder.Services.AddLogging(b =>
            {
                b.ClearProviders();
                b.AddSerilog(serilogLogger);
                b.AddOpenTelemetry(o =>
                {
                    o.AddOtlpExporter();
                });
            });

            builder.Services.AddOpenTelemetry()
                .WithTracing(b =>
                {
                })
                .WithMetrics(b =>
                {

                })
                ;
        }

        public void UseInApp(WebApplication app)
        {
        }
    }
}