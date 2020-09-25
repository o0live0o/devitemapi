using System;
using System.Collections.Generic;

namespace devitemapi.Entity
{
    public class DevMenu : BaseEntity<Guid>
    {
        public string MenuCode { get; set; }
        public string MenuName { get; set; }

        public Guid ParentId { get; set; }

        public string Path { get; set; }

        public string Icon { get; set; }

        public List<DevMenuAction> DevMenuActions { get; } = new List<DevMenuAction>();
    }
}