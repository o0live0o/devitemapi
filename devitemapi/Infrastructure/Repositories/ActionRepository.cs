using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class ActionRepository : BaseRepository<DevAction>
    {
        public ActionRepository(DevDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}