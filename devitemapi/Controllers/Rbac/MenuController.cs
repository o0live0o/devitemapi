/*
 * @Author: live0x
 * @Date: 2020-09-07 09:14:27
 * @Last Modified by:   live0x
 * @Last Modified time: 2020-09-07 09:14:27
 */

using AutoMapper;
using devitemapi.Dto.Menu;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("menu")]
    public class MenuController : BaseController
    {
        private readonly IMenuService _menuService;
        private readonly IMapper _mapper;

        public MenuController(IMenuService menuService, IMapper mapper)
        {
            this._mapper = mapper;
            this._menuService = menuService;
        }

        [HttpGet("{menuId}", Name = nameof(GetMenuById))]
        public async Task<ActionResult> GetMenuById(int menuId)
        {
            if (menuId == 0)
            {
                throw new WxException(TipsTxt.MENU_ID_EMPTY);
            }
            var menu = await _menuService.QueryByIdAsync(menuId);
            if (menu == null)
            {
                return NotFound();
            }
            return Ok(menu);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<MenuDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<MenuDto>>> Getmenus(int pageSize = 20, int pageIndex = 1)
        {
            var menus = await _menuService.QueryAsync(pageSize, pageIndex);
            return Ok(menus);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateMenu(MenuAddOrUpdateDto menu)
        {
            var menuEntity = _mapper.Map<WxMenu>(menu);
            _menuService.Add(menuEntity);
            await _menuService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetMenuById), new { menuId = menuEntity.Id }, null);
        }

        [HttpDelete("{menuId}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult> DeleteMenu(int menuId)
        {
            if (menuId == 0)
            {
                throw new WxException(TipsTxt.MENU_ID_EMPTY);
            }
            var menu = await _menuService.QueryByIdAsync(menuId);
            if (menu == null)
            {
                return NotFound();
            }
            _menuService.Remove(menu);
            await _menuService.SaveChangeAsync();
            return NoContent();
        }

        [HttpPut("menuId")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> UpdateMenu(int menuId, MenuAddOrUpdateDto menu)
        {
            if (menuId == 0)
            {
                throw new WxException(TipsTxt.MENU_ID_EMPTY);
            }

            var menuEntity = await _menuService.QueryByIdAsync(menuId);

            if (menuEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(menu, menuEntity);
            await _menuService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetMenuById), new { menuId }, null);
        }

    
    }
}