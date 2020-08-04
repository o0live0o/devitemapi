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
    public class UserService : IUserService
    {
        private readonly DevDbContext m_dbContext;

        public UserService(DevDbContext dbContext)
        {
            this.m_dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevUser user)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();

                //过滤超级管理员账号
                if (user.Account.ToLower().Equals("administrator") ||
                    user.Account.ToLower().Equals("admin"))
                {
                    response.SetFail("用户账号非法");
                    return response;
                }

                //账号重复判断，不区分大小写
                if (m_dbContext.DevUsers.FirstOrDefault(u => u.Account.ToLower().Equals(user.Account.ToLower())) != null)
                {
                    response.SetFail("用户账号已存在");
                    return response;
                }

                user.Status = 1;    //默认启用
                user.CreateDate = DateTime.Now;
                user.ModifyDate = DateTime.Now;

                m_dbContext.DevUsers.Add(user);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var sql = "UPDATE devusers SET Status = 2 WHERE Id = @Id";
                MySqlParameter[] parameters = new[]{
                new MySqlParameter("@Id", id)
            };
                //dbContext.Database.ExecuteSqlCommand(sql,parameters);
                var transAction = RelationalDatabaseFacadeExtensions.BeginTransaction(new DatabaseFacade(m_dbContext), System.Data.IsolationLevel.ReadCommitted);
                m_dbContext.Database.ExecuteSqlRaw(sql, parameters);
                transAction.Commit();
                return response;
            });
        }

        public Task<ResponseDto> Delete(string ids)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                string delSql = $"DELETE devusers WHERE Id IN ({ids})";
                m_dbContext.Database.ExecuteSqlRaw(delSql);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Get(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var user = m_dbContext.DevUsers.Find(id);
                if (user == null)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(user);
                return response;
            });
        }

        public Task<ResponseDto> Get()
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var users = m_dbContext.DevUsers;
                if (users == null || users.Count() < 1)
                    response.SetFail(MessageTxt.EMPTY_SEARCH);
                else
                    response.SetData(users);
                return response;
            });
        }

        public Task<ResponseDto> Modify(DevUser user)
        {
            return Task.Run(()=>{
                ResponseDto response = new ResponseDto();
                using (m_dbContext)
                {
                    var entity = m_dbContext.DevUsers.FirstOrDefault(p => user.Id.Equals(p.Id));
                    if (entity != null)
                    {
                        entity.ModifyDate = DateTime.Now;
                        entity.Phone = user.Phone;
                        entity.Pwd = user.Pwd;
                        entity.Address = user.Address;
                        entity.EMail = user.EMail;
                        m_dbContext.SaveChanges();
                        response.SetSuccess("用户信息修改成功");
                    }
                    else
                        response.SetFail("用户不存在");
                }
                return response;
            });
        }
    }
}
