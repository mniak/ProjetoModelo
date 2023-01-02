namespace ProjetoModelo.Web.Infra.Modules
{
    internal interface IModule
    {
        void ConfigureBuilder(WebApplicationBuilder builder);
        void UseInApp(WebApplication app);
    }
}