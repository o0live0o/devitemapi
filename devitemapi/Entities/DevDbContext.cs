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

        public virtual DbSet<DevMenu> DevMenus { get; set; }

        public virtual DbSet<DevUser> DevUsers { get; set; }

        public virtual DbSet<DevRole> DevRoles { get; set; }

        public virtual DbSet<DevAction> DevActions { get; set; }

        public virtual DbSet<DevMenuAction> DevMenuActions { get; set; }

        public virtual DbSet<DevRolePermission> DevRolePermissions { get; set; }

        public virtual DbSet<DevUserRole> DevUserRoles { get; set; }
    }
}
