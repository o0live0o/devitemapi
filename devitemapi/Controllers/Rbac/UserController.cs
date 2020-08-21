using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
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
        private readonly IDevUserRepository _userRepository;

        public UserController(IUserService userService,IDevUserRepository repository)
        {
            this._userRepository = repository;
        }

        /// <summary>
        /// 获取指定Id的用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<ResponseDto> GetUser(Guid userId)
        {
            ResponseDto response = new ResponseDto();
            var user = await _userRepository.GetUserAsync(userId);
            response.SetData(user);
            return response;
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDto> GetUsers()
        {
            ResponseDto response = new ResponseDto();
            var users = await _userRepository.GetUsersAsync();
            response.SetData(users);
            return response;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDto> CreateUser(DevUser user)
        {
            ResponseDto response = new ResponseDto();
            _userRepository.AddUser(user);
            await _userRepository.SaveAsync();
            return response;
        }

        /// <summary>
        /// 删除指定用户信息
        /// </summary>
        /// <param name="userId">用户GUID</param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<ResponseDto> DeleteUser(Guid userId)
        {
           
            ResponseDto response = new ResponseDto();
            var user = await _userRepository.GetUserAsync(userId);
            if(user == null)
            {
               response.SetFail("用户不存在");
               return response;
            }
            _userRepository.DeleteUser(user);
            await _userRepository.SaveAsync();
            return response;
        }

        // /// <summary>
        // /// 批量删除用户
        // /// </summary>
        // /// <param name="ids">用户Id,多个用英文 , 分隔</param>
        // /// <returns></returns>
        // [HttpGet("{ids}")]
        // public async Task<ResponseDto> DeleteBatch(string ids)
        // {
        //     return await _userService.Delete(ids);
        // }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDto> UpdateUser(DevUser user)
        {
            ResponseDto response = new ResponseDto();
            _userRepository.UpdateUser(user);
            await _userRepository.SaveAsync();
            return response;
        }
    }
}
