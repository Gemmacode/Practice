using AJIDomain.Models;

namespace AJICore.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUser(LoginUser user);
    }
}