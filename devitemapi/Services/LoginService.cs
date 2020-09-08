/*
 * @Author: live0x 
 * @Date: 2020-09-07 17:55:57 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-07 17:55:57 
 */
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
        private static bool IsAdministrtor = true;
        private readonly DevDbContext _dbContext;

        public LoginService(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void GetMenuTreeByRole(Guid roleId)
        {
            throw new NotImplementedException();
        }

        public async Task<TreeDto> GetMenuTreeByUser(Guid userId)
        {
            var user = await _dbContext.DevUsers.FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ItemException(TipsTxt.USER_NOT_EXISTS);
            }
            List<RoleMenuDto> permissionCollection;
            if (IsAdministrtor)
            {
                permissionCollection = await (from super_menuAction in _dbContext.DevMenuActions
                                              from super_menus in _dbContext.DevMenus.Where(m => m.Id == super_menuAction.MenuId)
                                              from super_action in _dbContext.DevActions.Where(a => a.Id == super_menuAction.ActionId)
                                              select new RoleMenuDto
                                              {
                                                  RoleName = "超级管理员",
                                                  RoleCode = "SuperAdmin",
                                                  MenuName = super_menus.MenuName,
                                                  MenuCode = super_menus.MenuCode,
                                                  Path = super_menus.Url,
                                                  Icon = super_menus.Icon,
                                                  MenuParentId = super_menus.ParentId,
                                                  ActionName = super_action.ActionName,
                                                  ActionCode = super_action.ActionCode,
                                                  MenuId = super_menus.Id
                                              }
                 ).ToListAsync();
            }
            else
            {
                permissionCollection = await (from userRole in _dbContext.DevUserRoles
                                              from roles in _dbContext.DevRoles.Where(r => r.Id == userRole.RoleId).DefaultIfEmpty()
                                              from permissons in _dbContext.DevPermissions.Where(r => r.RoleId == userRole.RoleId).DefaultIfEmpty()
                                              from menus in _dbContext.DevMenus.Where(m => m.Id == permissons.MemuId).DefaultIfEmpty()
                                              from actions in _dbContext.DevActions.Where(a => a.Id == permissons.ActionId).DefaultIfEmpty()
                                              where userRole.Useid == userId
                                              select new RoleMenuDto
                                              {
                                                  RoleName = roles.RoleName,
                                                  RoleCode = roles.RoleCode,
                                                  MenuName = menus.MenuName,
                                                  MenuCode = menus.MenuCode,
                                                  Path = menus.Url,
                                                  Icon = menus.Icon,
                                                  MenuParentId = menus.ParentId,
                                                  ActionName = actions.ActionName,
                                                  ActionCode = actions.ActionCode,
                                                  MenuId = menus.Id
                                              }).ToListAsync();
            }

            TreeDto trees = new TreeDto();
            trees.Roles = await (from roles_userRole in _dbContext.DevUserRoles
                                 from roles_role in _dbContext.DevRoles.Where(r => r.Id == roles_userRole.RoleId)
                                 where roles_userRole.Useid == userId
                                 select roles_role.RoleCode).ToListAsync();
            CreateTree(permissionCollection, trees.Trees, Guid.Parse("{EDC8F6C4-D734-49CF-9250-759D966E8641}"));
            return trees;
        }

        /// <summary>
        /// 创建树形结构
        /// </summary>
        /// <param name="list"></param>
        /// <param name="treeMenus"></param>
        /// <param name="parentId"></param>
        private void CreateTree(List<RoleMenuDto> list, List<TreeMenuDto> treeMenus, Guid parentId)
        {
            if (list == null || treeMenus == null)
            {
                throw new NullReferenceException();
            }

            foreach (var item in list)
            {

                if (item.MenuParentId == parentId)
                {
                    if (treeMenus.Select(p => p.MenuCode).ToList().Contains(item.MenuCode))
                    {
                        continue;
                    }

                    var treeMenu = new TreeMenuDto()
                    {
                        MenuName = item.MenuName,
                        MenuCode = item.MenuCode,
                        Path = item.Path,
                        Icon = item.Icon
                    };
                    treeMenu.Actions = list.Where(p => p.MenuId == item.MenuId && !string.IsNullOrEmpty(p.ActionCode)).Select(p => new TreeActionDto()
                    {
                        ActionCode = p.ActionCode,
                        ActionName = p.ActionName
                    }).ToList();
                    if (!treeMenu.Actions.Select(p => p.ActionCode).ToList().Contains("View")) continue;
                    treeMenus.Add(treeMenu);
                    CreateTree(list, treeMenu.Children, item.MenuId);
                }
            }
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