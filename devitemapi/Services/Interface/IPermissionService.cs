using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    public interface IPermissionService:IBaseService<WxPermission,int>
    {
        Task<IEnumerable<WxPermission>> GetPermissionByRoleId(int roleId);
    }
}