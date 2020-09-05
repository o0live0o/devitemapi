using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class RoleService : BaseService<DevRole>, IRoleService
    {
        public RoleService(IBaseRepository<DevRole> repository) : base(repository)
        {
        }

        public override void Add(DevRole role)
        {
            if (string.IsNullOrEmpty(role.RoleCode) ||
                string.IsNullOrEmpty(role.RoleName))
            {
                throw new ItemException(ErrorTxt.ROLE_NAMEORCODE_EMPTY);
            }
            var roleEntity = QueryAsync(r => r.RoleCode == role.RoleCode || r.RoleName == role.RoleName);
            if (roleEntity != null)
            {
                throw new ItemException(ErrorTxt.ROLE_ALREADY_EXISTS);
            }
            role.Id = Guid.NewGuid();
            base.Add(role);
        }

    }
}
