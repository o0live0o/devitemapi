using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace devitemapi.Entity
{
    public class WxMenuAction : BaseEntity<int>
    {
        public int MenuId { get; set; }

        public int ActionId { get; set; }

        [ForeignKey("MenuId")]
        public WxMenu DevMenu { get;set;}
    }
}