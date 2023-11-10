using AJICore.Services;
using AJIDomain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AJIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost("RegisterUser")]
        public async Task<bool>RegisterUser(LoginUser user)
        {
            return await _authService.RegisterUser(user);
        }

        [HttpGet("Login")]
        public async Task<IActionResult> Login (LoginUser user)
        {
            if (await _authService.Login(user))
            {
                return Ok("Login Successful");
            }
            return BadRequest();
        }
    }
}
