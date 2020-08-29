using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 角色管理
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("roles")]
    public class RoleController : BaseController
    {
        private readonly IDevRoleRepository _roleRepository;

        public RoleController(IDevRoleRepository roleRepository)
        {
            this._roleRepository = roleRepository;
        }

        [HttpGet("{roleId}")]
        public async Task<ResponseDto> GetRole(Guid roleId)
        {
            if (roleId == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(roleId));
            }
            ResponseDto response = new ResponseDto();
            var role = await _roleRepository.GetRoleAsync(roleId);
            return response.SetData(role);
        }

        [HttpGet]
        public async Task<ResponseDto> GetRoles()
        {
            ResponseDto response = new ResponseDto();
            var roles = await _roleRepository.GetRolesAsync();
            return response.SetData(roles);
        }

        [HttpPost]
        public async Task<ResponseDto> CreateRole(DevRole role)
        {
            ResponseDto response = new ResponseDto();
            _roleRepository.AddRole(role);
            await _roleRepository.SaveAsync();
            return response;
        }

        [HttpDelete("{roleId}")]
        public async Task<ResponseDto> DeleteRole(Guid roleId)
        {
            ResponseDto response = new ResponseDto();
            var role = await _roleRepository.GetRoleAsync(roleId);
            if (role != null)
            {
                _roleRepository.DeleteRole(role);
                await _roleRepository.SaveAsync();
            }
            return response;
        }

        [HttpPut("roleId")]
        public async Task<ResponseDto> UpdateRole(Guid roleId, DevRole role)
        {
            ResponseDto response = new ResponseDto();
            if (role == null || role.Id == Guid.Empty)
            {
                return response.SetFail("Role Invalid");
            }
            _roleRepository.UpdateRole(role);
            await _roleRepository.SaveAsync();
            return response;
        }
    }
}
