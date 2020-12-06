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
    public class ActionService : BaseService<WxAction,int>, IActionService
    {
        public ActionService(IBaseRepository<WxAction,int> repository) : base(repository)
        {
        }

        public override void Add(WxAction wxAction)
        {
            if (string.IsNullOrEmpty(wxAction.ActionName) ||
                    string.IsNullOrEmpty(wxAction.ActionCode))
            {
                throw new WxException(TipsTxt.ACTION_CODE_EMPTY);
            }

            base.Add(wxAction);
        }
    }
}