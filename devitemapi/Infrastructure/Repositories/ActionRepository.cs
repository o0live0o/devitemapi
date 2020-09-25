using System;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class ActionRepository : BaseRepository<DevAction,Guid>
    {
        public ActionRepository(DevDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}