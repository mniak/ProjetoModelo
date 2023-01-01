
using ProjetoModelo.Products;
using ProjetoModelo.Web.Features.Products;

namespace ProjetoModelo.Web.Tests.Features.Products
{
    public class ProductsControllerTests
    {
        [AutoData, Theory]
        public async Task TestGetByIdAsync_HappyScenario(
            Product product,
            ProductsController sut)
        {
            var result = await sut.GetByIdAsync(product.Id);
            result.As<OkObjectResult>()
                .Value.As<Product>()
                    .Should().Be(product);
        }
    }
}
