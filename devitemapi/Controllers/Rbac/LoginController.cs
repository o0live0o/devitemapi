using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Dtos;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 登录授权
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    public class LoginController : BaseController
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            this._loginService = loginService;
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="user">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        public ResponseDto Login(string user,string pwd)
        {
            return _loginService.Login(user,pwd);
        }
    }
}
