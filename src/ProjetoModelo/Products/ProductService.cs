namespace ProjetoModelo.Products
{
    public class ProductService : IProductService
    {
        private readonly IProductByIdReader reader;

        public ProductService(IProductByIdReader reader)
        {
            this.reader = reader;
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            return reader.GetProductByIdAsync(id);
        }

        public Task SaveIntoIdAsync(int id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveNewAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}