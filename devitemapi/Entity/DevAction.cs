using System;

namespace devitemapi.Entity
{
    public class DevAction : BaseEntity<Guid>
    {
        public string ActionName { get; set; }

        public string ActionCode { get; set; }
    }
}