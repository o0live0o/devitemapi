/*
 * @Author: live0x
 * @Date: 2020-09-05 11:55:09
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-19 11:58:59
 */

using AutoMapper;
using devitemapi.Dto.Role;
using devitemapi.Entity;
using devitemapi.Infrastructure.Exceptions;
using devitemapi.Infrastructure.Message;
using devitemapi.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace devitemapi.Controllers.Rbac
{
    /// <summary>
    /// 角色管理
    /// </summary>
    //[Route("api/[controller]/[action]")]
    //[ApiController]
    [Route("roles")]
    public class RoleController : BaseController
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;
        private readonly DevDbContext _dbContext;

        public RoleController(
            IRoleService roleService,
            IPermissionService permissionService,
            IMapper mapper,
            DevDbContext dbContext)
        {
            this._roleService = roleService ?? throw new ArgumentNullException(nameof(roleService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._dbContext = dbContext;
        }

        [HttpGet("{roleId}", Name = nameof(GetRoleById))]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(RoleDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<RoleDto>> GetRoleById(Guid roleId)
        {
            if (roleId == Guid.Empty)
            {
                throw new ItemException(TipsTxt.ROLE_ID_EMPTY);
            }
            var role = await _roleService.QueryByIdAsync(roleId);
            if (role == null)
            {
                return NotFound();
            }
            return Ok(role);
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<RoleDto>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<RoleDto>>> GetRoles(int pageSize = 20, int pageIndex = 1)
        {
            var roles = await _roleService.QueryAsync(pageSize, pageIndex);
            return Ok(roles);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<ActionResult> CreateRole(RoleAddOrUpdateDto role)
        {
            var roleEntity = _mapper.Map<DevRole>(role);
            _roleService.Add(roleEntity);
            await _roleService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetRoleById), new { roleId = roleEntity.Id }, null);
        }

        [HttpDelete("{roleId}")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]
        public async Task<ActionResult> DeleteRole(Guid roleId)
        {
            if (roleId == Guid.Empty)
            {
                throw new ItemException(TipsTxt.ROLE_ID_EMPTY);
            }
            var role = await _roleService.QueryByIdAsync(roleId);
            if (role == null)
            {
                return NotFound();
            }
            _roleService.Remove(role);
            await _roleService.SaveChangeAsync();
            return NoContent();
        }

        [HttpPut("roleId")]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        public async Task<IActionResult> UpdateRole(Guid roleId, RoleAddOrUpdateDto role)
        {
            if (roleId == Guid.Empty)
            {
                throw new ItemException(TipsTxt.ROLE_ID_EMPTY);
            }

            var roleEntity = await _roleService.QueryByIdAsync(roleId);

            if (roleEntity == null)
            {
                return NotFound();
            }

            _mapper.Map(role, roleEntity);
            await _roleService.SaveChangeAsync();
            return CreatedAtRoute(nameof(GetRoleById), new { roleId }, null);
        }

        [HttpGet]
        [Route("tet")]
        public async Task<IActionResult> Test()
        {
            try
            {
                //var roles = _dbContext.DevRoles.FirstOrDefault();
                //roles.AddPermission(Guid.NewGuid(), Guid.NewGuid());
                //roles.ModifyDate = DateTime.Now;
                // _dbContext.DevPermissions.AddRange(roles.DevPermissions);
                _dbContext.Add(new DevRole()
                {
                    Id = Guid.NewGuid(),
                    CreateDate = DateTime.Now,
                    ModifyDate = DateTime.Now
                });
                _dbContext.SaveChanges();
                var role = _dbContext.DevRoles.OrderBy(p => p.CreateDate).First();
                role.RoleName = "Test";
                role.AddPermission(Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid());
                _dbContext.SaveChanges();

                // _dbContext.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
                // _dbContext.SaveChanges();

                // // Read
                // Console.WriteLine("Querying for a blog");
                // var blog = _dbContext.Blogs
                //     .OrderBy(b => b.BlogId)
                //     .First();

                // // Update
                // Console.WriteLine("Updating the blog and adding a post");
                // blog.Url = "https://devblogs.microsoft.com/dotnet";
                // blog.Posts.Add(
                //     new Post
                //     {
                //         Title = "Hello World",
                //         Content = "I wrote an app using EF Core!"
                //     });
                // _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return Ok();
        }

    }
}