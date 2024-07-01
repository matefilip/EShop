using Eshop.Domain.Models.Order;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [ApiController]
    [Route("api/v1/Orders")]
    public class OrdersController : ControllerBase
    {
        //TODO Implement controller
        [HttpGet("GetFlatOrders")]
        public async Task<ActionResult<IEnumerable<Order>>> GetFlatOrders()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpGet("GetOrderById/{id}")]
        public async Task<ActionResult<Order>> GetOrderById(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpPost("AddOrder")]
        public async Task<ActionResult<Order>> AddOrder()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpDelete("DeleteOrder/{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }
    }
}
