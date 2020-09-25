using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Dto.Storage;

namespace devitemapi.Services.Interface
{
    public interface IStorageOutService
    {
        Task<IEnumerable<StorageOutDto>> GetStorageOutsAsync(int pageIndex, int pageSize);
        Task<StorageOutDto> GetStorageOutByOrderNoAsync(string orderNo);
        Task<StorageOutDto> CreateStorageOutAsync(StorageOutAddDto storage);
        Task<StorageOutDto> UpdateStorageOutAsync(string orderNo, StorageOutDto storage);
        Task DeleteStorageOutByOrderAsync(string orderNo);
    }
}