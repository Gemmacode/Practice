using AJIDomain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AJIData.Context
{
    public class AJIDbContext : IdentityDbContext
    {
        public AJIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee>Employees { get; set; }
    }
}
