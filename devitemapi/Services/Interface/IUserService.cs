/*
 * @Author: live0x
 * @Date: 2020-09-04 11:44:54
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 14:14:50
 */

using devitemapi.Dto.User;
using devitemapi.Entity;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IUserService : IBaseService<DevUser>
    {
        Task<UserDto> CreateUser(UserAddOrUpdateDto user);

        Task<DevUser> QueryUserByAccount(string account, string pwd);

        DevUser UpdateUser(DevUser user);
    }
}