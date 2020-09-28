using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
using devitemapi.Common;
using devitemapi.Dto.Storage;
using devitemapi.Entity;
using devitemapi.Enum;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;

namespace devitemapi.Services
{
    public class StorageOutService : BaseService<StorageOut, int>, IStorageOutService
    {
        private readonly IBaseRepository<StorageOut, int> _repository;
        private readonly IMapper _mapper;

        public StorageOutService(IBaseRepository<StorageOut, int> repository,IMapper mapper) : base(repository)
        {
            this._repository = repository ?? throw new System.ArgumentNullException(nameof(repository));
            this._mapper = mapper ?? throw new System.ArgumentNullException(nameof(mapper));
        }

        public async Task<StorageOutDto> CreateStorageOutAsync(StorageOutAddDto storage)
        {
            var storageOut = _mapper.Map<StorageOut>(storage);
            storageOut.OrderNo = CommonTools.CreateOrderNo(SerialNoEnum.StorageOut);
            Add(storageOut);
            await SaveChangeAsync();
            return _mapper.Map<StorageOutDto>(storageOut);
        }

        public async Task DeleteStorageOutByOrderAsync(string orderNo)
        {
            var storageOut = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if(storageOut == null)
            {
                throw new ItemException(TipsTxt.StorageOut_Order_NOT_EXISTS,HttpStatusCode.NotFound);
            }
            Remove(storageOut);
            await SaveChangeAsync();
        }

        public async Task<StorageOutDto> GetStorageOutByOrderNoAsync(string orderNo)
        {
            var storageOut = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if (storageOut == null)
            {
                throw new ItemException(TipsTxt.StorageOut_Order_NOT_EXISTS, HttpStatusCode.NotFound);
            }
            return _mapper.Map<StorageOutDto>(storageOut);
        }

        public async Task<IEnumerable<StorageOutDto>> GetStorageOutsAsync(int pageIndex, int pageSize)
        {
            var storageOuts = await QueryAsync(limit:pageSize,offest:pageIndex);
            return _mapper.Map<IEnumerable<StorageOutDto>>(storageOuts);
        }

        public async Task<StorageOutDto> UpdateStorageOutAsync(string orderNo, StorageOutDto storage)
        {
            var storageOut = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if (storageOut == null)
            {
                throw new ItemException(TipsTxt.StorageOut_Order_NOT_EXISTS, HttpStatusCode.NotFound);
            }
            _mapper.Map(storage,storageOut);
            await SaveChangeAsync();
            return _mapper.Map<StorageOutDto>(storageOut);
        }
    }
}