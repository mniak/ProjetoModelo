using NSubstitute;
using NSubstitute.ReturnsExtensions;
using ProjetoModelo.Products;
using ProjetoModelo.Web.Features.Products;

namespace ProjetoModelo.Web.Tests.Features.Products
{
    public class ProductsControllerTests
    {
        [AutoData, Theory]
        public void TestGuardClauses(GuardClauseAssertion assertion)
        {
            assertion.Verify(typeof(ProductsController).GetConstructors());
        }

        [AutoData, Theory]
        public async Task TestGetByIdAsync_HappyScenario(
            Product product,
            ProductsController sut)
        {
            sut.service.GetByIdAsync(product.Id).Returns(product);

            var result = await sut.GetByIdAsync(product.Id);
            result.As<OkObjectResult>()
                .Value.As<Product>()
                    .Should().Be(product);
        }

        [AutoData, Theory]
        public async Task TestGetByIdAsync_WhenNotFound(
            Product product,
            ProductsController sut)
        {
            sut.service.GetByIdAsync(product.Id).ReturnsNull();

            var result = await sut.GetByIdAsync(product.Id);
            result.As<NotFoundResult>();
        }

        [AutoData, Theory]
        public async Task TestGetAllAsync_HappyScenario(
            IEnumerable<Product> products,
            ProductsController sut)
        {
            sut.service.GetAllAsync().Returns(products);

            var result = await sut.GetAllAsync();
            result.As<OkObjectResult>()
                .Value.As<IEnumerable<Product>>()
                    .Should().BeEquivalentTo(products);
        }

        [AutoData, Theory]
        public async Task TestSaveNewAsync_HappyScenario(
          Product product,
          int newId,
          ProductsController sut)
        {
            sut.service.SaveNewAsync(product).Returns(newId);

            var result = await sut.SaveNewAsync(product);
            var actionResult = result.As<CreatedAtRouteResult>();
            actionResult.RouteName.Should().Be(ProductsController.RouteGetById);
            actionResult.Value.As<ProductIdObject>().Id.Should().Be(newId);
        }


        [AutoData, Theory]
        public async Task TestSaveIntoIdAsync_HappyScenario(
          Product product,
          int id,
          ProductsController sut)
        {
            await sut.service.SaveIntoIdAsync(id, product);

            var result = await sut.SaveIntoIdAsync(id, product);
            result.As<OkResult>();
        }
    }
}
