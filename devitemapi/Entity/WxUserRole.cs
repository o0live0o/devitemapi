/*
 * @Author: live0x 
 * @Date: 2020-09-21 16:44:22 
 * @Last Modified by:   live0x 
 * @Last Modified time: 2020-09-21 16:44:22 
 */
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace devitemapi.Entity
{
    public class WxUserRole : BaseEntity<int>
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("UserId")]
        public WxUser User {get;set;}
    }
}