using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    public interface IPermissionService:IBaseService<DevPermission>
    {
        Task<IEnumerable<DevPermission>> GetPermissionByRoleId(Guid roleId);
    }
}