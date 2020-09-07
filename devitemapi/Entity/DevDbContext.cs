using Microsoft.EntityFrameworkCore;
using System;

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

        public virtual DbSet<DevPermission> DevPermissions { get; set; }

        public virtual DbSet<DevUserRole> DevUserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DevUser>().HasData(
                new DevUser { Id = Guid.Parse("BC9E5615-17D5-4CA2-ADF9-200F903E0A7D"), UserName = "超级管理员", Account = "Administrator", Pwd = "123456", Status = 1, CreateDate = DateTime.Now, ModifyDate = DateTime.Now }
                );
            modelBuilder.Entity<DevRole>().HasData(
                new DevRole { Id = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"), RoleName = "超级管理员", RoleCode = "SuperAdmin", Status = 1, CreateDate = DateTime.Now, ModifyDate = DateTime.Now },
                new DevRole { Id = Guid.Parse("78D6D23B-64C1-4D23-B766-A19276BE3D1C"), RoleName = "管理员", Status = 1, RoleCode = "Admin", CreateDate = DateTime.Now, ModifyDate = DateTime.Now }
                );
            modelBuilder.Entity<DevUserRole>().HasData(
                    new DevUserRole { Id = Guid.Parse("{C9372AE7-EBD4-4C4B-9E64-F55965D35E78}"), RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"), Useid = Guid.Parse("BC9E5615-17D5-4CA2-ADF9-200F903E0A7D") }
                );

            modelBuilder.Entity<DevPermission>().HasData(
                    new DevPermission
                    {
                        Id = Guid.Parse("{C9372AE7-EBD4-4C4B-9E64-F55965D35E78}"),
                        MemuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
                        RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
                        ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                    },
                    new DevPermission
                    {
                        Id = Guid.Parse("{028D9D91-2F5F-4503-803C-8296C4BAE426}"),
                        MemuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
                        RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
                        ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
                    }
                    ,
                    new DevPermission
                    {
                        Id = Guid.Parse("{E55C31BA-E4FC-4682-A4AD-B5EEE06D2B3B}"),
                        MemuId = Guid.Parse("{DAF50AD9-C46B-43DE-AAB2-CA4418785BA3}"),
                        RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
                        ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
                    }
                );

            modelBuilder.Entity<DevMenu>().HasData(
                    new DevMenu
                    {
                        Id = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
                        MenuName = "首页",
                        MenuCode = "Index",
                        Icon = "/item.ico",
                        Url = "localhost:8080",
                        ParentId = 0
                    },
                    new DevMenu
                    {
                        Id = Guid.Parse("{DAF50AD9-C46B-43DE-AAB2-CA4418785BA3}"),
                        MenuName = "关于",
                        MenuCode = "About",
                        Icon = "/item.ico",
                        Url = "localhost/about:8080",
                        ParentId = 0
                    }
                );

            modelBuilder.Entity<DevAction>().HasData(
                    new DevAction
                    {
                        Id = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                        ActionCode = "Query",
                        ActionName = "查询"
                    },
                    new DevAction
                    {
                        Id = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
                        ActionCode = "Add",
                        ActionName = "增加"
                    },
                    new DevAction
                    {
                        Id = Guid.Parse("{39579C2F-7F92-4CD0-BF51-76A7A01C8E16}"),
                        ActionCode = "Delete",
                        ActionName = "删除"
                    }
                );

            base.OnModelCreating(modelBuilder);
        }
    }
}