using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<DevMenu>
    {
        public MenuRepository(DevDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}