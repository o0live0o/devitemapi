using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Common;
using devitemapi.Dto.Storage;
using devitemapi.Entity;
using devitemapi.Enum;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;

namespace devitemapi.Services
{
    public class StorageInService : BaseService<StorageIn, int>, IStorageInService
    {
        private readonly IBaseRepository<StorageIn, int> _repository;
        private readonly IMapper _mapper;

        public StorageInService(IBaseRepository<StorageIn, int> repository,
                                IMapper mapper) : base(repository)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<StorageInDto> CreateStorageInAsync(StorageInAddDto storageInAddDto)
        {
            var storageIn = _mapper.Map<StorageIn>(storageInAddDto);
            var orderNo = CommonTools.CreateOrderNo(SerialNoEnum.StorageIn);
            storageIn.OrderNo = orderNo;
            _repository.Add(storageIn);
            await SaveChangeAsync(); 
            return _mapper.Map<StorageInDto>(storageIn);
        }

        public Task DeleteStorageInByOrderNoAsync(string orderNo)
        {
            
            throw new NotImplementedException();
        }

        public Task<StorageInDto> GetStorageInByOrderNoAsync(string orderNo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StorageInDto>> GetStorageInsAsync(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task UpdateStorageInAsync(string orderNo, StorageInDto storageIn)
        {
            throw new NotImplementedException();
        }
    }
}