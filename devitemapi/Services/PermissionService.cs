using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Entity;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;

namespace devitemapi.Services
{
    public class PermissionService : BaseService<WxPermission,int>, IPermissionService
    {

        public PermissionService(IBaseRepository<WxPermission,int> repository) : base(repository)
        {
        }

        public async Task<IEnumerable<WxPermission>> GetPermissionByRoleId(int roleId)
        {
             return await QueryAsync(p => p.RoleId == roleId);
        }
    }
}