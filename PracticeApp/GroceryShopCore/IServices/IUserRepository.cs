using GroceryShopData.DTO;
using GroceryShopDomain.Entities;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopCore.IServices
{
    public interface IUserRepository
    {
        void CreateUser(UserDTO userDTO);
        User GetUserById(string Id);
        List<User> GetAllUser();
        User UpdateUser(string userid, UserDTO userDTO);
        void DeleteUser(string userId);


    }
}
