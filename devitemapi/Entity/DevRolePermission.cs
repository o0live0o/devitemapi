using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entity
{
    public class DevRolePermission: BaseEntity
    {

        public int RoleId { get; set; }

        public int MemuId { get; set; }

        public int ActionId { get; set; }

    }
}
