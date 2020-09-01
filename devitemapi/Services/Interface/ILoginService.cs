using devitemapi.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface ILoginService
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>JWT Token</returns>
        ResponseDto Login(string userName,string pwd);

        ResponseDto GetMenuTreeByUser(int userId);

        ResponseDto GetPowerByUser(int userId);

    }
}
