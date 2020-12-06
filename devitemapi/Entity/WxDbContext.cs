using Microsoft.EntityFrameworkCore;
using System;

namespace devitemapi.Entity
{
    public class WxDbContext : DbContext
    {
        public WxDbContext(DbContextOptions<WxDbContext> options) : base(options)
        {
        }

        public virtual DbSet<WxNlogRec> WxNlogrecs { get; set; }
        public virtual DbSet<WxMenu> WxMenus { get; set; }
        public virtual DbSet<WxUser> WxUsers { get; set; }
        public virtual DbSet<WxRole> WxRoles { get; set; }
        public virtual DbSet<WxAction> WxActions { get; set; }
        public virtual DbSet<WxMenuAction> WxMenuActions { get; set; }
        public virtual DbSet<WxPermission> WxPermissions { get; set; }
        public virtual DbSet<WxUserRole> WxUserRoles { get; set; }
        public virtual DbSet<WxGoldDailyPrice> WxGoldDailyPrice { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<DevRole>().OwnsOne(p=>p.DevPermissions,pe => {
            //     pe.WithOwner().HasForeignKey("RoleId");
            // });
            // modelBuilder.Entity<DevRole>(m=>{
            //     m.HasMany(u => u.DevPermissions).WithOne().HasForeignKey(u => u.RoleId);
            // });
            // modelBuilder.Entity<WxUser>().HasIndex( p => p.UserCode).IsUnique();
            modelBuilder.Entity<WxUser>().HasData(
                new WxUser
                {
                    Id = 1,
                    Account = "Administrator",
                    CreateDate = DateTime.Now,
                    CreateUserId = 0,
                    UserCode = "100001",
                    UserName = "超级管理员",
                    Pwd = "123456",
                    Sex = 1,
                    Age = 1
                }
            );

            modelBuilder.Entity<WxRole>().HasData(
                new WxRole
                {
                    Id = 1,
                    RoleCode = "SuperAdmin",
                    RoleName = "超级管理员",
                    Status = 1
                }
            );

            modelBuilder.Entity<WxUserRole>().HasData(
                new WxUserRole
                {
                    Id = 1,
                    UserId = 1,
                    RoleId = 1
                }
            );

            modelBuilder.Entity<WxMenu>().HasData(
                new WxMenu
                {
                    Id = 1,
                    MenuName = "首页",
                    MenuCode = "home",
                    Path = "/home",
                    Icon = "el-icon-s-home",
                    ParentId = 0,
                    OrderNo = "000000"
                },
                new WxMenu
                {
                    Id = 2,
                    MenuName = "系统管理",
                    MenuCode = "system",
                    Path = "/system",
                    Icon = "el-icon-s-tools",
                    ParentId = 0,
                    OrderNo = "000200"
                },
                new WxMenu
                {
                    Id = 3,
                    MenuName = "人员管理",
                    MenuCode = "user",
                    Path = "/user",
                    Icon = "el-icon-user-solid",
                    ParentId = 2,
                    OrderNo = "000201"
                },
                 new WxMenu
                 {
                     Id = 4,
                     MenuName = "角色管理",
                     MenuCode = "role",
                     Path = "/role",
                     Icon = "el-icon-s-management",
                     ParentId = 2,
                     OrderNo = "000202"
                 },
                 new WxMenu
                 {
                     Id = 5,
                     MenuName = "菜单管理",
                     MenuCode = "menu",
                     Path = "/menu",
                     Icon = "el-icon-menu",
                     ParentId = 2,
                     OrderNo = "000203"
                 },
                 new WxMenu
                 {
                     Id = 6,
                     MenuName = "关于",
                     MenuCode = "about",
                     Path = "/about",
                     Icon = "el-icon-info",
                     ParentId = 0,
                     OrderNo = "000300"
                 }
            );
            modelBuilder.Entity<WxAction>().HasData(
                new WxAction
                {
                    Id = 1,
                    ActionCode = "view",
                    ActionName = "查看"
                },
                new WxAction
                {
                    Id = 2,
                    ActionCode = "add",
                    ActionName = "增加"
                },
                new WxAction
                {
                    Id = 3,
                    ActionCode = "delete",
                    ActionName = "删除"
                },
                new WxAction
                {
                    Id = 4,
                    ActionCode = "deit",
                    ActionName = "编辑"
                }
            );

            modelBuilder.Entity<WxPermission>().HasData(
                new WxPermission {Id = 1,  RoleId = 1, MenuId = 1, ActionId = 1 },
                new WxPermission {Id = 2, RoleId = 1, MenuId = 1, ActionId = 2 },
                new WxPermission {Id = 3, RoleId = 1, MenuId = 1, ActionId = 3 },
                new WxPermission {Id = 4, RoleId = 1, MenuId = 1, ActionId = 4 },

                new WxPermission {Id = 5, RoleId = 1, MenuId = 2, ActionId = 1 },
                new WxPermission {Id = 6, RoleId = 1, MenuId = 2, ActionId = 2 },
                new WxPermission {Id = 7, RoleId = 1, MenuId = 2, ActionId = 3 },
                new WxPermission {Id = 8, RoleId = 1, MenuId = 2, ActionId = 4 },

                new WxPermission {Id = 9, RoleId = 1, MenuId = 3, ActionId = 1 },
                new WxPermission {Id = 10, RoleId = 1, MenuId = 3, ActionId = 2 },
                new WxPermission {Id = 11, RoleId = 1, MenuId = 3, ActionId = 3 },
                new WxPermission {Id = 12, RoleId = 1, MenuId = 3, ActionId = 4 },

                new WxPermission {Id = 13, RoleId = 1, MenuId = 4, ActionId = 1 },
                new WxPermission {Id = 14, RoleId = 1, MenuId = 4, ActionId = 2 },
                new WxPermission { Id = 15, RoleId = 1, MenuId = 4, ActionId = 3 },
                new WxPermission {Id = 16, RoleId = 1, MenuId = 4, ActionId = 4 },

                new WxPermission {Id = 17, RoleId = 1, MenuId = 5, ActionId = 1 },
                new WxPermission {Id = 18, RoleId = 1, MenuId = 5, ActionId = 2 },
                new WxPermission {Id = 19, RoleId = 1, MenuId = 5, ActionId = 3 },
                new WxPermission {Id = 20, RoleId = 1, MenuId = 5, ActionId = 4 },

                new WxPermission {Id = 21, RoleId = 1, MenuId = 6, ActionId = 1 },
                new WxPermission {Id = 22, RoleId = 1, MenuId = 6, ActionId = 2 },
                new WxPermission {Id = 23, RoleId = 1, MenuId = 6, ActionId = 3 },
                new WxPermission {Id = 24, RoleId = 1, MenuId = 6, ActionId = 4 }

            );

            

            base.OnModelCreating(modelBuilder);
        }
    }
}