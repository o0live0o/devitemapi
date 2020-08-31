using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevRole: BaseEntity
    {
        public string RoleName { get; set; }

        public int Status { get; set; }

    }
}
