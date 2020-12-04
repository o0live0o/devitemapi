using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
    public class StorageInService : BaseService<WxStorageIn, int>, IStorageInService
    {
        private readonly IBaseRepository<WxStorageIn, int> _repository;
        private readonly IMapper _mapper;

        public StorageInService(IBaseRepository<WxStorageIn, int> repository,
                                IMapper mapper) : base(repository)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<StorageInDto> CreateStorageInAsync(StorageInAddDto storageInAddDto)
        {
            var storageIn = _mapper.Map<WxStorageIn>(storageInAddDto);
            var orderNo = CommonTools.CreateOrderNo(SerialNoEnum.StorageIn);
            storageIn.OrderNo = orderNo;
            _repository.Add(storageIn);
            await SaveChangeAsync();
            return _mapper.Map<StorageInDto>(storageIn);
        }

        public async Task DeleteStorageInByOrderNoAsync(string orderNo)
        {
            var order = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if (order == null)
            {
                throw new ItemException(TipsTxt.StorageIn_Order_NOT_EXISTS, HttpStatusCode.NotFound);
            }
            Remove(order);
            await SaveChangeAsync();
        }

        public async Task<StorageInDto> GetStorageInByOrderNoAsync(string orderNo)
        {
            var order = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if (order == null)
            {
                throw new ItemException(TipsTxt.StorageIn_Order_NOT_EXISTS, HttpStatusCode.NotFound);
            }
            return _mapper.Map<StorageInDto>(order);
        }

        public async Task<IEnumerable<StorageInDto>> GetStorageInsAsync(int pageIndex, int pageSize)
        {
            var storageIns = await QueryAsync(offest: pageIndex, limit: pageSize);
            return _mapper.Map<IEnumerable<StorageInDto>>(storageIns);
        }

        public async Task UpdateStorageInAsync(string orderNo, StorageInDto storageIn)
        {
            var order = await QueryFirstAsync(p => p.OrderNo == orderNo);
            if(order == null)
            {
                throw new ItemException(TipsTxt.StorageIn_Order_NOT_EXISTS,HttpStatusCode.NotFound);
            }
            _mapper.Map(order,storageIn);
            await SaveChangeAsync();
        }
    }
}