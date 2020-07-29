using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevDbContext : DbContext
    {
        public DevDbContext(DbContextOptions options) : base(options)
        {

        }

     //   public DbSet<DevMenu> DevMenus { get; set; }

        public DbSet<DevUser> DevUsers { get; set; }
    }
}
