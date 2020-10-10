/*
 * @Author: live0x 
 * @Date: 2020-10-10 10:27:17 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-10-10 10:27:17 
 */
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace devitemapi.Controllers.v1
{
    public class StorageOutController : BaseController
    {
        private readonly IStorageOutService _storageOutService;

        public StorageOutController(IStorageOutService storageOutService)
        {
            this._storageOutService = storageOutService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<StorageOutDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<StorageOutDto>>> GetStorageOutsAsync(int pageIndex = 1, int pageSize = 20)
        {
            var storageOuts = await _storageOutService.GetStorageOutsAsync(pageIndex, pageSize);
            return Ok(storageOuts);
        }

        [HttpGet]
        [Route("{orderNo}", Name = nameof(GetStorageOutByOrderNoAsync))]
        [ProducesResponseType(typeof(StorageOutDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult<StorageOutDto>> GetStorageOutByOrderNoAsync(string orderNo)
        {
            var dto = await _storageOutService.GetStorageOutByOrderNoAsync(orderNo);
            if (dto == null)
            {
                return NotFound();
            }
            return Ok(dto);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateStorageOutAsync(StorageOutAddDto storage)
        {
            if (storage == null)
            {
                return BadRequest();
            }
            var dto = await _storageOutService.CreateStorageOutAsync(storage);
            return CreatedAtRoute(nameof(GetStorageOutByOrderNoAsync), new { orderNo = dto.OrderNo }, null);
        }
        
        [HttpPut]
        [Route("{orderNo}")]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> UpdateStorageOutAsync([FromRoute]string orderNo,[FromBody]StorageOutDto storage)
        {
            var dto =await _storageOutService.GetStorageOutByOrderNoAsync(orderNo);
            if(dto == null)
            {
                return NotFound();
            }
            var storageOut = await _storageOutService.UpdateStorageOutAsync(orderNo,storage);
            return CreatedAtRoute(nameof(GetStorageOutByOrderNoAsync),new {orderNo},null);
        }

        [HttpDelete]
        [Route("{orderNo}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult> DeleteStorageOutByOrderAsync([FromRoute]string orderNo)
        {
            await _storageOutService.DeleteStorageOutByOrderAsync(orderNo);
            return NoContent();
        }
    }
}