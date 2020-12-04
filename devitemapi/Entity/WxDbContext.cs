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
            modelBuilder.Entity<WxUser>().HasIndex( p => p.UserCode).IsUnique();
            modelBuilder.Entity<WxUser>().HasData(
                new WxUser{
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
            base.OnModelCreating(modelBuilder);
        }
    }
}