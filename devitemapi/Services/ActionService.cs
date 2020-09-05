using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class ActionService : BaseService<DevAction>, IActionService
    {
        public ActionService(IBaseRepository<DevAction> repository) : base(repository)
        {

        }

        public override void Add(DevAction devAction)
        {
            if (string.IsNullOrEmpty(devAction.ActionName) ||
                    string.IsNullOrEmpty(devAction.ActionCode))
            {
                throw new ItemException("操作名称或代码不能为空");
            }

            devAction.Id = Guid.NewGuid();
            base.Add(devAction);
        }

    }
}