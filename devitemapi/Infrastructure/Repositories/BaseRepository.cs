/*
 * @Author: live0x 
 * @Date: 2020-09-04 10:44:19 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 15:50:30
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using devitemapi.Entity;
using devitemapi.Infrastructure.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace devitemapi.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : IEntity
    {
        private readonly DevDbContext _dbContext;
        public BaseRepository(DevDbContext devDbContext)
        {
            _dbContext = devDbContext;
        }

        public void Add(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> QueryAsync()
        {
            return await QueryAsync(null);
        }

        public virtual async Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> @where)
        {
            if (@where is null)
            {
                return await _dbContext.Set<TEntity>().ToListAsync();
            }
            return await _dbContext.Set<TEntity>().Where(@where).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> @where, int pageSize,int pageIndex)
        {
            IQueryable<TEntity> queryable;     
            if (@where is null)
            {
                 queryable = _dbContext.Set<TEntity>().AsQueryable<TEntity>();
            }
            else
            {
                queryable =  _dbContext.Set<TEntity>().Where(@where).AsQueryable<TEntity>();
            }
            
            var totalCount = await queryable.CountAsync();

            if(pageIndex <= 0)
            {
                pageIndex = 1;
            }

            if(pageSize * pageIndex > totalCount)
            {
                return await queryable.ToListAsync();
            }

            return await queryable.Skip(pageSize * (pageIndex - 1)).Take(pageSize).ToListAsync();

        }

        public virtual async Task<TEntity> QueryFirstAsync()
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync();
        }

        public virtual Task<TEntity> QueryFirstAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<TEntity> QueryFirstAsync(Guid id)
        {
            return await _dbContext.Set<TEntity>().Where(t=>t.Id == id).FirstOrDefaultAsync();
        }

        public virtual EntityEntry<TEntity> Remove(TEntity entity)
        {
             return _dbContext.Set<TEntity>().Remove(entity);
        }

        public virtual Task<bool> RemoveAsync(Expression<Func<TEntity, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

    }
}