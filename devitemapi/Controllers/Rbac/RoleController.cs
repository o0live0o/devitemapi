/*
 * @Author: live0x 
 * @Date: 2020-09-05 11:55:09 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-05 12:05:37
 */
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Dto.Role;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Services.Interface;
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
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            this._roleService = roleService;
            this._mapper = mapper;
        }

        [HttpGet("{roleId}",Name = nameof(GetRoleById))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(RoleDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<RoleDto>> GetRoleById(Guid roleId)
        {
            if (roleId == Guid.Empty)
            {
                throw new ItemException(ErrorTxt.ROLE_ID_EMPTY);
            }
            var role =await _roleService.QueryByIdAsync(roleId);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RoleDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetRoles(int pageSize = 20, int pageIndex = 1)
        {
            var roles = await _roleService.QueryAsync(pageSize, pageIndex);
            return Ok(roles);
        }

        [HttpPost]
        public async Task<ActionResult<RoleDto>> CreateRole(RoleAddDto role)
        {
            var roleEntity = _mapper.Map<DevRole>(role);
            _roleService.Add(roleEntity);
            await _roleService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetRoleById), new { roleId = roleEntity.Id }, null);
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
