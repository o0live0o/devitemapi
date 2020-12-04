/*
 * @Author: live0x
 * @Date: 2020-09-07 08:58:00
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 08:52:28
 */

using AutoMapper;
using devitemapi.Dto.Role;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services      
{
    public class RoleService : BaseService<WxRole,int>, IRoleService
    {
        public RoleService(IBaseRepository<WxRole,int> repository) : base(repository)
        {
        }

        public override async void Add(WxRole role)
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
            base.Add(role);
        }

    }
}