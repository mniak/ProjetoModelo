using ProjetoModelo.Web.Infra.Modules;
using ProjetoModelo.Web.Modules;

var modules = new List<IModule>(){
    new ApiModule(),
    new OpenTelemetryModule(),
};

var builder = WebApplication.CreateBuilder(args);
builder.AddModules(modules);

var app = builder.Build();
app.UseModules(modules);
app.Run();
