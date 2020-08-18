using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Infrastructure.Repository
{
    public class DevActionRepository : IDevActionRepository
    {
        private readonly DevDbContext _dbContext;

        public DevActionRepository(DevDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void AddAction(DevAction action)
        {
            if(action == null)
            {
                throw new ArgumentNullException(nameof(action));
            }
            action.Id = Guid.NewGuid();
            _dbContext.DevActions.Add(action);
        }

        public void DeleteAction(DevAction action)
        {
           _dbContext.DevActions.Remove(action);
        }

        public async Task<bool> ExistsActionAsync(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            return await _dbContext.DevActions.AnyAsync(a=>guid == a.Id);
        }

        public async Task<DevAction> GetActionAsync(Guid guid)
        {
            if(guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            var action = await _dbContext.DevActions.FirstOrDefaultAsync(p=>p.Id == guid);
            return action;
        }

        public async Task<IEnumerable<DevAction>> GetActionsAsync()
        {
            return await _dbContext.DevActions.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void UpdateAction(DevAction action)
        {
            
        }
    }
}