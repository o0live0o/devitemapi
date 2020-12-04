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
    public class WxRole : BaseEntity<int>
    {
        public WxRole()
        {
            //DevPermissions = new List<DevPermission>();
        }

        public string RoleName { get; set; }

        public string RoleCode { get; set; }

        public int Status { get; set; }

        public List<WxPermission> DevPermissions { get; } = new List<WxPermission>();

        public void AddPermission(int id, int menuId, int actionId)
        {
            var existsPermission = DevPermissions.FirstOrDefault(p => p.MenuId == menuId && p.ActionId == actionId);
            if (existsPermission == null)
            {
                DevPermissions.Add(new WxPermission(){
                    //Id = id,
                    MenuId = menuId,
                    ActionId = actionId
                });
            }
            else
            {
                existsPermission.UpdatePermision(menuId, actionId);
            }
        }
    }
}