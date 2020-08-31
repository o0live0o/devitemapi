using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entities;
using devitemapi.Infrastructure.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace devitemapi.Infrastructure.Repository
{
    public class DevUserRepository:IDevUserRepository
    {
        private readonly DevDbContext _dbContext;

        public DevUserRepository(DevDbContext dbContext)
        {
            this._dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }

        public void AddUser(DevUser user)
        {
            if(user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }
            user.Id = Guid.NewGuid();
            _dbContext.DevUsers.Add(user);
        }

        public void DeleteUser(DevUser user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            _dbContext.DevUsers.Remove(user);
        }

        public Task<bool> ExistsUserAsync(Guid guid)
        {
            if(guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            return _dbContext.DevUsers.AnyAsync(x=>guid == x.Id);
        }

        public async Task<DevUser> GetUserAsync(Guid guid)
        {
            if(guid == Guid.Empty)
            {
                throw new ArgumentNullException(nameof(guid));
            }
            var user = await _dbContext.DevUsers.FirstOrDefaultAsync(u=>guid == u.Id);
            return user;
        }

        public async Task<DevUser> GetUserAsync(string account, string pwd)
        {
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(pwd))
            {
                throw new ArgumentNullException(nameof(account)+" or "+nameof(pwd));
            }
            return await _dbContext.DevUsers.FirstOrDefaultAsync(u=>u.Account ==  account && u.Pwd == pwd);
        }

        public async Task<IEnumerable<DevUser>> GetUsersAsync()
        {
           return await _dbContext.DevUsers.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() >=0;
        }

        public void UpdateUser(DevUser user)
        {
            
        }
    }
}