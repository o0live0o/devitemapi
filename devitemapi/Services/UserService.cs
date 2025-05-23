﻿/*
 * @Author: live0x
 * @Date: 2020-09-04 10:17:21
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-25 08:52:51
 */

using AutoMapper;
using devitemapi.Dto.User;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Infrastructure.Repositories.Interface;
using devitemapi.Services.Interface;
using System;
using System.Threading.Tasks;

namespace devitemapi.Services
{
    public class UserService : BaseService<DevUser,Guid>, IUserService
    {
        private readonly IBaseRepository<DevUser,Guid> _repository;
        private readonly IMapper _mapper;

        public UserService(IBaseRepository<DevUser,Guid> repository, IMapper mapper) : base(repository)
        {
            this._repository = repository;
            this._mapper = mapper;
        }

        public async Task<UserDto> CreateUser(UserAddOrUpdateDto user)
        {
            //过滤超级管理员账号
            if (user.Account.ToLower().Equals("administrator") ||
                user.Account.ToLower().Equals("admin"))
            {
                throw new ItemException(TipsTxt.USER_ILLEGAL_ACCOUNT);
            }

            //账号重复判断，不区分大小写
            var existsUser = await _repository.QueryFirstAsync(u => u.Account.ToLower().Equals(user.Account.ToLower()));

            if (existsUser != null)
            {
                throw new ItemException(TipsTxt.USER_ALREADY_EXISTS);
            }

            var devUser = _mapper.Map<DevUser>(user);
            devUser.Id = Guid.NewGuid();
            devUser.Status = 1;    //默认启用
            devUser.CreateDate = DateTime.Now;
            devUser.ModifyDate = DateTime.Now;

            Add(devUser);

            return _mapper.Map<UserDto>(devUser);
        }


        public async Task<DevUser> QueryUserByAccount(string account, string pwd)
        {
            return await _repository.QueryFirstAsync(u => u.Account == account && u.Pwd == pwd);
        }
    }
}