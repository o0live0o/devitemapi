using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using devitemapi.Entity;

namespace devitemapi.Infrastructure.Repository.Interface
{
    public interface IDevActionRepository
    {
        Task<DevAction> GetActionAsync(Guid guid);

        Task<IEnumerable<DevAction>> GetActionsAsync();

        void AddAction(DevAction action);

        void DeleteAction(DevAction action);

        void UpdateAction(DevAction action);

        Task<bool> ExistsActionAsync(Guid guid);

        Task<bool> SaveAsync();
    }
}