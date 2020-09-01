using devitemapi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace devitemapi.Dto
{
    public class RolePermissionPayload
    {
        public RolePermissionPayload()
        {
            //Permissions = new List<DevPermission>();
        }

        public int RoleId { get; set; }

      // public List<DevPermission>  Permissions { get; set; }
    }
}
