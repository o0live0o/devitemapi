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
    public class WxPermission : BaseEntity<int>
    {
        public int RoleId { get; set; }

        public int MenuId { get; set; }

        public int ActionId { get; set; }
        
        [ForeignKey("RoleId")]
        public WxRole WxRole { get; set; }

        public WxPermission()
        {
        
        }


        public WxPermission(int id,int menuId, int actionId)
        {
            //Id = id;
            MenuId = menuId;
            ActionId = actionId;
        }

        public void UpdatePermision(int menuId, int actionId)
        {
            this.MenuId = menuId;
            this.ActionId = actionId;
        }
    }
}