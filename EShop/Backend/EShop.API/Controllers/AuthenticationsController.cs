using Microsoft.AspNetCore.Mvc;

namespace EShop.API.Controllers
{
    [ApiController]
    [Route("api/v1/Auth")]
    public class AuthenticationsController : ControllerBase
    {
        //TODO Implement controller
        [HttpGet("Login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginModel)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }

        [HttpGet("RefreshToken")]
        public async Task<IActionResult> RefreshToken([FromBody] RefreshTokenModel refreshTokenModel)
        {
            await Task.Delay(0);
            throw new NotImplementedException();
        }
    }
}
