/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:42 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 16:47:31
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Dto;
using devitemapi.Dto.Action;
using devitemapi.Dto.Menu;
using devitemapi.Dto.MenuAction;
using devitemapi.Dto.Permission;
using devitemapi.Dto.Rbac;
using devitemapi.Dto.Role;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Services
{
    public class RbacService : IRbacService
    {
        private readonly DevDbContext _dbContext;

        private readonly IMapper _autoMapper;

        public RbacService(DevDbContext dbContext,
                           IMapper autoMapper)
        {
            this._dbContext = dbContext ?? throw new System.ArgumentNullException(nameof(dbContext));
            this._autoMapper = autoMapper ?? throw new ArgumentNullException(nameof(autoMapper));
        }
        public bool IsAdministrtor = true;

        #region 树型菜单
        public async Task<TreeDto> GetMenuTreeByUserAsync(Guid userId)
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
                                              from menus in _dbContext.DevMenus.Where(m => m.Id == permissons.MenuId).DefaultIfEmpty()
                                              from actions in _dbContext.DevActions.Where(a => a.Id == permissons.ActionId).DefaultIfEmpty()
                                              where userRole.UseId == userId
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
                                 where roles_userRole.UseId == userId
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

        #region Menu
        public async Task CreateActionsForMenuAsync(Guid menuId, IEnumerable<ActionDto> actions)
        {
            var menu = await _dbContext.DevMenus.Where(p => p.Id == menuId).FirstOrDefaultAsync();

            if (menu == null)
            {
                throw new ItemException(TipsTxt.MENU_NOT_EXISTS);
            }

            var menuActions = _dbContext.DevMenuActions.Where(p => p.MenuId == menuId);

            _dbContext.RemoveRange(menuActions);

            foreach (var item in actions)
            {
                menu.DevMenuActions.Add(new DevMenuAction()
                {
                    ActionId = item.ActionId
                });
            }

            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ActionDto>> GetActionsByMenuAsync(Guid menuId)
        {
            var menu = await _dbContext.DevMenus.Where(p => p.Id == menuId).FirstOrDefaultAsync();

            if (menu == null)
            {
                throw new ItemException(TipsTxt.MENU_NOT_EXISTS);
            }

            var actionDtos = (from menuActions in _dbContext.DevMenuActions
                              from @action in _dbContext.DevActions
                              where @action.Id == menuActions.ActionId
                              where menuActions.MenuId == menuId
                              select new ActionDto
                              {
                                  ActionCode = @action.ActionCode,
                                  ActionName = @action.ActionName,
                                  ActionId = @action.Id
                              });
            return await actionDtos.ToListAsync();
        }

        public async Task<IEnumerable<MenuActionsDto>> GetMenuActionsAsync()
        {
            var menus = await _dbContext.DevMenus.ToListAsync();

            var menuActions = from menuAction in _dbContext.DevMenuActions
                              from @actions in _dbContext.DevActions
                              where @actions.Id == menuAction.ActionId
                              select new
                              {
                                  MenuId = menuAction.MenuId,
                                  ActionId = @actions.Id,
                                  ActionName = @actions.ActionName,
                                  ActionCode = @actions.ActionCode
                              };

            List<MenuActionsDto> list = new List<MenuActionsDto>();
            var menuDtos = _autoMapper.Map<IEnumerable<MenuDto>>(menus);
            foreach (var menu in menuDtos)
            {
                MenuActionsDto menuActionsDto = new MenuActionsDto()
                {
                    Menu = menu
                };

                var menuAction = from p in menuActions
                                 where p.MenuId == menu.MenuId
                                 select new ActionDto
                                 {
                                     ActionCode = p.ActionCode,
                                     ActionId = p.ActionId,
                                     ActionName = p.ActionName
                                 };

                menuActionsDto.Actions.AddRange(menuAction);
                list.Add(menuActionsDto);
            }
            return list;

        }

        public async Task CreatePermissionForRoleAsync(Guid roleId, IEnumerable<PermissionAddDto> permissions)
        {
            var role = await _dbContext.DevRoles.Where(p => p.Id == roleId).FirstOrDefaultAsync();

            if(role == null)
            {
                throw new ItemException(TipsTxt.ROLE_NOT_EXISTS);
            }

        }

        public async Task<IEnumerable<MenuActionsDto>> GetPermissionByRoleAsync(Guid roleId)
        {
            var role = await _dbContext.DevRoles.Where(p => p.Id == roleId).FirstOrDefaultAsync();

            if (role == null)
            {
                throw new ItemException(TipsTxt.ROLE_NOT_EXISTS);
            }

            return  GetMenuActionByRoleId(roleId);
            
        }

        private IEnumerable<MenuActionsDto> GetMenuActionByRoleId(Guid roleId)
        {
            var menuActions = (from menuAction in _dbContext.DevPermissions
                              from action in _dbContext.DevActions where action.Id == menuAction.ActionId
                              where menuAction.RoleId == roleId
                              select new {
                                  MenuId = menuAction.MenuId,
                                  ActionId = action.Id,
                                  ActionName = action.ActionName,
                                  ActionCode = action.ActionCode
                              }).ToList();
            var menus = (from menuAction in _dbContext.DevPermissions
                        from menu in _dbContext.DevMenus
                        where menu.Id == menuAction.MenuId
                        where menuAction.RoleId == roleId
                        select new MenuDto
                        {
                            MenuId = menu.Id,
                            MenuCode = menu.MenuCode,
                            Path = menu.Path,
                            ParentId = menu.ParentId,
                            MenuName = menu.MenuName,
                        }).ToList();
            
            foreach(var menu in menus)
            {
                MenuActionsDto menuActionsDto = new MenuActionsDto()
                {
                    Menu = menu                   
                };
                var menuAction = (from p in menuActions
                                 where p.MenuId == menu.MenuId
                                 select new ActionDto
                                 {
                                     ActionCode = p.ActionCode,
                                     ActionId = p.ActionId,
                                     ActionName = p.ActionName
                                 }).ToList();

                menuActionsDto.Actions.AddRange(menuAction);
                yield return menuActionsDto;
            }
        }

        public async Task<IEnumerable<RoleDto>> GetUserRoleByUserAsync(Guid userId)
        {
            var user = await _dbContext.DevUsers.Where(p => p.Id == userId).FirstOrDefaultAsync();
            if(user == null)
            {
                throw new ItemException(TipsTxt.USER_NOT_EXISTS);
            }

            var roles = (from userRole in _dbContext.DevUserRoles
                        from role in _dbContext.DevRoles
                        where role.Id == userRole.RoleId
                        where userRole.UseId == userId
                        select role).AsEnumerable();
            var roleDtos = _autoMapper.Map<IEnumerable<RoleDto>>(roles);
            return roleDtos;
        }

        public async Task CreateUserRoleForUser(Guid userId, IEnumerable<RoleDto> roles)
        {
            var user = await _dbContext.DevUsers.Where(p => p.Id == userId).FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ItemException(TipsTxt.USER_NOT_EXISTS);
            }
            var userRole = await _dbContext.DevUserRoles.Where(p => p.UseId == userId).ToListAsync();

            _dbContext.DevUserRoles.RemoveRange(userRole);

            foreach(var item in roles)
            {
                user.DevUserRoles.Add(new DevUserRole(){
                    RoleId = item.RoleId
                });
            }

            await _dbContext.SaveChangesAsync();
        }
        #endregion


        // public async Task<MenuActionDto> GetActionsByMenu(Guid menuId)
        // {
        //     var menuActions =await (from menuAtion in _dbContext.DevMenuActions
        //     from menus in _dbContext.DevMenus.Where(m => m.Id == menuAtion.MenuId)
        //     from actions in _dbContext.DevActions.Where(a => a.Id == menuAtion.ActionId)
        //     where menuAtion.MenuId == menuId
        //     select new {
        //         MenuId = menus.Id,
        //         MenuName = menus.MenuName,
        //         ParentId = menus.ParentId,
        //         Path = menus.Path,
        //         Icon = menus.Icon,
        //         ActionId = actions.Id,
        //         ActionName = actions.ActionName,
        //         ActionCode = actions.ActionCode
        //     }).ToListAsync();

        //     MenuActionDto menuActionDto = new MenuActionDto();

        //     if(menuActions.Count() > 0)
        //     {
        //         menuActionDto.MenuId =  menuActions[0].MenuId;
        //         menuActionDto.MenuName =  menuActions[0].MenuName;
        //         menuActionDto.ParentId =  menuActions[0].ParentId;
        //         menuActionDto.Path =  menuActions[0].Path;
        //         menuActionDto.Icon =  menuActions[0].Icon;
        //         menuActionDto.Actions = menuActions.Select(p=>new ActionDto{
        //             ActionId = p.ActionId,
        //             ActionName = p.ActionName,
        //             ActionCode = p.ActionCode
        //         }).ToList(); 
        //     }
        //     return menuActionDto;
        // }
        // public async Task<IEnumerable<MenuActionDto>> GetMenuActions()
        // {
        //     var menuActions = await(from menuAtion in _dbContext.DevMenuActions
        //                             from menus in _dbContext.DevMenus.Where(m => m.Id == menuAtion.MenuId)
        //                             from actions in _dbContext.DevActions.Where(a => a.Id == menuAtion.ActionId)
        //                             select new
        //                             {
        //                                 MenuId = menus.Id,
        //                                 MenuName = menus.MenuName,
        //                                 ParentId = menus.ParentId,
        //                                 Path = menus.Path,
        //                                 Icon = menus.Icon,
        //                                 ActionId = actions.Id,
        //                                 ActionName = actions.ActionName,
        //                                 ActionCode = actions.ActionCode
        //                             }).ToListAsync();

        //     return null;
        // }
        #endregion

    }

}