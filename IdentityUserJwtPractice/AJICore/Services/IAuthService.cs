using AJIDomain.Models;

namespace AJICore.Services
{
    public interface IAuthService
    {
        Task <bool>Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
    }
}