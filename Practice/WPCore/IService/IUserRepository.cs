using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPCore.IService
{
    public interface IUserRepository
    {
        Task<IdentityUser> GetUserByIdAsync(string userId);
        Task<IdentityUser> GetUserByEmailAsync(string email);
        Task<IEnumerable<IdentityUser>> GetAllUsersAsync();
        Task CreateUserAsync(IdentityUser user, string password);
        Task UpdateUserAsync(IdentityUser user);
        Task DeleteUserAsync(string userId);
    }
}
