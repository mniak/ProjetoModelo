namespace ProjetoModelo.Web.Infra.Modules
{
    internal static class ModuleExtensions
    {
        public static void AddModules(this WebApplicationBuilder builder, IEnumerable<IModule> modules)
        {
            foreach (var module in modules)
            {
                module.ConfigureBuilder(builder);
            }
        }

        public static void UseModules(this WebApplication app, IEnumerable<IModule> modules)
        {
            foreach (var module in modules)
            {
                module.UseInApp(app);
            }
        }
    }
}