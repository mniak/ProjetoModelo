using ProjetoModelo.Products;

namespace ProjetoModelo.Infrastructure.MSSQL.Products
{
    public class ProductRepository : IProductByIdReader
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}