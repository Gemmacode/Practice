using GroceryShopCore.IServices;
using GroceryShopData.DTO;
using GroceryShopData.GSContext;
using GroceryShopDomain.Entities;

namespace GroceryShopCore.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly GSDbContext _db;

        public UserRepository(GSDbContext db)
        {
            _db = db;
        }

        public void CreateUser(UserDTO userDTO)
        {
            var result = new User()
            {
                Id= Guid.NewGuid().ToString(),
                Name = userDTO.Name,
                Password = userDTO.Password,
                Email = userDTO.Email,
                Address = userDTO.Address,
                PhoneNumber = userDTO.PhoneNumber,
                UpdatedAt= DateTime.UtcNow,
                CreatedAt= DateTime.UtcNow,
                IsDeleted = false,
            };
            _db.Users.Add(result);
            _db.SaveChanges();
        }

        public void DeleteUser(string userId)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == userId);
            if (user != null)
            {
                user.IsDeleted = true;
                _db.Users.Update(user);
                _db.SaveChanges();
            }
        }
        public List<User> GetAllUser()
        {
            var users = _db.Users.Where(x=>!x.IsDeleted).ToList();
            return users;
        }
        public User GetUserById(string Id)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == Id && !x.IsDeleted);
            return user ?? throw new ArgumentNullException("User not found");
        }
        public User UpdateUser(string userId, UserDTO userDTO)
        {
            var user = _db.Users.FirstOrDefault(x => x.Id == userId);
            if (user == null)
                throw new Exception("user not found");
            else
                user.Name = userDTO.Name;
                user.Password = userDTO.Password;
                user.Email = userDTO.Email;
                user.Address = userDTO.Address;
                user.PhoneNumber = userDTO.PhoneNumber;
                user.UpdatedAt = DateTime.Now;
                _db.Users.Update(user);
                _db.SaveChanges();

                return user;



        }
    }
}
