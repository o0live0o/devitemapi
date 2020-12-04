using System;
using System.Collections.Generic;

namespace devitemapi.Entity
{
    public class WxMenu : BaseEntity<int>
    {
        public string MenuCode { get; set; }
        public string MenuName { get; set; }

        public int ParentId { get; set; }

        public string Path { get; set; }

        public string Icon { get; set; }

        public List<WxMenuAction> DevMenuActions { get; } = new List<WxMenuAction>();
    }
}