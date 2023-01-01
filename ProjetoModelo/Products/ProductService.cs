namespace ProjetoModelo.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductByIdReader reader;

        public ProductService(IProductByIdReader reader)
        {
            this.reader = reader;
        }
        public Task<Product> GetByIdAsync(int id)
        {
            return reader.GetProductByIdAsync(id);
        }
    }
}
