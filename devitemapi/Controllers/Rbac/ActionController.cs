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
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IActionService m_actionService;

        public ActionController(IActionService actionService)
        {
            this.m_actionService = actionService;
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Get(int id)
        {
            return await m_actionService.Get(id);
        }

        [HttpGet]
        public async Task<ResponseDto> Get()
        {
            return await m_actionService.Get();
        }

        [HttpPost]
        public async Task<ResponseDto> Add(DevAction action)
        {
            return await m_actionService.Add(action);
        }

        [HttpGet("{id}")]
        public async Task<ResponseDto> Delete(int id)
        {
            return await m_actionService.Delete(id);
        }

        [HttpGet("{ids}")]
        public async Task<ResponseDto> Delete(string ids)
        {
            return await  m_actionService.Delete(ids);
        }

        [HttpPost]
        public async Task<ResponseDto> Modify(DevAction action)
        {
            return await m_actionService.Modify(action);
        }
    }
}
