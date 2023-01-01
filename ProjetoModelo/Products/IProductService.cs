namespace ProjetoModelo.Products
{
    public interface IProductService
    {
        Task<Product> GetByIdAsync(int id);
        Task<IEnumerable<Product>> GetAllAsync();
        Task<int> SaveNewAsync(Product product);
        Task SaveIntoIdAsync(int id, Product product);
    }
}