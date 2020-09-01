using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repository.Interface
{
    public interface IDevMenuRepository
    {
        Task<DevMenu> GetMenuAsync(Guid guid);

        Task<IEnumerable<DevMenu>> GetMenusAsync();

        void AddMenu(DevMenu menu);

        void DeleteMenu(DevMenu menu);

        void UpdateMenu(DevMenu menu);

        Task<bool> ExistsMenuAsync(Guid guid);

        Task<bool> SaveAsync();
    }

}