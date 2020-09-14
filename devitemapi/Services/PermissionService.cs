using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Entity;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;

namespace devitemapi.Services
{
    public class PermissionService : BaseService<DevPermission>, IPermissionService
    {

        public PermissionService(IBaseRepository<DevPermission> repository) : base(repository)
        {
        }

        public async Task<IEnumerable<DevPermission>> GetPermissionByRoleId(Guid roleId)
        {
             return await QueryAsync(p => p.RoleId == roleId);
        }
    }
}