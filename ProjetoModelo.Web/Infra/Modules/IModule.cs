namespace ProjetoModelo.Web.Infra.Modules
{
    public interface IModule
    {
        void ConfigureBuilder(WebApplicationBuilder builder);
        void UseInApp(WebApplication app);
    }
}
