using AutoMapper;
using devitemapi.Dto.Storage;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Profiles
{
    public class StorageProfile:Profile
    {
        public StorageProfile()
        {
            CreateMap<StorageIn, StorageInDto>();
            CreateMap<StorageInAddDto,StorageIn>();
            CreateMap<StorageOut,StorageOutDto>();
            CreateMap<StorageOutAddDto,StorageOut>();
        }
    }
}