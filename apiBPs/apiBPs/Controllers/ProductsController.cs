using apiBPs.Prodotti;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace apiBPs.Controllers
{
    [Route("api/prodotti")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsRepository _productsRepo;
        public ProductsController(IProductsRepository productsRepo)
        {
            _productsRepo = productsRepo;
        }
        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await _productsRepo.GetProducts();
                return Ok(products);
            }
            catch (Exception ex)
            {
                //log error
                return StatusCode(500, ex.Message);
            }
        }
    }
}
