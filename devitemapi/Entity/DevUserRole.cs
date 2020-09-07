using System;

namespace devitemapi.Entity
{
    public class DevUserRole : BaseEntity
    {
        public Guid Useid { get; set; }

        public Guid RoleId { get; set; }
    }
}