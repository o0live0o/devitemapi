using System;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repositories
{
    public class ActionRepository : BaseRepository<WxAction,int>
    {
        public ActionRepository(WxDbContext devDbContext) : base(devDbContext)
        {
        }
    }
}