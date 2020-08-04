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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class    RoleController : ControllerBase
    {
        private readonly IRoleService m_roleService;

        public RoleController(IRoleService roleService)
        {
            this.m_roleService = roleService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await m_roleService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await m_roleService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevRole role)
        {
            return await m_roleService.Add(role);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await m_roleService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> Delete(string ids)
        {
            return await m_roleService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevRole role)
        {
            return await m_roleService.Modify(role);
        }
    }
}
