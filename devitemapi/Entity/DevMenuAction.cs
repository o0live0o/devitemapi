using System;

namespace devitemapi.Entity
{
    public class DevMenuAction : BaseEntity
    {
        public Guid MenuId { get; set; }

        public Guid ActionId { get; set; }
    }
}