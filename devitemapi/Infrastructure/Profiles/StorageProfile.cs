using AutoMapper;
using devitemapi.Dto.Storage;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Profiles
{
    public class StorageProfile:Profile
    {
        public StorageProfile()
        {
            CreateMap<WxStorageIn, StorageInDto>();
            CreateMap<StorageInAddDto,WxStorageIn>();
            CreateMap<WxStorageOut,StorageOutDto>();
            CreateMap<StorageOutAddDto,WxStorageOut>();
        }
    }
}