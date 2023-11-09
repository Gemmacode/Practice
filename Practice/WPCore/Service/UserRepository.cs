using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WPCore.IService;

public class UserRepository : IUserRepository
{
    private readonly UserManager<IdentityUser> _userManager;

    public UserRepository(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IdentityUser> GetUserByIdAsync(string userId)
    {
        return await _userManager.FindByIdAsync(userId);
    }

    public async Task<IdentityUser> GetUserByEmailAsync(string email)
    {
        return await _userManager.FindByEmailAsync(email);
    }

    public async Task<IEnumerable<IdentityUser>> GetAllUsersAsync()
    {
        return await _userManager.Users.ToListAsync();
    }

    public async Task CreateUserAsync(IdentityUser user, string password)
    {
        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
        {
            throw new ApplicationException($"Unable to create user: {string.Join(", ", result.Errors)}");
        }
    }

    public async Task UpdateUserAsync(IdentityUser user)
    {
        var result = await _userManager.UpdateAsync(user);

        if (!result.Succeeded)
        {
            throw new ApplicationException($"Unable to update user: {string.Join(", ", result.Errors)}");
        }
    }

    public async Task DeleteUserAsync(string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user != null)
        {
            var result = await _userManager.DeleteAsync(user);

            if (!result.Succeeded)
            {
                throw new ApplicationException($"Unable to delete user: {string.Join(", ", result.Errors)}");
            }
        }
    }
}
