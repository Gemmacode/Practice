using AJIDomain.Models;

namespace AJICore.Services
{
    public interface IAuthService
    {
        string GenerateTokenString(LoginUser user);
        Task <bool>Login(LoginUser user);
        Task<bool> RegisterUser(LoginUser user);
    }
}