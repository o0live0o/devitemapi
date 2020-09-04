using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class ActionService : BaseService<DevAction>,IActionService
    {
        public ActionService(IBaseRepository<DevAction> repository) : base(repository)
        {

        }

        public override void Add(DevAction devAction)
        {
            
        }

    }
}