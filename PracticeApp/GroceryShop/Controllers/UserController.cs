using GroceryShopCore.IServices;
using GroceryShopData.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceryShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost("CreateUser")]
        public IActionResult CreateNewUser(UserDTO userDTO)
        {
            _userRepository.CreateUser(userDTO);
            return Ok("User Created Successfully");
        }
        [HttpGet("Get-User-BY-Id")]
        public IActionResult GetUserById(string Id)
        {
           var User= _userRepository.GetUserById(Id);
            return Ok(User);
        }
        [HttpPut("DeleteUser")]
        public IActionResult DeleteUserById(string Id)
        {
            _userRepository.DeleteUser(Id);
            return Ok("User Deleted Successfully");
        }
        [HttpGet("GetAll")]
        public IActionResult GetAllUsers()
        {
           var users = _userRepository.GetAllUser();
            return Ok(users);
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUserById(string userId, UserDTO userDTO)
        {
            _userRepository.UpdateUser(userId, userDTO);
            return Ok("User updated successfully");
        }
    }
}
