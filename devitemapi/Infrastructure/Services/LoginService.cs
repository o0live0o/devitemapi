using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services
{
    /*
     * 1.登录返回Token
     * 2.根据用户Id返回左侧菜单和每个菜单的操作权限
     * 3.根据用户Id返回左侧菜单
     * 4.根据用户Id返回菜单操作权限
     */
    public class LoginService : ILoginService
    {
        private readonly DevDbContext _dbContext;

        public LoginService(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public ResponseDto GetMenuTreeByUser(int userId)
        {
            ResponseDto response = new ResponseDto();
            var roleIdArr = GetRoleIdsByUserId(userId);
            var menus = (from rolePermission in _dbContext.DevRolePermissions
                          from action in _dbContext.DevActions.Where(a => a.Id.Equals(rolePermission.ActionId)).DefaultIfEmpty()
                          from menu in _dbContext.DevMenus.Where(m => m.Id.Equals(rolePermission.MemuId)).DefaultIfEmpty()
                          where roleIdArr.Contains(rolePermission.RoleId)
                          select menu).ToList();
            response.SetData(menus);
            return response;
        }

        public ResponseDto GetPowerByUser(int userId)
        {
            ResponseDto response = new ResponseDto();
            var roleIdArr = GetRoleIdsByUserId(userId);

            return response;
        }

        public ResponseDto Login(string account, string pwd)
        {
            ResponseDto response = new ResponseDto();
            var user = _dbContext.DevUsers.Where(u=>account.Equals(u.Account) && pwd.Equals(u.Pwd)).FirstOrDefault();
            if (user == null)
                response.SetFail(MessageTxt.ERROR_LOGIN_MISS_USERORPWD);
            else if (!1.Equals(user.Status))
                response.SetFail(MessageTxt.ERROR_LOGIN_NO_POWER);
            else
            {
                response.SetSuccess(MessageTxt.PASS_LOGIN);
                //TODO JWT
                var token = JWTService.GetJWTToken(account, AppConfig.Config.JwtSecurityKey);
                response.SetData(token);
            }
            return response;
        }

        private List<int> GetRoleIdsByUserId(int userId)
        {
            var userRoles = _dbContext.DevUserRoles.Where(ur => userId.Equals(ur.Useid));
            return userRoles.Select(r => r.RoleId).ToList();
        }
    }
}
