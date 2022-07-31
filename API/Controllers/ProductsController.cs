using Core.Etities;
using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase {
        private readonly StoreContext _context;
        private readonly IProductRepository productRepository;

        public ProductsController(StoreContext context, IProductRepository productRepository)
        {
            this._context = context;
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() {
            var products = await this.productRepository.GetProductsAsync();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id) {
            return await this.productRepository.GetProductByIdAsync(id);
        }
    }
}