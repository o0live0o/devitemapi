/*
 * @Author: live0x
 * @Date: 2020-08-18 14:39:05
 * @Last Modified by: live0x
 * @Last Modified time: 2020-10-29 10:29:30
 */

using AutoMapper;
using devitemapi.Core.Utils;
using devitemapi.Core.Wbl;
using devitemapi.Dto.Action;
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
    /// 菜单功能
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("actions")]
    public class ActionController : BaseController
    {
        private readonly IActionService _actionService;
        private readonly IMapper _mapper;
        private readonly DevDbContext _dbContext;
        private readonly WblSpider _wblSpider;

        public ActionController(IActionService actionService, IMapper mapper, DevDbContext dbContext,WblSpider wblSpider)
        {
            this._dbContext = dbContext;
            this._wblSpider = wblSpider;
            this._mapper = mapper;
            this._actionService = actionService;
        }

        /// <summary>
        /// Get action
        /// </summary>
        /// <param name="actionId">方法Id</param>
        /// <returns></returns>
        [HttpGet("{actionId}", Name = nameof(GetActionById))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ActionDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetActionById([FromRoute] Guid actionId)
        {
            var @action = await _actionService.QueryByIdAsync(actionId);
            if (@action == null)
            {
                return NotFound();
            }
            var actionDto = _mapper.Map<ActionDto>(@action);
            return Ok(actionDto);
        }

        /// <summary>
        /// Get all actions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ActionDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<ActionDto>>> GetActions(int pageSize = 20, int pageIndex = 1)
        {
            var gateWays = _wblSpider.GetGateWays();
            _wblSpider.GetGoldPrice(gateWays);
            var @actions = await _actionService.QueryAsync(null, pageSize, pageIndex);
            return Ok(@actions);
        }

        [HttpPost]
        public async Task<ActionResult<ActionDto>> AddAction(ActionAddOrUpdateDto action)
        {
            var actionEntity = _mapper.Map<DevAction>(action);
            _actionService.Add(actionEntity);
            await _actionService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetActionById), new { actionId = actionEntity.Id }, null);
        }

        /// <summary>
        /// Delete Action
        /// </summary>
        /// <param name="actionId">Action Id</param>
        /// <returns></returns>
        [HttpDelete("{actionId}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult> DeleteAction(Guid actionId)
        {
            if (actionId == Guid.Empty)
            {
                throw new ItemException(TipsTxt.ACTION_EMPTY_ID);
            }

            var actionEtity = await _actionService.QueryByIdAsync(actionId);
            if (actionEtity == null)
            {
                return NotFound();
            }

            _actionService.Remove(actionEtity);
            await _actionService.SaveChangeAsync();
            return NoContent();
        }

        // [HttpGet("{ids}")]
        // public async Task<ResponseDto> DeleteBatch(string ids)
        // {
        //     return await  _actionService.Delete(ids);
        // }

        [HttpPut("{actionId}")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> UpdateAction(Guid actionId, ActionAddOrUpdateDto action)
        {
            if (actionId == Guid.Empty)
            {
                throw new ItemException(TipsTxt.ACTION_EMPTY_ID);
            }

            var actionEntity = await _actionService.QueryByIdAsync(actionId);
            if (actionEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(action, actionEntity);

            await _actionService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetActionById), new { actionId }, null);
        }

        // [HttpGet]
        // [Route("test")]
        // public IActionResult Test()
        // {
        //     var blog = new Blog();
        //     blog.Url = "www.baidu.com";
        //     blog.Posts.Add(
        //         new Post(){
        //             Title = "Hello World",
        //             Content = "I wrote an app using EF Core!"
        //         }
        //     );
        //     _dbContext.Blogs.Add(blog);
        //     _dbContext.SaveChanges();
            
        //     var blogs = _dbContext.Blogs;
        //     return Ok(blogs);
        // }
    }
}