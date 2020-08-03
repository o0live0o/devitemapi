using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using devitemapi.Common;
using devitemapi.Dtos;
using devitemapi.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace devitemapi.Controllers.Rbac
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly DevDbContext dbContext;

        public RoleController(DevDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            ResponseDto response = new ResponseDto();
            response.SetData(dbContext.DevRoles.AsEnumerable());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            ResponseDto response = new ResponseDto();
            var result = dbContext.DevRoles.Find(id);

            if (result == null)
            {
                response.SetFail("查询不到角色信息");
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
            var sql = "UPDATE DevRoles SET Status = 2 WHERE Id = @Id";
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
        public IActionResult Add(DevRole role)
        {
            ResponseDto response = new ResponseDto();

            //角色重复判断
            if (dbContext.DevRoles.FirstOrDefault(u => u.RoleName.ToLower().Equals(role.RoleName.ToLower())) != null)
            {
                response.SetFail("角色已存在");
                return Ok(response);
            }

            role.Status = 1;    //默认启用
            role.CreateDate = DateTime.Now;
            role.ModifyDate = DateTime.Now;

            dbContext.DevRoles.Add(role);
            dbContext.SaveChanges();

            return Ok(response);
        }

        public IActionResult AssignPermission()
        {
            return NoContent();
        }
    }
}
