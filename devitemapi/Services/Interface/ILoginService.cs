using devitemapi.Entity;
using System;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface ILoginService
    {
        Task<object> GetMenuTreeByUser(Guid userId);

        void GetMenuTreeByRole(Guid roleId);

        void GetPermissionByUser(Guid userId);

        void GetPermissionByRole(Guid roleId);

        void UpdatePermission(Guid roleId, DevPermission permission);
    }
}