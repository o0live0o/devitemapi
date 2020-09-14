/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:17 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-14 11:38:39
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto;
using devitemapi.Dto.Rbac;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    public interface IRbacService
    {
        /// <summary>
        /// 跟用用户Id获取菜单和权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<TreeDto> GetMenuTreeByUser(Guid userId);

        // /// <summary>
        // /// 根据角色Id获取角色操作权限
        // /// </summary>
        // /// <param name="roleId"></param>
        // /// <returns></returns>
        //Task<DevPermission> GetPermissionByRoleId(Guid roleId);
        
        /// <summary>
        /// 根据菜单Id获取菜单的操作方法
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        Task<MenuActionDto> GetMenuActionsByMenuId(Guid menuId);

        /// <summary>
        /// 获取所有菜单和操作方法
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MenuActionDto>> GetMenuActions();

    }
}