/*
 * @Author: live0x 
 * @Date: 2020-09-04 11:44:58 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 14:57:43
 */
namespace devitemapi.Infrastructure.Message
{
    public static class ErrorTxt
    {
        public const string VALIDATE_FAILED = "数据校验失败";

        #region User
        public const string USER_ILLEGAL_ACCOUNT = "用户账号非法";
        public const string USER_ALREADY_EXISTS = "用户账号已存在";
        public const string USER_ACCOUNT_EMPTY = "用户账号不能为空";
        public const string USER_PASSWORD_EMPTY = "用户密码不能为空";
        public const string USER_ACCOUNTORPASSWORD_FAIL = "用户名或密码不正确";
        #endregion
    }
}