using System;

namespace devitemapi.Dto.Permission
{
    public class PermissionAddDto
    {
        public Guid RoleId { get; set; }

        public Guid MemuId { get; set; }
    }
}