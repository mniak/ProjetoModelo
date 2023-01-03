using System.Data;
using ProjetoModelo.Products;

namespace ProjetoModelo.Infrastructure.MSSQL.Products
{
    public class ProductRepository : IProductByIdReader
    {
        private readonly IDbConnection db;

        public ProductRepository(IDbConnection db)
        {
            this.db = db ?? throw new ArgumentNullException(nameof(db));
        }
        public async Task<Product> GetProductByIdAsync(int id)
        {
            var result = await db.QueryFirstAsync<Product>("select * from products where id = ?");
            return result;
        }
    }
}