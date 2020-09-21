using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace devitemapi.Entity
{
    public class DevMenuAction : BaseEntity
    {
        public Guid MenuId { get; set; }

        public Guid ActionId { get; set; }

        [ForeignKey("MenuId")]
        public DevMenu DevMenu { get;set;}
    }
}