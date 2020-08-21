using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using devitemapi.Infrastructure.Services.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Infrastructure.Services
{
    public class RoleService : IRoleService
    {
        private readonly DevDbContext _dbContext;

        public RoleService(DevDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevRole role)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();


                //账号重复判断，不区分大小写
                if (_dbContext.DevRoles.FirstOrDefault(u => u.RoleName.ToLower().Equals(role.RoleName.ToLower())) != null)
                {
                    response.SetFail("角色已存在");
                    return response;
                }

                role.Status = 1;    //默认启用
                role.CreateDate = DateTime.Now;
                role.ModifyDate = DateTime.Now;

                _dbContext.DevRoles.Add(role);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto> Delete(string ids)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                string delSql = $"DELETE devroles WHERE Id IN ({ids})";
                _dbContext.Database.ExecuteSqlRaw(delSql);
                _dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Get(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var role = _dbContext.DevRoles.Find(id);
                if (role == null)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(role);
                return response;
            });
        }

        public Task<ResponseDto> Get()
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var roles = _dbContext.DevRoles;
                if (roles == null || roles.Count() < 1)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(roles);
                return response;
            });
        }

        public Task<ResponseDto> Modify(DevRole role)
        {
            return Task.Run(()=>{
                ResponseDto response = new ResponseDto();
                using (_dbContext)
                {
                    var entity = _dbContext.DevRoles.FirstOrDefault(p => role.Id.Equals(p.Id));
                    if (entity != null)
                    {
                        entity.ModifyDate = DateTime.Now;
                        _dbContext.SaveChanges();
                        response.SetSuccess(MessageTxt.PASS_MODIFY_ROLE);
                    }
                    else
                        response.SetFail(MessageTxt.ERROR_NOT_EXISTS_ROLE);
                }
                return response;
            });
        }
    }
}
