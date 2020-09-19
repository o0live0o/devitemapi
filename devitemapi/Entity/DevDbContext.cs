using Microsoft.EntityFrameworkCore;
using System;

namespace devitemapi.Entity
{
    public class DevDbContext : DbContext
    {
        public DevDbContext(DbContextOptions<DevDbContext> options) : base(options)
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
            // modelBuilder.Entity<DevRole>().OwnsOne(p=>p.DevPermissions,pe => {
            //     pe.WithOwner().HasForeignKey("RoleId");
            // });
            // modelBuilder.Entity<DevRole>(m=>{
            //     m.HasMany(u => u.DevPermissions).WithOne().HasForeignKey(u => u.RoleId);
            // });

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

            // modelBuilder.Entity<DevPermission>().HasData(
            //         new DevPermission
            //         {
            //             Id = Guid.Parse("{C9372AE7-EBD4-4C4B-9E64-F55965D35E78}"),
            //             MenuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
            //             RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
            //             ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
            //         },
            //         new DevPermission
            //         {
            //             Id = Guid.Parse("{028D9D91-2F5F-4503-803C-8296C4BAE426}"),
            //             MenuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
            //             RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
            //             ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
            //         }
            //         ,
            //         new DevPermission
            //         {
            //             Id = Guid.Parse("{E55C31BA-E4FC-4682-A4AD-B5EEE06D2B3B}"),
            //             MenuId = Guid.Parse("{DAF50AD9-C46B-43DE-AAB2-CA4418785BA3}"),
            //             RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
            //             ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
            //         }
            //         ,
            //         new DevPermission
            //         {
            //             Id = Guid.Parse("{F93A453E-A93D-4314-803D-FE586C119BCD}"),
            //             MenuId = Guid.Parse("{A5E189C0-166A-4B37-93EE-45ECF1FF11C5}"),
            //             RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A")
            //         }
            //         ,
            //         new DevPermission
            //         {
            //             Id = Guid.Parse("{3E41C160-9781-4818-AFB5-3D33455AB754}"),
            //             MenuId = Guid.Parse("{1CE75274-4033-4081-88D0-6BA7EF00FDDD}"),
            //             RoleId = Guid.Parse("557B25CC-463D-4116-9D7D-5003D6ACBF6A"),
            //             ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
            //         }
            //     );

            modelBuilder.Entity<DevMenu>().HasData(
                    new DevMenu
                    {
                        Id = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}"),
                        MenuName = "首页",
                        MenuCode = "Index",
                        Icon = "/item.ico",
                        Path = "localhost:8080",
                        ParentId = Guid.Parse("{EDC8F6C4-D734-49CF-9250-759D966E8641}")
                    },
                    new DevMenu
                    {
                        Id = Guid.Parse("{DAF50AD9-C46B-43DE-AAB2-CA4418785BA3}"),
                        MenuName = "关于",
                        MenuCode = "About",
                        Icon = "/item.ico",
                        Path = "localhost/about:8080",
                        ParentId = Guid.Parse("{EDC8F6C4-D734-49CF-9250-759D966E8641}") 
                    },
                    new DevMenu
                    {
                        Id = Guid.Parse("{A5E189C0-166A-4B37-93EE-45ECF1FF11C5}"),
                        MenuName = "系统设置",
                        MenuCode = "System",
                        Icon = "/item.ico",
                        Path = "localhost/system:8080",
                        ParentId = Guid.Parse("{EDC8F6C4-D734-49CF-9250-759D966E8641}")
                    },
                    new DevMenu
                    {
                        Id = Guid.Parse("{1CE75274-4033-4081-88D0-6BA7EF00FDDD}"),
                        MenuName = "人员管理",
                        MenuCode = "People",
                        Icon = "/item.ico",
                        Path = "localhost/people:8080",
                        ParentId = Guid.Parse("{A5E189C0-166A-4B37-93EE-45ECF1FF11C5}")
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
                    
                    },
                    new DevAction
                    {
                        Id = Guid.Parse("{255F3693-099D-432A-9A80-E377976F9C22}"),
                        ActionCode = "View",
                        ActionName = "查看"
                    }
                );

            modelBuilder.Entity<DevMenuAction>().HasData(
                new DevMenuAction{
                    Id = Guid.Parse("{BA6612D8-0F28-43C7-B4EC-5FB8E130B635}"),
                    ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                    MenuId = Guid.Parse("{1CE75274-4033-4081-88D0-6BA7EF00FDDD}")
                },
                new DevMenuAction{
                    Id = Guid.Parse("{41DBAE89-4B0C-4407-B18A-75D702639684}"),
                    ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
                    MenuId = Guid.Parse("{1CE75274-4033-4081-88D0-6BA7EF00FDDD}")
                },
                new DevMenuAction{
                    Id = Guid.Parse("{90F6E437-9FE3-4D5E-93B1-0D5E05D9D20D}"),
                    ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                    MenuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}")
                },
                new DevMenuAction{
                    Id = Guid.Parse("{235DEAE7-B378-488E-BAB9-4523A84D620B}"),
                    ActionId = Guid.Parse("{532E849C-B3D5-4D55-ABFE-6E645BA2BAE2}"),
                    MenuId = Guid.Parse("{19B93B25-5230-425B-B5C5-625B708915B5}")
                },
                new DevMenuAction{
                    Id = Guid.Parse("{8DF1D3CE-ED8A-4221-AE7D-12A886593CC5}"),
                    ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                    MenuId = Guid.Parse("{DAF50AD9-C46B-43DE-AAB2-CA4418785BA3}")
                },
                new DevMenuAction{
                    Id = Guid.Parse("{997EF473-3AFF-4DB5-AEC4-4FEEEFC3C8B6}"),
                    ActionId = Guid.Parse("{7B48A7F0-4077-4C1E-ACD5-87EF0A8ACE93}"),
                    MenuId = Guid.Parse("{A5E189C0-166A-4B37-93EE-45ECF1FF11C5}")
                }
                
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}