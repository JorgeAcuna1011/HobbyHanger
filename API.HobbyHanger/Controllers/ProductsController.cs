using Domain.HobbyHanger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;

namespace API.HobbyHanger.Controllers
{
    public class ProductsController(HobbyHangerDbContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return await context.Products.ToListAsync();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetActivityDetail(string id)
        {
            var products = await context.Products.FindAsync(id);

            if (products == null) return NotFound();

            return products;
        }
    }
}