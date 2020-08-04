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
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService m_menuService;

        public MenuController(IMenuService menuService)
        {
            this.m_menuService = menuService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await m_menuService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await m_menuService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevMenu menu)
        {
            return await m_menuService.Add(menu);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await m_menuService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> Delete(string ids)
        {
            return await m_menuService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevMenu menu)
        {
            return await m_menuService.Modify(menu);
        }
    }
}
