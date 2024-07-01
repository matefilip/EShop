using Eshop.Domain.Models.Item;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [ApiController]
    [Route("api/v1/Items")]
    public class ItemsController : ControllerBase
    {
        //TODO Implement controller
        [HttpGet("GetFlatItems")]
        public async Task<ActionResult<IEnumerable<Item>>> GetFlatItems()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpGet("GetItemById/{id}")]
        public async Task<ActionResult<Item>> GetItemById(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpPost("AddItem")]
        public async Task<ActionResult<Item>> AddItem()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpDelete("DeleteItem/{id}")]
        public async Task<ActionResult<Item>> DeleteItem(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }
    }
}
