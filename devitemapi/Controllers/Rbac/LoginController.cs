/*
 * @Author: live0x
 * @Date: 2020-09-07 11:11:42
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-07 18:00:08
 */

using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 登录授权
    /// </summary>
    // [Route("login")]
    public class LoginController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IRbacService _rbacService;

        public LoginController(IUserService userService, IRbacService rbacService)
        {
            this._rbacService = rbacService ?? throw new ArgumentNullException(nameof(rbacService));
            this._userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userAccount">用户账号</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("login")]
        [ProducesResponseType(typeof(LoginDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<LoginDto>> SignIn(string userAccount, string pwd)
        {
            if (string.IsNullOrEmpty(userAccount))
            {
                throw new ItemException(TipsTxt.USER_ACCOUNT_EMPTY);
            }
            else if (string.IsNullOrEmpty(pwd))
            {
                throw new ItemException(TipsTxt.USER_PASSWORD_EMPTY);
            }

            var user = await _userService.QueryUserByAccount(userAccount, pwd);
            if (user == null)
            {
                throw new ItemException(TipsTxt.USER_ACCOUNTORPASSWORD_FAIL);
            }

            var token = JWTService.GetJWTToken(userAccount, AppConfig.Config.JwtSecurityKey);
            var loginDto = new LoginDto()
            {
                Token = token
            };
            return Ok(loginDto);
        }

        [HttpGet("permission/menus/{userId}")]
        public async Task<ActionResult> GetMenusByUserId(Guid userId)
        {
            var menus = await _rbacService.GetMenuTreeByUser(userId);
            return Ok(menus);
        }
    }
}