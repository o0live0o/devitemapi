using System;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<WxMenu,int>
    {
        public MenuRepository(WxDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}