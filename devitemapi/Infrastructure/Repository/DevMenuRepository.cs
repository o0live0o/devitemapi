using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Infrastructure.Repository
{
    public class DevMenuRepository : IDevMenuRepository
    {
        private readonly DevDbContext _dbcontext;

        public DevMenuRepository(DevDbContext dbcontext)
        {
            this._dbcontext = dbcontext;
        }
        public void AddMenu(DevMenu menu)
        {
           if (menu == null)
           {
              throw new ArgumentNullException(nameof(menu));
           }
           menu.Id = Guid.NewGuid();
           _dbcontext.DevMenus.Add(menu);
        }

        public void DeleteMenu(DevMenu menu)
        {
            _dbcontext.DevMenus.Remove(menu);
        }

        public async Task<bool> ExistsMenuAsync(Guid guid)
        {
            return await _dbcontext.DevMenus.AnyAsync(u=>guid == u.Id);
        }

        public async Task<DevMenu> GetMenuAsync(Guid guid)
        {
            if(guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            var menu = await _dbcontext.DevMenus.FirstOrDefaultAsync(p=>guid == p.Id);
            return menu;
        }

        public async Task<IEnumerable<DevMenu>> GetMenusAsync()
        {
            return await _dbcontext.DevMenus.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
           return await _dbcontext.SaveChangesAsync() > 0;
        }

        public void UpdateMenu(DevMenu menu)
        {
            
        }
    }
}