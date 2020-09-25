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
    public class DevUserRole : BaseEntity<Guid>
    {
        public Guid UseId { get; set; }

        public Guid RoleId { get; set; }

        [ForeignKey("UserId")]
        public DevUser User {get;set;}
    }
}