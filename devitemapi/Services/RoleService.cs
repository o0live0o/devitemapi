/*
 * @Author: live0x
 * @Date: 2020-09-07 08:58:00
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-08 18:02:14
 */

using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;
using System.Linq;

namespace devitemapi.Services
{
    public class RoleService : BaseService<DevRole>, IRoleService
    {
        public RoleService(IBaseRepository<DevRole> repository) : base(repository)
        {
        }

        public override async void Add(DevRole role)
        {
            if (string.IsNullOrEmpty(role.RoleCode) ||
                string.IsNullOrEmpty(role.RoleName))
            {
                throw new ItemException(TipsTxt.ROLE_NAMEORCODE_EMPTY);
            }
            var roleEntity = await QueryAsync(r => r.RoleCode == role.RoleCode || r.RoleName == role.RoleName);
            if (roleEntity != null && roleEntity.Count() > 0)
            {
                throw new ItemException(TipsTxt.ROLE_ALREADY_EXISTS);
            }
            role.Id = Guid.NewGuid();
            base.Add(role);
        }

        public void func1(Guid roleId,DevMenuAction menuAction)
        {
               
        }
    }
}