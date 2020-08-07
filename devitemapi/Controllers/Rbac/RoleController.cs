using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
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
    public class    RoleController : BaseController
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            this._roleService = roleService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await _roleService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await _roleService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevRole role)
        {
            return await _roleService.Add(role);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await _roleService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> DeleteBatch(string ids)
        {
            return await _roleService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevRole role)
        {
            return await _roleService.Modify(role);
        }
    }
}
