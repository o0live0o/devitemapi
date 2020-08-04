using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Controllers.Rbac
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService m_userService;

        public UserController(IUserService userService)
        {
            this.m_userService = userService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await m_userService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await m_userService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevUser user)
        {
            return await m_userService.Add(user);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await m_userService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> Delete(string ids)
        {
            return await m_userService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevUser user)
        {
            return await m_userService.Modify(user);
        }
    }
}
