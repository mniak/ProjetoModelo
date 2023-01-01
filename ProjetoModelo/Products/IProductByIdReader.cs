namespace ProjetoModelo.Products
{
    public interface IProductByIdReader
    {
        public Task<Product> GetProductByIdAsync(int id);
    }
}