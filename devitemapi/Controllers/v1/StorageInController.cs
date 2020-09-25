/*
 * @Author: live0x 
 * @Date: 2020-09-25 10:21:55 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 16:56:06
 */
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Controllers.v1
{
    [Route("storagein")]
    public class StorageInController : BaseController
    {
        private readonly IStorageService _storageService;

        public StorageInController(IStorageService storageService)
        {
            this._storageService = storageService;
        }

        /// <summary>
        /// 获取出库单数据
        /// </summary>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页面大小</param>
        /// <returns>出库单数据</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorageInDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<StorageInDto>>> GetStorageInsAsync(int pageIndex, int pageSize)
        {
            var storageIns = await _storageService.GetStorageInsAsync(pageIndex, pageSize);
            return Ok(storageIns);
        }

        /// <summary>
        /// 根据订单号获取出库单数据    
        /// </summary>
        /// <param name="orderNo">订单号</param>
        /// <returns>出库单数据</returns>
        [HttpGet]
        [Route("{orderNo}", Name = nameof(GetStorageInByOrderNoAsync))]
        [ProducesResponseType(typeof(StorageInDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult<StorageInDto>> GetStorageInByOrderNoAsync([FromRoute] string orderNo)
        {
            var stroageDto = await _storageService.GetStorageInByOrderNoAsync(orderNo);
            if (stroageDto == null)
            {
                return NotFound();
            }
            return Ok(stroageDto);
        }

        /// <summary>
        /// 创建入库单
        /// </summary>
        /// <param name="storageIn">入库单实体</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateStorageInAsync([FromBody] StorageInAddDto storageIn)
        {
            var storageInDto = await _storageService.CreateStorageInAsync(storageIn);
            return CreatedAtAction(nameof(GetStorageInByOrderNoAsync), new { orderNo = storageInDto.OrderNo }, null);
        }

        [HttpPut]
        [Route("{orderNo}")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> UpdateStorageInAsync([FromRoute] string orderNo, [FromBody] StorageInDto storageIn)
        {
            var storageDto = await _storageService.GetStorageInByOrderNoAsync(orderNo);
            if (storageDto == null)
            {
                return NotFound();
            }
            await _storageService.UpdateStorageInAsync(orderNo, storageIn);
            return CreatedAtAction(nameof(GetStorageInByOrderNoAsync), new { orderNo }, null);
        }

        [HttpDelete]
        [Route("orderNo")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> DeleteStorageInByOrderNoAsync([FromRoute] string orderNo)
        {
            await _storageService.DeleteStorageInByOrderNoAsync(orderNo);
            return NoContent();
        }
    }
}