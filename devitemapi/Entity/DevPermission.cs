using System;

namespace devitemapi.Entity
{
    public class DevPermission : BaseEntity
    {
        public Guid RoleId { get; set; }

        public Guid MemuId { get; set; }

        public Guid ActionId { get; set; }
    }
}