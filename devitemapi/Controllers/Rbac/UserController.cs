using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Controllers.Rbac
{
    [Route("[controller]/[Action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DevDbContext dbContext;

        public UserController(DevDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ResponseDto response = new ResponseDto();
            response.SetData(dbContext.DevUsers.AsEnumerable());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ResponseDto response = new ResponseDto();
            var result = dbContext.DevUsers.Find(id);

            if (result == null)
            {
                response.SetFail("查询不到用户信息");
            }
            else
            {
                response.Data = result;
            }

            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Detete(int id)
        {
            var sql = "UPDATE DevUser SET Status = 2 WHERE Id = @Id";
            SqlParameter[] parameters = new[]{
                new SqlParameter("@Id", id)
            };
            //dbContext.Database.ExecuteSqlCommand(sql,parameters);
            var transAction = RelationalDatabaseFacadeExtensions.BeginTransaction(new DatabaseFacade(dbContext), System.Data.IsolationLevel.ReadCommitted);
            dbContext.Database.ExecuteSqlRaw(sql, parameters);
            transAction.Commit();
            return NoContent();
        }

        [HttpPost]
        public IActionResult Add(DevUser user)
        {
            ResponseDto response = new ResponseDto();

            //过滤超级管理员账号
            if (user.Account.ToLower().Equals("administrator") ||
                user.Account.ToLower().Equals("admin"))
            {
                response.SetFail("用户账号非法");
                return Ok(response);
            }

            //账号重复判断，不区分大小写
            if (dbContext.DevUsers.FirstOrDefault(u => u.Account.ToLower().Equals(user.Account.ToLower())) != null)
            {
                response.SetFail("用户账号已存在");
                return Ok(response);
            }

            user.Status = 1;    //默认启用
            user.CreateDate = DateTime.Now;
            user.ModifyDate = DateTime.Now;

            dbContext.DevUsers.Add(user);
            dbContext.SaveChanges();

            return Ok(response);
        }

        [HttpPost]
        public IActionResult ModifyUser(DevUser user)
        {
            ResponseDto response = new ResponseDto();
            using (dbContext)
            {
                var entity = dbContext.DevUsers.FirstOrDefault(p => user.Id.Equals(p.Id));
                if (entity != null)
                {
                    entity.ModifyDate = DateTime.Now;
                    entity.Phone = user.Phone;
                    entity.Pwd = user.Pwd;
                    entity.Address = user.Address;
                    entity.EMail = user.EMail;
                    dbContext.SaveChanges();
                    response.SetSuccess("用户信息修改成功");
                }
                else
                {
                    response.SetFail("用户不存在");
                  
                }
            }
            return Ok(response);
        }

    }
}
