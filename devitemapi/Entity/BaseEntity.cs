using System;

namespace devitemapi.Entity
{
    public class BaseEntity : IEntity
    {
        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }
    }
}