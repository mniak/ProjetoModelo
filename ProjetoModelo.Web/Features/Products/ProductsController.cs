using Microsoft.AspNetCore.Mvc;
using ProjetoModelo.Products;

namespace ProjetoModelo.Web.Features.Products
{
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        internal readonly IProductService service;

        public ProductsController(IProductService service)
        {
            this.service = service;
        }

        internal const string RouteGetById = nameof(ProductsController) + "." + nameof(RouteGetById);
        [HttpGet, Route("{id}", Name = RouteGetById)]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var product = await service.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            // TODO: Convert to API models if necessary
            return Ok(product);
        }

        [HttpGet, Route("")]
        public async Task<IActionResult> GetAllAsync()
        {
            var products = await service.GetAllAsync();
            // TODO: Convert to API models if necessary
            return Ok(products);
        }

        [HttpPost, Route("")]
        public async Task<IActionResult> SaveNewAsync([FromBody] Product product)
        {
            // TODO: Convert from API models if necessary
            var id = await service.SaveNewAsync(product);
            return CreatedAtRoute(RouteGetById, new
            {
                Id = id,
            });
        }

        [HttpPost, Route("{id}")]
        public async Task<IActionResult> SaveIntoId([FromRoute] int id, [FromBody] Product product)
        {
            // TODO: Convert from API models if necessary
            await service.SaveIntoIdAsync(id, product);
            return Ok(RouteGetById);
        }
    }
}
