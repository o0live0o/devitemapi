/*
 * @Author: live0x 
 * @Date: 2020-09-04 10:17:21 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-04 14:55:23
 */
using devitemapi.Common;
using devitemapi.Dto;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Infrastructure.Repository.Interface;
using devitemapi.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class UserService : BaseService<DevUser>, IUserService
    {

        private readonly IBaseRepository<DevUser> _repository;

        public UserService(IBaseRepository<DevUser> repository) : base(repository)
        {
            this._repository = repository;
        }

        public async Task<DevUser> CreateUser(DevUser user)
        {
            //过滤超级管理员账号
            if (user.Account.ToLower().Equals("administrator") ||
                user.Account.ToLower().Equals("admin"))
            {
                throw new ItemException(ErrorTxt.USER_ILLEGAL_ACCOUNT);
            }

            //账号重复判断，不区分大小写
            var existsUser = await _repository.QueryFirstAsync(u => u.Account.ToLower().Equals(user.Account.ToLower()));

            if (existsUser != null)
            {
                throw new ItemException(ErrorTxt.USER_ALREADY_EXISTS);
            }

            user.Status = 1;    //默认启用
            user.CreateDate = DateTime.Now;
            user.ModifyDate = DateTime.Now;

            Add(user);
            return user;
        }

        public async Task<DevUser> QueryUserByAccount(string account, string pwd)
        {
            return await _repository.QueryFirstAsync(u=>u.Account == account && u.Pwd == pwd);
        }

        public DevUser UpdateUser(DevUser user)
        {
            return default;
        }
    }
}
