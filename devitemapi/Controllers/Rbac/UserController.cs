using devitemapi.Common;
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
            var str = RedisClient.GetRedisClient.GetString("key1");
            if (str == null)
            {
                RedisClient.GetRedisClient.SetString("key1","HA");
            }
            return Ok(dbContext.DevUsers.AsEnumerable());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return NoContent();
        }

        [HttpGet("{id}")]
        public IActionResult Detete(int id)
        {
            var sql = "UPDATE DevUser SET Status = 2 WHERE Id = @Id";
            SqlParameter[] parameters = new []{
                new SqlParameter("@Id", id)
            };
            //dbContext.Database.ExecuteSqlCommand(sql,parameters);
            var transAction = RelationalDatabaseFacadeExtensions.BeginTransaction(new DatabaseFacade(dbContext),System.Data.IsolationLevel.ReadCommitted);
            dbContext.Database.ExecuteSqlRaw(sql,parameters);
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
        
    }
}
