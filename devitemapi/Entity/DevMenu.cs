using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entity
{
    public class DevMenu: BaseEntity
    {

        public string MenuName { get; set; }

        public int ParentId { get; set; }

        public string Url { get; set; }

        public string Icon { get; set; }


    }
}
