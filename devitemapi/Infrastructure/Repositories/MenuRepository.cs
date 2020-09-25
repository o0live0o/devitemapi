using System;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<DevMenu,Guid>
    {
        public MenuRepository(DevDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}