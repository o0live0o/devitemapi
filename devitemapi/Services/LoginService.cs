using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
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

        public void GetMenuTreeByRole(Guid roleId)
        {
            throw new NotImplementedException();
        }

        // public ResponseDto GetMenuTreeByUser(int userId)
        // {
        //     ResponseDto response = new ResponseDto();
        //     var roleIdArr = GetRoleIdsByUserId(userId);
        //     var menus = (from rolePermission in _dbContext.DevPermissions
        //                   from action in _dbContext.DevActions.Where(a => a.Id.Equals(rolePermission.ActionId)).DefaultIfEmpty()
        //                   from menu in _dbContext.DevMenus.Where(m => m.Id.Equals(rolePermission.MemuId)).DefaultIfEmpty()
        //                   where roleIdArr.Contains(rolePermission.RoleId)
        //                   select menu).ToList();
        //     response.SetData(menus);
        //     return response;
        // }

        public async Task<object> GetMenuTreeByUser(Guid userId)
        {
            var user = await _dbContext.DevUsers.FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ItemException(TipsTxt.USER_NOT_EXISTS);
            }

            var permissionCollection = await (from userRole in _dbContext.DevUserRoles
                                              from roles in _dbContext.DevRoles.Where(r => r.Id == userRole.RoleId).DefaultIfEmpty()
                                              from permissons in _dbContext.DevPermissions.Where(r => r.RoleId == userRole.RoleId).DefaultIfEmpty()
                                              from menus in _dbContext.DevMenus.Where(m => m.Id == permissons.MemuId).DefaultIfEmpty()
                                              from actions in _dbContext.DevActions.Where(a => a.Id == permissons.ActionId).DefaultIfEmpty()
                                              where userRole.Useid == userId
                                              select new
                                              {
                                                  RoleName = roles.RoleName,
                                                  RoleCode = roles.RoleCode,
                                                  MenuName = menus.MenuName,
                                                  MenuCode = menus.MenuCode,
                                                  Path = menus.Url,
                                                  Icon = menus.Icon,
                                                  ActionName = actions.ActionName,
                                                  ActionCode = actions.ActionCode
                                              }).ToListAsync();

            var roleList = new List<string>();

            Dictionary<string, List<string>> urlDic = new Dictionary<string, List<string>>();
            foreach (var item in permissionCollection)
            {
                if (!roleList.Contains(item.RoleCode))
                {
                    roleList.Add(item.RoleCode);
                }
                string menuCode = item.MenuCode.Trim();
                if (!urlDic.ContainsKey(menuCode))
                {
                    urlDic[menuCode] = new List<string>();
                }
                if (!urlDic[menuCode].Contains(item.ActionCode))
                {
                    urlDic[menuCode].Add(item.ActionCode);
                }
            }
            return new
            {
                Roles = roleList,
                Menus = urlDic
            };
            /*
                [
                    {
                        roles:[],
                        menus:[
                            {
                                path : "",
                                action:[

                                ]
                            }
                        ],
                    }
                ]
            */
        }

        public void GetPermissionByRole(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public void GetPermissionByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public ResponseDto GetPowerByUser(int userId)
        {
            ResponseDto response = new ResponseDto();
            var roleIdArr = GetRoleIdsByUserId(userId);

            return response;
        }

        public void UpdatePermission(Guid roleId, DevPermission permission)
        {
            throw new NotImplementedException();
        }

        private List<int> GetRoleIdsByUserId(int userId)
        {
            throw new NotImplementedException();
            //var userRoles = _dbContext.DevUserRoles.Where(ur => userId.Equals(ur.Useid));
            //return userRoles.Select(r => r.RoleId).ToList();
        }
    }
}