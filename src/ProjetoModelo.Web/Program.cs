using ProjetoModelo.Web.Infra.Modules;
using ProjetoModelo.Web.Modules;

var modules = new List<IModule>(){
    new ExceptionHandlingModule(),
    new ApiModule(),
    new ObservabilityModule(),
    new FeaturesModule(),
};

var builder = WebApplication.CreateBuilder(args);
builder.AddModules(modules);

var app = builder.Build();
app.UseModules(modules);
app.Run();