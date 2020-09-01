using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Infrastructure.Log;
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
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("login")]
    public class LoginController : BaseController
    {
        private readonly IDevUserRepository _userRepository;
        private readonly ILogger _logger;

        public LoginController(IDevUserRepository userRepository)
        {
            this._userRepository = userRepository;;
   
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
        public async Task<ResponseDto> Login(string userAccount,string pwd)
        {

            //_logger.Trace("iiiiii");
            ResponseDto response = new ResponseDto();
            if(string.IsNullOrEmpty(userAccount))
            {
                response.SetFail(MessageTxt.EMPTY_LOGIN_ACCOUNT);
            }
            else if(string.IsNullOrEmpty(pwd))
            {
                response.SetFail(MessageTxt.EMPTY_LOGIN_PASSWORD);
            }
            else
            {
                 var user = await _userRepository.GetUserAsync(userAccount,pwd);
                 if(user == null)
                 {
                     response.SetFail(MessageTxt.ERROR_LOGIN_MISS_USERORPWD);
                 }
                 else
                 {
                    var token = JWTService.GetJWTToken(userAccount, AppConfig.Config.JwtSecurityKey);
                    response.SetData(token);
                 }
            }
            return response;
        }

    }
}
