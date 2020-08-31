using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Entities
{
    public class DevUserRole : BaseEntity
    {
        public int Useid { get; set; }

        public int RoleId { get; set; }

    }
}
