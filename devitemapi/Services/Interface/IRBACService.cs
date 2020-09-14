/*
 * @Author: live0x 
 * @Date: 2020-09-08 17:47:17 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-14 14:30:29
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto;
using devitemapi.Dto.Rbac;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    /*
        一、用户登录
            1、根据用户Id获取菜单和权限
        二、编辑菜单
            1、根据菜单Id获取菜单的操作方法 
            2、根据菜单Id保存菜单的操作方法 
            3、增加菜单和方法
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