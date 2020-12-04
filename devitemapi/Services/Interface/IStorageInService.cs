/*
 * @Author: live0x 
 * @Date: 2020-09-25 10:34:14 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-26 09:27:51
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    public interface IStorageInService:IBaseService<WxStorageIn,int>
    {
        Task<IEnumerable<StorageInDto>> GetStorageInsAsync(int pageIndex, int pageSize);
        Task<StorageInDto> GetStorageInByOrderNoAsync(string orderNo);
        Task<StorageInDto> CreateStorageInAsync(StorageInAddDto storageIn);
        Task UpdateStorageInAsync(string orderNo, StorageInDto storageIn);
        Task DeleteStorageInByOrderNoAsync(string orderNo);
    }
}