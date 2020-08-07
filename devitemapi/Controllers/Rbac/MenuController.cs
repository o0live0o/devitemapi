using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Dtos;
using devitemapi.Entities;
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
    public class MenuController : BaseController
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            this._menuService = menuService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await _menuService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await _menuService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevMenu menu)
        {
            return await _menuService.Add(menu);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await _menuService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> DeleteBatch(string ids)
        {
            return await _menuService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevMenu menu)
        {
            return await _menuService.Modify(menu);
        }
    }
}
