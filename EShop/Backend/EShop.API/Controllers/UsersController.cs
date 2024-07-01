using Eshop.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [ApiController]
    [Route("api/v1/Users")]
    public class UsersController : ControllerBase
    {
        //TODO Implement controller
        [HttpGet("GetUserById/{id}")]
        public async Task<ActionResult<User>> GetUserById(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpPost("CreateUser")]
        public async Task<ActionResult<User>> CreateUser()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult<User>> DeleteUser(Guid id)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }
    }
}
