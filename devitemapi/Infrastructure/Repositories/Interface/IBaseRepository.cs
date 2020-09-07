/*
 * @Author: live0x
 * @Date: 2020-09-04 14:40:01
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 15:49:11
 */

using devitemapi.Entity;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Repositories.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : IEntity
    {
        Task<IEnumerable<TEntity>> QueryAsync();

        Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> @where);

        Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> @where, int pageSize, int pageIndex);

        Task<TEntity> QueryFirstAsync();

        Task<TEntity> QueryFirstAsync(Guid id);

        Task<TEntity> QueryFirstAsync(Expression<Func<TEntity, bool>> @where);

        EntityEntry<TEntity> Remove(TEntity entity);

        Task<bool> RemoveAsync(Expression<Func<TEntity, bool>> @where);

        Task<bool> SaveAsync();

        void Add(TEntity entity);
    }
}