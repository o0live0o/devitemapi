/*
 * @Author: live0x
 * @Date: 2020-09-04 11:44:58
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 15:14:08
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
        public const string USER_NOT_EXISTS = "用户ID不能为空";
        public const string USER_EXCEPTIONS = "用户信息异常";

        #endregion User

        #region Action
        public const string ACTION_EMPTY_ID = "操作ID不能为空";
        #endregion Action

        #region ROLE
        public const string ROLE_NAMEORCODE_EMPTY = "角色名称不能为空";
        public const string ROLE_ALREADY_EXISTS = "角色已存在";
        public const string ROLE_ID_EMPTY = "角色ID不能为空";
        public const string ROLE_NOT_EXISTS = "角色不存在";
        #endregion ROLE

        #region Menu
        public const string MENU_MENUNAME_EMPTY = "菜单名字不能为空";
        public const string MENU_ALREADY_EXISTS = "菜单已存在";
        public const string MENU_ID_EMPTY = "菜单ID不能为空";
        public const string MENU_NOT_EXISTS = "菜单不存在";
        #endregion

        #region Action
        public const string ACTION_CODE_EMPTY = "操作代码不能为空";

        #endregion
        #region StorageIn
        public const string StorageIn_Order_NOT_EXISTS = "入库单不存在";

        public const string StorageOut_Order_NOT_EXISTS = "出库单不存在";

        public const string NO_POWER = "无权限操作此项!";
        #endregion
    }
}