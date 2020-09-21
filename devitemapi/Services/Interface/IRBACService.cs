/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:17 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 16:22:03
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto;
using devitemapi.Dto.Action;
using devitemapi.Dto.MenuAction;
using devitemapi.Dto.Permission;
using devitemapi.Dto.Rbac;
using devitemapi.Dto.Role;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    /*
        一、用户登录
            1、根据用户Id获取菜单和权限
        二、编辑菜单
            1、根据菜单Id获取菜单的操作方法 
            2、根据菜单Id保存菜单的操作方法 
        三、角色授权
            1、获取所有菜单和操作方法
            2、根据角色ID保存菜单和操作方法4
            3、新增角色和对应的操作权限
        四、用户授权
            1、获取用户拥有的角色
            2、根据用户Id 新增/修改角色
    */
    public interface IRbacService
    {
        #region Login
        /// <summary>
        /// 跟用用户Id获取菜单和权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<TreeDto> GetMenuTreeByUserAsync(Guid userId);
        #endregion

        #region Menu
        Task CreateActionsForMenuAsync(Guid menuId,IEnumerable<ActionDto> actions);

        /// <summary>
        /// 根据菜单Id获取菜单的操作方法
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        Task<IEnumerable<ActionDto>> GetActionsByMenuAsync(Guid menuId);

        /// <summary>
        /// 获取所有菜单和操作方法
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MenuActionsDto>> GetMenuActionsAsync();

        #endregion

        #region Role
        Task CreatePermissionForRoleAsync(Guid roleId, IEnumerable<PermissionAddDto> permissions);
        
        Task<IEnumerable<MenuActionsDto>> GetPermissionByRoleAsync(Guid roleId);

        #endregion

        #region User
        Task<IEnumerable<RoleDto>> GetUserRoleByUserAsync(Guid userId);
        Task CreateUserRoleForUser(Guid userId, IEnumerable<RoleDto> roles);
        #endregion




    }
}