using System;
using System.Collections.Generic;
using devitemapi.Dto.Action;
using devitemapi.Dto.Menu;

namespace devitemapi.Dto.Rbac
{
    public class MenuActionDto
    {
        public Guid MenuId { get; set; }

        public string MenuCode { get; set; }
        
        public string MenuName { get; set; }

        public Guid ParentId { get; set; }

        public string Path { get; set; }

        public string Icon { get; set; }

        public IEnumerable<ActionDto> Actions { get; set; }
    }
}