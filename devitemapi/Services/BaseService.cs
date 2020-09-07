/*
 * @Author: live0x
 * @Date: 2020-09-04 10:17:27
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 18:00:10
 */

using devitemapi.Entity;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class BaseService<T> : IBaseService<T> where T : IEntity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            this._repository = repository;
        }

        public virtual void Add(T t)
        {
            _repository.Add(t);
        }

        public virtual async Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> func, int pageSize, int pageIndex)
        {
            return await _repository.QueryAsync(func, pageSize, pageIndex);
        }

        public virtual async Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> func)
        {
            return await _repository.QueryAsync(func);
        }

        public virtual async Task<IEnumerable<T>> QueryAsync(int limit = 20, int offest = 0)
        {
            return await _repository.QueryAsync();
        }

        public async Task<T> QueryByIdAsync(Guid id)
        {
            return await _repository.QueryFirstAsync(id);
        }

        public virtual void Remove(T t)
        {
            _repository.Remove(t);
        }

        public Task<bool> RemoveAsync(Expression<Func<T, bool>> func)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await _repository.SaveAsync();
        }
    }
}