using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Controllers.Rbac
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActionController : ControllerBase
    {
        private readonly IActionService m_actionService;

        public ActionController(IActionService actionService)
        {
            this.m_actionService = actionService;
        }

        [HttpGet("{id}")]
        public IActionResult GetAction(int id)
        {
            return Ok(m_actionService.GetAction(id));
        }

        [HttpGet]
        public IActionResult GetActions()
        {
            return Ok(m_actionService.GetActions()); ;
        }

        [HttpPost]
        public IActionResult AddAction(DevAction action)
        {
            return Ok(m_actionService.AddAction(action));
        }

        [HttpGet("{id}")]
        public IActionResult DeleteAction(int id)
        {
            return Ok(m_actionService.DeleteAction(id));
        }

        [HttpGet("{ids}")]
        public IActionResult DeleteActions(string ids)
        {
            return Ok(m_actionService.DeleteActions(ids));
        }

        [HttpPost]
        public IActionResult ModifyAction(DevAction action)
        {
            return Ok(m_actionService.ModifyAction(action));
        }
    }
}
