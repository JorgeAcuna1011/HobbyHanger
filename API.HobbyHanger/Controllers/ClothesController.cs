using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.HobbyHanger;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;

namespace API.HobbyHanger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClothesController(HobbyHangerDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Clothe>>> GetClothes()
        {
            return await context.Clothes.ToListAsync();
        }
    }
}