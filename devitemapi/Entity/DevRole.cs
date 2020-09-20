/*
 * @Author: live0x 
 * @Date: 2020-09-14 14:30:57 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-14 15:14:45
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace devitemapi.Entity
{
    public class DevRole : BaseEntity
    {
        public DevRole()
        {
            //DevPermissions = new List<DevPermission>();
        }

        public DevRole(Guid id)
        {
            this.Id = id;
        }
        public string RoleName { get; set; }

        public string RoleCode { get; set; }

        public int Status { get; set; }

        public List<DevPermission> DevPermissions { get; } = new List<DevPermission>();

        public void AddPermission(Guid id, Guid menuId, Guid actionId)
        {
            var existsPermission = DevPermissions.FirstOrDefault(p => p.MenuId == menuId && p.ActionId == actionId);
            if (existsPermission == null)
            {
                DevPermissions.Add(new DevPermission(id, menuId,actionId));
            }
            else
            {
                existsPermission.UpdatePermision(menuId, actionId);
            }
        }
    }
}