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
    /// 菜单功能
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    public class ActionController : BaseController
    {
        private readonly IActionService _actionService;

        public ActionController(IActionService actionService)
        {
            this._actionService = actionService;
        }

        [HttpGet("{guid}")]
        public async Task<ResponseDto> Get(Guid guid)
        {
            return await _actionService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await _actionService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevAction action)
        {
            return await _actionService.Add(action);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await _actionService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> DeleteBatch(string ids)
        {
            return await  _actionService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevAction action)
        {
            return await _actionService.Modify(action);
        }
    }
}
