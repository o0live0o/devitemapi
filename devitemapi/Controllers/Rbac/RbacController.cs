/*
 * @Author: live0x
 * @Date: 2020-09-07 11:11:42
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-21 16:52:08
 */

using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Dto.Action;
using devitemapi.Dto.MenuAction;
using devitemapi.Dto.Permission;
using devitemapi.Dto.Rbac;
using devitemapi.Dto.Role;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 登录授权
    /// </summary>
    // [Route("login")]
    [Route("rbac")]
    public class RbacController : BaseController
    {
        private readonly IRbacService _rbacService;

        public RbacController(IRbacService rbacService)
        {
            this._rbacService = rbacService ?? throw new ArgumentNullException(nameof(rbacService));
        }

        #region Menu
        /// <summary>
        /// 添加菜单操作
        /// </summary>
        /// <param name="menuId"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        [Route("menus/{menuId}/actions")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> CreateActionForMenuAsync([FromRoute] int menuId, [FromBody] IEnumerable<ActionDto> actions)
        {
            await _rbacService.CreateActionsForMenuAsync(menuId, actions);
            return CreatedAtRoute(nameof(GetActionsByMenuAsync), new { menuId }, null);
        }

        /// <summary>
        /// 获取菜单对应的操作
        /// </summary>
        /// <param name="menuId"></param>
        /// <returns></returns>
        [Route("menus/{menuId}/actions", Name = nameof(GetActionsByMenuAsync))]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ActionDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<IEnumerable<ActionDto>>> GetActionsByMenuAsync([FromRoute] int menuId)
        {
            var actions = await _rbacService.GetActionsByMenuAsync(menuId);
            return Ok(actions);
        }

        /// <summary>
        /// 获取所有的菜单
        /// </summary>
        /// <returns></returns>
        [Route("menu-actions")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MenuActionsDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<MenuActionsDto>>> GetAllMenuActions()
        {
            var menuActions = await _rbacService.GetMenuActionsAsync();
            return Ok(menuActions);
        }

        /// <summary>
        /// 获取用户拥有的操作权限的菜单树
        /// </summary>
        /// <param name="userId">用户Id</param>
        /// <returns></returns>
        [HttpGet("menu-actions/{userId}")]
        [ProducesResponseType(typeof(TreeDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<TreeDto>> GetMenusByUserId(int userId)
        {
            var menus = await _rbacService.GetMenuTreeByUserAsync(userId);
            return Ok(menus);
        }

        /// <summary>
        /// 获取菜单树
        /// </summary>
        /// <returns></returns>
        [HttpGet("menu-trees")]
        [ProducesResponseType(typeof(TreeDto),(int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetMenuTreesAsync()
        {
            var menus = await _rbacService.GetMenuTreesAsync();
            return Ok(menus);
        }
        #endregion

        #region Role
        [Route("role/{roleId}/permissions")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreatePermissionForRoleAsync([FromRoute] int roleId, [FromBody] IEnumerable<PermissionAddDto> permissions)
        {
            await _rbacService.CreatePermissionForRoleAsync(roleId, permissions);
            return CreatedAtRoute(nameof(GetPermissionByRoleAsync), new { roleId }, null);
        }

        [Route("role/{roleId}/permissions", Name = nameof(GetPermissionByRoleAsync))]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<PermissionDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<PermissionDto>>> GetPermissionByRoleAsync([FromRoute] int roleId)
        {
            var permissions = await _rbacService.GetPermissionByRoleAsync(roleId);
            return Ok(permissions);
        }
        #endregion

        #region User
        [Route("user/{userId}/user-role")]
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateUserRoleForUserAsync([FromRoute] int userId, [FromBody] IEnumerable<RoleDto> roles)
        {
            await _rbacService.CreateUserRoleForUser(userId, roles);
            return CreatedAtRoute(nameof(GetUserRoleByUserAsync), new { userId }, null);
        }

        [Route("user/{userId}/user-role", Name = nameof(GetUserRoleByUserAsync))]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RoleDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetUserRoleByUserAsync([FromRoute] int userId)
        {
            var roles = await _rbacService.GetUserRoleByUserAsync(userId);
            return Ok(roles);
        }
        #endregion
    }
}