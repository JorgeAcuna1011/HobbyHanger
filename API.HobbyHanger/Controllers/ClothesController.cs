using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Domain.HobbyHanger;
using Microsoft.EntityFrameworkCore;
using Persistence.HobbyHanger;

namespace API.HobbyHanger.Controllers
{
    public class ClothesController(HobbyHangerDbContext context) : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Clothes>>> GetClothes()
        {
            return await context.Clothes
                .Include(x => x.Measurements)
                .ToListAsync();
        }
    }
}