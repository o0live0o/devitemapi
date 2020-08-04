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
        private readonly DevDbContext m_dbContext;

        public RoleService(DevDbContext dbContext)
        {
            this.m_dbContext = dbContext;
        }

        public Task<ResponseDto> Add(DevRole role)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();


                //账号重复判断，不区分大小写
                if (m_dbContext.DevRoles.FirstOrDefault(u => u.RoleName.ToLower().Equals(role.RoleName.ToLower())) != null)
                {
                    response.SetFail("角色已存在");
                    return response;
                }

                role.Status = 1;    //默认启用
                role.CreateDate = DateTime.Now;
                role.ModifyDate = DateTime.Now;

                m_dbContext.DevRoles.Add(role);
                m_dbContext.SaveChanges();
                return response;
            });
        }

        public Task<ResponseDto> Delete(int id)
        {
            return Task.Run(() =>
            {
                ResponseDto response = new ResponseDto();
                var sql = "UPDATE devroles SET Status = 2 WHERE Id = @Id";
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
                string delSql = $"DELETE devroles WHERE Id IN ({ids})";
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
                var role = m_dbContext.DevRoles.Find(id);
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
                var roles = m_dbContext.DevRoles;
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
                using (m_dbContext)
                {
                    var entity = m_dbContext.DevRoles.FirstOrDefault(p => role.Id.Equals(p.Id));
                    if (entity != null)
                    {
                        entity.ModifyDate = DateTime.Now;
                        m_dbContext.SaveChanges();
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
