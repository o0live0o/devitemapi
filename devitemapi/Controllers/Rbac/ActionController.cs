/*
 * @Author: live0x
 * @Date: 2020-08-18 14:39:05
 * @Last Modified by: live0x
 * @Last Modified time: 2020-08-18 14:40:28
 */

using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
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
        private readonly IDevActionRepository _actionRepository;

        public ActionController(IDevActionRepository actionRepository)
        {
            this._actionRepository = actionRepository;
        }

        /// <summary>
        /// Get action
        /// </summary>
        /// <param name="actionId">方法Id</param>
        /// <returns></returns>
        [HttpGet("{actionId}")]
        public async Task<ResponseDto> GetActionById([FromRoute] Guid actionId)
        {
            ResponseDto response = new ResponseDto();
            var actions = await _actionRepository.GetActionAsync(actionId);
            response.SetData(actions);
            return response;
        }

        /// <summary>
        /// Get all actions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ResponseDto> GetActions()
        {
            ResponseDto response = new ResponseDto();
            var actions = await _actionRepository.GetActionsAsync();
            response.SetData(actions);
            return response;
        }

        [HttpPost]
        public async Task<ResponseDto> AddAction(DevAction action)
        {
            ResponseDto response = new ResponseDto();
            _actionRepository.AddAction(action);
            await _actionRepository.SaveAsync();
            return response;
        }

        /// <summary>
        /// Delete Action
        /// </summary>
        /// <param name="actionId">Action Id</param>
        /// <returns></returns>
        [HttpDelete("{actionId}")]
        public async Task<ResponseDto> DeleteAction(Guid actionId)
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
        public async Task<ResponseDto> UpdateAction(Guid actionId, DevAction action)
        {
            ResponseDto response = new ResponseDto();
            await _actionRepository.SaveAsync();
            return response;
        }
    }
}