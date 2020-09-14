/*
 * @Author: live0x 
 * @Date: 2020-09-08 15:57:15 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-14 11:31:21
 */
using AutoMapper;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;

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
                throw new ItemException(TipsTxt.ACTION_CODE_EMPTY);
            }

            devAction.Id = Guid.NewGuid();
            base.Add(devAction);
        }
    }
}