using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entity
{
    public class DevDbContext : DbContext
    {
        public DevDbContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<nlogrec> Nlogrecs { get; set; }
        public virtual DbSet<DevMenu> DevMenus { get; set; }

        public virtual DbSet<DevUser> DevUsers { get; set; }

        public virtual DbSet<DevRole> DevRoles { get; set; }

        public virtual DbSet<DevAction> DevActions { get; set; }

        public virtual DbSet<DevMenuAction> DevMenuActions { get; set; }

        public virtual DbSet<DevRolePermission> DevRolePermissions { get; set; }

        public virtual DbSet<DevUserRole> DevUserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DevUser>().HasData(
                new DevUser { Id = Guid.Parse("BC9E5615-17D5-4CA2-ADF9-200F903E0A7D"),UserName="超级管理员",Account="Administrator",Pwd="123456",Status = 1,CreateDate = DateTime.Now,ModifyDate = DateTime.Now }
                );
            modelBuilder.Entity<DevRole>().HasData(
                new DevRole { Id = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"), RoleName = "超级管理员",Status = 1, CreateDate = DateTime.Now, ModifyDate = DateTime.Now },
                new DevRole { Id = Guid.Parse("78D6D23B-64C1-4D23-B766-A19276BE3D1C"), RoleName = "管理员",Status = 1, CreateDate = DateTime.Now, ModifyDate = DateTime.Now }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
