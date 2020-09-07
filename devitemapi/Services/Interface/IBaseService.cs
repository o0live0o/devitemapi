/*
 * @Author: live0x
 * @Date: 2020-09-04 12:01:46
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 16:16:27
 */

using devitemapi.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IBaseService<T> where T : IEntity
    {
        void Remove(T t);

        Task<bool> RemoveAsync(Expression<Func<T, bool>> func);

        Task<T> QueryByIdAsync(Guid id);

        Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> func, int pageSize = 20, int pageIndex = 0);

        Task<IEnumerable<T>> QueryAsync(Expression<Func<T, bool>> func);

        Task<IEnumerable<T>> QueryAsync(int limit = 20, int offest = 0);

        void Add(T t);

        Task<bool> SaveChangeAsync();
    }
}