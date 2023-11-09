using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WPCore.IService;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public IActionResult GetAllUsers()
    {
        var users = _userRepository.GetAllUsersAsync().Result;
        return Ok(users);
    }

    [HttpGet("{userId}")]
    public IActionResult GetUserById(string userId)
    {
        var user = _userRepository.GetUserByIdAsync(userId).Result;
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody] IdentityUser user, string password)
    {
        _userRepository.CreateUserAsync(user, password).Wait();
        return CreatedAtAction(nameof(GetUserById), new { userId = user.Id }, user);
    }

    [HttpPut("{userId}")]
    public IActionResult UpdateUser(string userId, [FromBody] IdentityUser user)
    {
        _userRepository.UpdateUserAsync(user).Wait();
        return NoContent();
    }

    [HttpDelete("{userId}")]
    public IActionResult DeleteUser(string userId)
    {
        _userRepository.DeleteUserAsync(userId).Wait();
        return NoContent();
    }
}
