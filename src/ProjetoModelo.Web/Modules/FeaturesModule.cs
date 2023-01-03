using System.Data;
using Microsoft.Data.SqlClient;
using ProjetoModelo.Infrastructure.MSSQL.Products;
using ProjetoModelo.Products;
using ProjetoModelo.Web.Infra.Modules;

namespace ProjetoModelo.Web.Modules
{
    internal class FeaturesModule : IModule
    {
        public void ConfigureBuilder(WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("Default");
            builder.Services.AddSingleton<IDbConnection, SqlConnection>( x => new SqlConnection(connectionString));


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