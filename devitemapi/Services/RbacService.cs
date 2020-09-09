/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:42 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 17:57:34
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Dto;
using devitemapi.Dto.Action;
using devitemapi.Dto.Rbac;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Services
{
    public class RbacService : IRbacService
    {
        private readonly DevDbContext _dbContext;

        public RbacService(DevDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new System.ArgumentNullException(nameof(dbContext));
        }
        public bool IsAdministrtor = true;

        #region 树型菜单
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
                                                  Path = super_menus.Path,
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
                                                  Path = menus.Path,
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

        #endregion

        #region 权限管理

        public async Task<IEnumerable<DevPermission>> GetPermissionByRoleId(Guid roleId)
        {
            return await _dbContext.Set<DevPermission>().Where(p => p.RoleId == roleId).ToListAsync();
        }

        public async Task<MenuActionDto> GetMenuActionsByMenuId(Guid menuId)
        {
            var menuActions =await (from menuAtion in _dbContext.DevMenuActions
            from menus in _dbContext.DevMenus.Where(m => m.Id == menuAtion.MenuId)
            from actions in _dbContext.DevActions.Where(a => a.Id == menuAtion.ActionId)
            where menuAtion.MenuId == menuId
            select new {
                MenuId = menus.Id,
                MenuName = menus.MenuName,
                ParentId = menus.ParentId,
                Path = menus.Path,
                Icon = menus.Icon,
                ActionId = actions.Id,
                ActionName = actions.ActionName,
                ActionCode = actions.ActionCode
            }).ToListAsync();
            
            MenuActionDto menuActionDto = new MenuActionDto();
            
            if(menuActions.Count() > 0)
            {
                menuActionDto.MenuId =  menuActions[0].MenuId;
                menuActionDto.MenuName =  menuActions[0].MenuName;
                menuActionDto.ParentId =  menuActions[0].ParentId;
                menuActionDto.Path =  menuActions[0].Path;
                menuActionDto.Icon =  menuActions[0].Icon;
                menuActionDto.Actions = menuActions.Select(p=>new ActionDto{
                    ActionId = p.ActionId,
                    ActionName = p.ActionName,
                    ActionCode = p.ActionCode
                }).ToList(); 
            }
            return menuActionDto;
        }
        public async Task<IEnumerable<MenuActionDto>> GetMenuActions()
        {
            var menuActions = await(from menuAtion in _dbContext.DevMenuActions
                                    from menus in _dbContext.DevMenus.Where(m => m.Id == menuAtion.MenuId)
                                    from actions in _dbContext.DevActions.Where(a => a.Id == menuAtion.ActionId)
                                    select new
                                    {
                                        MenuId = menus.Id,
                                        MenuName = menus.MenuName,
                                        ParentId = menus.ParentId,
                                        Path = menus.Path,
                                        Icon = menus.Icon,
                                        ActionId = actions.Id,
                                        ActionName = actions.ActionName,
                                        ActionCode = actions.ActionCode
                                    }).ToListAsync();

            return null;
        }
        #endregion

    }

}