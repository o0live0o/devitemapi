/*
 * @Author: live0x
 * @Date: 2020-09-04 11:44:58
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-07 08:58:26
 */

namespace devitemapi.Infrastructure.Message
{
    public static class TipsTxt
    {
        public const string VALIDATE_FAILED = "数据校验失败";

        #region User

        public const string USER_ILLEGAL_ACCOUNT = "用户账号非法";
        public const string USER_ALREADY_EXISTS = "用户账号已存在";
        public const string USER_ACCOUNT_EMPTY = "用户账号不能为空";
        public const string USER_PASSWORD_EMPTY = "用户密码不能为空";
        public const string USER_ACCOUNTORPASSWORD_FAIL = "用户名或密码不正确";

        #endregion User

        #region Action

        public const string ACTION_EMPTY_ID = "操作ID不能为空";

        #endregion Action

        #region ROLE

        public const string ROLE_NAMEORCODE_EMPTY = "角色名称不能为空";
        public const string ROLE_ALREADY_EXISTS = "角色已存在";
        public const string ROLE_ID_EMPTY = "角色ID不能为空";

        public static string MENU_MENUNAME_EMPTY { get; internal set; }
        public static string MENU_ALREADY_EXISTS { get; internal set; }
        public static string MENU_ID_EMPTY { get; internal set; }
        public static string USER_NOT_EXISTS { get; internal set; }
        public static string USER_EXCEPTIONS { get; internal set; }

        #endregion ROLE
    }
}