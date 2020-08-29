using AutoMapper;
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
    [Route("users")]
    public class UserController : BaseController
    {
        private readonly IDevUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserService userService,IDevUserRepository repository,IMapper mapper)
        {
            this._userRepository = repository;
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// 获取指定Id的用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUser(Guid userId)
        {
            ResponseDto response = new ResponseDto();
            var user = await _userRepository.GetUserAsync(userId);
            var userDto = _mapper.Map<UserDto>(user);

            if (userDto == null)
            {
                return NotFound();
            }

            response.SetData(user);
            return Ok(response);
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        //[ProducesResponseType(,)]   //声明可能返回的类型
        public async Task<IActionResult> GetUsers(int limit = 10,int offest =0)
        {
            throw new ArgumentNullException(nameof(limit));
            ResponseDto response = new ResponseDto();
            var users = await _userRepository.GetUsersAsync();
            var userDto = _mapper.Map<IEnumerable<UserDto>>(users);
            response.SetData(userDto);
            return Ok(userDto);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ResponseDto> CreateUser(UserDto user)
        {
            ResponseDto response = new ResponseDto();
            _userRepository.AddUser(_mapper.Map<DevUser>(user));
            await _userRepository.SaveAsync();
            return response;
            
        }

        /// <summary>
        /// 删除指定用户信息
        /// </summary>
        /// <param name="userId">用户GUID</param>
        /// <returns></returns>
        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(Guid userId)
        {

            return NoContent();
            ResponseDto response = new ResponseDto();
            var user = await _userRepository.GetUserAsync(userId);
            if(user == null)
            {
               response.SetFail("用户不存在");
               return Ok(response);
            }
            _userRepository.DeleteUser(user);
            await _userRepository.SaveAsync();
            return Ok(response);
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
        [HttpPut("userId")]
        public async Task<ResponseDto> UpdateUser(Guid userId, DevUser user)
        {
            ResponseDto response = new ResponseDto();
            _userRepository.UpdateUser(user);
            await _userRepository.SaveAsync();
            return response;
        }
    }
}
