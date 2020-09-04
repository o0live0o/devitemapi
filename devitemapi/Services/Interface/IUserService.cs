/*
 * @Author: live0x 
 * @Date: 2020-09-04 11:44:54 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 15:00:12
 */
using devitemapi.Dto;
using devitemapi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services.Interface
{
    public interface IUserService : IBaseService<DevUser>
    {
        Task<DevUser> CreateUser(DevUser user);

        Task<DevUser> QueryUserByAccount(string account,string pwd);
  
        DevUser UpdateUser(DevUser user);
    }
}
