using System;

namespace devitemapi.Dto.Permission
{
    public class PermissionDto
    {
        public Guid RoleId {get;set;}

        public Guid MemuId { get; set; }

        public Guid ActionId { get; set; }

        
    }
}