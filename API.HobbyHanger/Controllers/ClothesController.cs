using Application.HobbyHanger.Clothing.Commands;
using Application.HobbyHanger.Clothing.Queries;
using Microsoft.AspNetCore.Mvc;
using Domain.HobbyHanger;

namespace API.HobbyHanger.Controllers
{
    public class ClothesController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Clothes>>> GetClothes()
        {
            return await Mediator.Send(new GetClothingList.Query());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Clothes>> GetClothing(string id)
        {
            return await Mediator.Send(new GetClothingDetails.Query{Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<string>> CreateClothes(Clothes clothes)
        {
            return await Mediator.Send(new CreateClothing.Command { Clothes = clothes});
        }

        [HttpPut]
        public async Task<ActionResult> EditClothes(Clothes clothes)
        {
            await Mediator.Send(new EditClothing.Command{Clothes = clothes});
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteClothes(string id)
        {
            await Mediator.Send(new DeleteClothing.Command { ProductId =  id});

            return Ok();
        }
    }
}