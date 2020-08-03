using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevRolePermission
    {
        public int Id { get; set; }

        public int RoleId { get; set; }

        public int MemuId { get; set; }

        public int ActionId { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
