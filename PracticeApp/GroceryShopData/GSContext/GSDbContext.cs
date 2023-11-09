using GroceryShopDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryShopData.GSContext
{
    public class GSDbContext : DbContext
    {
        public GSDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User>Users { get; set; }
        public DbSet<Product> Products { get; set; }    

    }
}
