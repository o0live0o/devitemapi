using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Message
{
    public abstract  class MessageTxt
    {
        public static string EMPTY_SEARCH = "没有查询到对应的数据";

        public static string ERROR_SEARCH = "查询异常";

        public static string ERROR_MODIFY = "修改数据失败";

        public static string ERROR_ADD = "插入数据失败";

        #region User
        public static string PASS_MODIFY_USER = "用户信息修改成功";

        public static string ERROR_NOT_EXISTS_USER = "用户不存在";
        #endregion

        #region Role
        public static string PASS_MODIFY_ROLE = "角色信息修改成功";

        public static string ERROR_NOT_EXISTS_ROLE = "角色不存在";
        #endregion

        #region Login
        public static string EMPTY_LOGIN_ACCOUNT = "用户账号不能为空！";

        public static string EMPTY_LOGIN_PASSWORD = "用户密码不能为空！";


        public static string ERROR_LOGIN_MISS_USERORPWD = "用户名或密码错误!";

        public static string ERROR_LOGIN_NO_POWER = "用户被锁定，请联系管理员!";

        public static string PASS_LOGIN = "用户登录成功";
        #endregion

    }
}
