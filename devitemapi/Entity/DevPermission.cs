/*
 * @Author: live0x 
 * @Date: 2020-09-14 14:30:47 
 * @Last Modified by: live0x
 * @Last Modified time: 2020-09-14 15:23:04
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace devitemapi.Entity
{
    public class DevPermission : BaseEntity
    {
        public Guid RoleId { get; set; }

        public Guid MenuId { get; set; }

        public Guid ActionId { get; set; }
        
        [ForeignKey("RoleId")]
        public DevRole DevRole { get; set; }

        public DevPermission()
        {
        
        }


        public DevPermission(Guid id,Guid menuId, Guid actionId)
        {
            //Id = id;
            MenuId = menuId;
            ActionId = actionId;
        }

        public void UpdatePermision(Guid menuId, Guid actionId)
        {
            this.MenuId = menuId;
            this.ActionId = actionId;
        }
    }
}