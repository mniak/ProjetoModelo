using ProjetoModelo.Products;

namespace ProjetoModel.Infrastructure.MSSQL.Products
{
    internal class ProductRepository : IProductByIdReader
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
