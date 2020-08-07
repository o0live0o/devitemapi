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
    /// <summary>
    /// 用户管理
    /// </summary>
    //[Route("[controller]/[action]")]
    //[ApiController]
    public class UserController : BaseController
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        /// <summary>
        /// 获取指定Id的用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await _userService.Get(id);
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await _userService.Get();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDto> Add(DevUser user)
        {
            return await _userService.Add(user);
        }

        /// <summary>
        /// 删除指定用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await _userService.Delete(id);
        }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        /// <param name="ids">用户Id,多个用英文 , 分隔</param>
        /// <returns></returns>
        [HttpGet("{ids}")]
        public async Task<ResponseDto> DeleteBatch(string ids)
        {
            return await _userService.Delete(ids);
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDto> Modify(DevUser user)
        {
            return await _userService.Modify(user);
        }
    }
}
