/*
 * @Author: live0x 
 * @Date: 2020-08-19 09:55:59 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-08-19 11:20:12
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Infrastructure.Repository
{
    public class DevRoleRepository : IDevRoleRepository
    {
        private readonly DevDbContext _dbContext;

        public DevRoleRepository(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void AddRole(DevRole role)
        {
            if (role == null)
            {
                throw new ArgumentNullException(nameof(role));
            }
            role.Id = Guid.NewGuid();
            _dbContext.DevRoles.Add(role);
        }

        public void DeleteRole(DevRole role)
        {
            _dbContext.DevRoles.Remove(role);
        }

        public async Task<bool> ExistsRoleAsync(Guid guid)
        {
            return await _dbContext.DevRoles.AnyAsync(p => p.Id == guid);
        }

        public async Task<DevRole> GetRoleAsync(Guid guid)
        {
            if (guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            var role = await _dbContext.DevRoles.FirstOrDefaultAsync(u => guid == u.Id);
            return role;
        }

        public async Task<IEnumerable<DevRole>> GetRolesAsync()
        {
            return await _dbContext.DevRoles.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void UpdateRole(DevRole role)
        {

        }
    }
}