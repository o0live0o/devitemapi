/*
 * @Author: live0x
 * @Date: 2020-08-18 14:39:05
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 18:03:29
 */

using AutoMapper;
using devitemapi.Dto;
using devitemapi.Dto.Action;
using devitemapi.Entity;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public ActionController(IActionService actionService, IMapper mapper)
        {
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
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> GetActions(int pageSize = 20, int pageIndex = 1)
        {
            var @actions = await _actionService.QueryAsync(null, pageSize, pageIndex);
            return Ok(@actions);
        }

        [HttpPost]
        public async Task<ActionResult<ActionDto>> AddAction(ActionAddDto action)
        {
            var actionEntity = _mapper.Map<DevAction>(action);
            _actionService.Add(actionEntity);
            await _actionService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetActionById), new { }, null);
        }

        /// <summary>
        /// Delete Action
        /// </summary>
        /// <param name="actionId">Action Id</param>
        /// <returns></returns>
        [HttpDelete("{actionId}")]
        public async Task<ActionResult> DeleteAction(Guid actionId)
        {
            ResponseDto response = new ResponseDto();
            var action = await _actionRepository.GetActionAsync(actionId);
            _actionRepository.DeleteAction(action);
            await _actionRepository.SaveAsync();
            return response;
        }

        // [HttpGet("{ids}")]
        // public async Task<ResponseDto> DeleteBatch(string ids)
        // {
        //     return await  _actionService.Delete(ids);
        // }

        [HttpPut("{actionId}")]
        public async Task<ActionResult> UpdateAction(Guid actionId, DevAction action)
        {
            ResponseDto response = new ResponseDto();
            await _actionRepository.SaveAsync();
            return response;
        }
    }
}