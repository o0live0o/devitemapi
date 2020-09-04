using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Log;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 登录授权
    /// </summary>
    [Route("login")]
    public class LoginController : BaseController
    {
        private readonly IUserService _userService;

        public LoginController(IUserService userService)
        {
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
        [ProducesResponseType(typeof(string),(int)HttpStatusCode.OK)]
        public async Task<ActionResult> SignIn(string userAccount, string pwd)
        {

            if (string.IsNullOrEmpty(userAccount))
            {
                throw new ItemException(ErrorTxt.USER_ACCOUNT_EMPTY);
            }
            else if (string.IsNullOrEmpty(pwd))
            {
                throw new ItemException(ErrorTxt.USER_PASSWORD_EMPTY);
            }

            var user = await _userService.QueryUserByAccount(userAccount, pwd);
            if (user == null)
            {
                throw new ItemException(ErrorTxt.USER_ACCOUNTORPASSWORD_FAIL);
            }

            var token = JWTService.GetJWTToken(userAccount, AppConfig.Config.JwtSecurityKey);
            return Ok(token);
        }

    }
}
