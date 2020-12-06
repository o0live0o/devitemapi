/*
 * @Author: live0x 
 * @Date: 2020-09-21 16:05:09 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-21 16:05:09 
 */
using AutoMapper;
using devitemapi.Common;
using devitemapi.Dto.Rbac;
using devitemapi.Dto.User;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 用户管理
    /// </summary>
    //[Route("[controller]/[action]")]
    //[ApiController]
    [Route("user")]
    public class UserController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService userService,
                              IMapper mapper)
        {
            this._userService = userService ?? throw new ArgumentNullException(nameof(userService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// 获取指定Id的用户信息
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet("{userId}", Name = nameof(GetUserAsync))]
        [ProducesResponseType(typeof(UserDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<UserDto>> GetUserAsync(int userId)
        {
            var user = await _userService.QueryByIdAsync(userId);
            if (user == null)
            {
                return NotFound();
            }
            var userDto = _mapper.Map<UserDto>(user);
            return Ok(userDto);
        }

        /// <summary>
        /// 获取所有用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<UserDto>), (int)HttpStatusCode.OK)]   //声明可能返回的类型
        public async Task<ActionResult<IEnumerable<UserDto>>> GetUsersAsync(int pageSize = 20, int pageIndex = 1)
        {
            var users = await _userService.QueryAsync(null, pageSize, pageIndex);
            var userDtos = _mapper.Map<IEnumerable<UserDto>>(users);
            return Ok(users);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> CreateUser([FromBody] UserAddOrUpdateDto user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            var userDto = await _userService.CreateUser(user);

            return CreatedAtRoute(nameof(GetUserAsync), new { userId = userDto.UserId }, null);
        }

        /// <summary>
        /// 删除指定用户信息
        /// </summary>
        /// <param name="userId">用户GUID</param>
        /// <returns></returns>
        [HttpDelete("{userId}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult> DeleteUser(int userId)
        {
            if (userId < 1)
            {
                return BadRequest();
            }

            var user = await _userService.QueryByIdAsync(userId);

            if (user == null)
            {
                return NotFound();
            }
            CheckOperator(user.Id);
            _userService.Remove(user);
            await _userService.SaveChangeAsync();
            return NoContent();
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
        /// <param name="userId"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> UpdateUserAsync([FromRoute] int userId, [FromBody] UserAddOrUpdateDto user)
        {

            if (userId < 1 || user is null)
            {
                return BadRequest();
            }
            var userEntity = await _userService.QueryByIdAsync(userId);

            if (userEntity == null)
            {
                return NotFound();
            }
            CheckOperator(userEntity.Id);
            _mapper.Map(user, userEntity);

            await _userService.SaveChangeAsync();

            return CreatedAtRoute(nameof(GetUserAsync), new { userId }, null);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userAccount">用户账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("~/login")]
        [ProducesResponseType(typeof(LoginDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<LoginDto>> SignInAsync(string userAccount, string pwd)
        {
            if (string.IsNullOrEmpty(userAccount))
            {
                throw new WxException(TipsTxt.USER_ACCOUNT_EMPTY);
            }
            else if (string.IsNullOrEmpty(pwd))
            {
                throw new WxException(TipsTxt.USER_PASSWORD_EMPTY);
            }

            var user = await _userService.QueryUserByAccount(userAccount, pwd);
            if (user == null)
            {
                throw new WxException(TipsTxt.USER_ACCOUNTORPASSWORD_FAIL);
            }

            var token = JWTService.GetJWTToken(userAccount, AppConfig.Config.JwtSecurityKey);
            var loginDto = new LoginDto()
            {
                Token = token
            };
            return Ok(loginDto);
        }

        private void CheckOperator(int userId)
        {
            if (userId == 1)
                throw new WxException(TipsTxt.NO_POWER);
        }
    }
}