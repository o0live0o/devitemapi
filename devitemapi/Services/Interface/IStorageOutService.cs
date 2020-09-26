using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;
using devitemapi.Entity;

namespace devitemapi.Services.Interface
{
    public interface IStorageOutService:IBaseService<StorageOut,int>
    {
        Task<IEnumerable<StorageOutDto>> GetStorageOutsAsync(int pageIndex, int pageSize);
        Task<StorageOutDto> GetStorageOutByOrderNoAsync(string orderNo);
        Task<StorageOutDto> CreateStorageOutAsync(StorageOutAddDto storage);
        Task<StorageOutDto> UpdateStorageOutAsync(string orderNo, StorageOutDto storage);
        Task DeleteStorageOutByOrderAsync(string orderNo);
    }
}