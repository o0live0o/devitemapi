using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Controllers.Rbac
{

    /// <summary>
    /// 菜单管理
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("menus")]
    public class MenuController : BaseController
    {
        private readonly IDevMenuRepository _menuRepository;

        public MenuController(IDevMenuRepository menuRepository)
        {
            this._menuRepository = menuRepository;
        }

        [HttpGet("{menuId}")]
        public async Task<ResponseDto> GetMenu(Guid menuId)
        {
            ResponseDto response = new ResponseDto();
            var menu = await _menuRepository.GetMenuAsync(menuId);
            return response.SetData(menu);
        }

        [HttpGet]
        public async Task<ResponseDto> GetMenus()
        {
            ResponseDto response = new ResponseDto();
            return response.SetData(await _menuRepository.GetMenusAsync());
        }

        [HttpPost]
        public async Task<ResponseDto> CreateMenu(DevMenu menu)
        {
            ResponseDto response = new ResponseDto();
            _menuRepository.AddMenu(menu);
            await _menuRepository.SaveAsync();
            return response;
        }

        [HttpDelete("{menuId}")]
        public async Task<ResponseDto> DeleteMenu(Guid menuId)
        {
            ResponseDto response = new ResponseDto();
            var menu = await _menuRepository.GetMenuAsync(menuId);
            _menuRepository.DeleteMenu(menu);
            await _menuRepository.SaveAsync();
            return response;
        }


        [HttpPut("{meunId}")]
        public async Task<ResponseDto> UpdateMenu(Guid menuId, DevMenu menu)
        {
            ResponseDto response = new ResponseDto();
            _menuRepository.UpdateMenu(menu);
            await _menuRepository.SaveAsync();
            return response;
        }
    }
}
