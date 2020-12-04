/*
 * @Author: live0x
 * @Date: 2020-09-04 11:44:54
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-09 14:14:50
 */

using devitemapi.Dto.User;
using devitemapi.Entity;
using System;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IUserService : IBaseService<WxUser,int>
    {
        Task<UserDto> CreateUser(UserAddOrUpdateDto user);

        Task<WxUser> QueryUserByAccount(string account, string pwd);
        Task<WxUser> QueryUserByUserCode(string userCode);
    }
}