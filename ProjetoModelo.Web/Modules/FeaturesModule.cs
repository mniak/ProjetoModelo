using ProjetoModelo.Infrastructure.MSSQL.Products;
using ProjetoModelo.Products;
using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    internal class FeaturesModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            builder.Services
                .AddSingleton<IProductService, ProductService>()
                .AddSingleton<IProductByIdReader, ProductRepository>()
                ;
        }

        public void UseInApp(WebApplication app)
        {
        }
    }
}