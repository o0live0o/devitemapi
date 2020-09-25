/*
 * @Author: live0x 
 * @Date: 2020-09-25 10:34:14 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 11:12:36
 */
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;

namespace devitemapi.Services.Interface
{
    public interface IStorageService
    {
        Task<IEnumerable<StorageInDto>> GetStorageInsAsync(int pageIndex, int pageSize);
        Task<StorageInDto> GetStorageInByOrderNoAsync(string orderNo);
        Task<StorageInDto> CreateStorageInAsync(StorageInAddDto storageIn);
        Task UpdateStorageInAsync(string orderNo, StorageInDto storageIn);
        Task DeleteStorageInByOrderNoAsync(string orderNo);
    }
}