/*
 * @Author: live0x 
 * @Date: 2020-08-19 09:49:09 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-08-19 09:50:22
 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repository.Interface
{
    public interface IDevRoleRepository
    {
        Task<DevRole> GetRoleAsync(Guid guid);

        Task<IEnumerable<DevRole>> GetRolesAsync();

        void AddRole(DevRole role);

        void DeleteRole(DevRole role);

        void UpdateRole(DevRole role);

        Task<bool> ExistsRoleAsync(Guid guid);

        Task<bool> SaveAsync();
    } 
}       