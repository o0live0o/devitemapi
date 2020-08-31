using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entities;

namespace devitemapi.Infrastructure.Repository.Interface
{
    public interface IDevUserRepository
    {
        Task<DevUser> GetUserAsync(Guid guid);

        Task<DevUser> GetUserAsync(string account,string pwd);

        Task<IEnumerable<DevUser>> GetUsersAsync();

        void AddUser(DevUser user);

        void DeleteUser(DevUser user);

        void UpdateUser(DevUser user);

        Task<bool> ExistsUserAsync(Guid guid);

        Task<bool> SaveAsync();
    } 
}